using Newtonsoft.Json.Linq;
using Serilog;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using WinFormInstaller.DataModels;
using System.Configuration;

namespace WinFormInstaller
{
    public class WeatherMap
    {
        //private string paritalURL = "https://api.openweathermap.org/data/2.5/weather";
        private string secretKey;
        private string paritalURL;

        public WeatherMap() {
            secretKey = ConfigurationManager.AppSettings["apiConnectionString"];
            paritalURL = ConfigurationManager.AppSettings["apiUrl"];
        }

        #region Private Methods

        /// <summary>
        /// Gets the asynchronous response after making the call to the API.
        /// </summary>
        private async Task<T> GetAsync<T>(string requestUrl) where T : class
        {
            T retVal = null;

            #region Actions

            try
            {
                HttpClient client = new HttpClient();

                using (HttpResponseMessage response = await client.GetAsync(requestUrl).ConfigureAwait(false))
                {
                    using (HttpContent content = response.Content)
                    {
                        if (response.StatusCode != HttpStatusCode.OK)
                        {
                            throw new Exception(response.ToString());
                        }
                        retVal = await ParseContent<T>(content).ConfigureAwait(false);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return retVal;

            #endregion Actions
        }

        /// <summary>
        /// Parses the returned HTTP content into .NET types
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="content"></param>
        /// <returns></returns>
        private async Task<T> ParseContent<T>(HttpContent content) where T : class {

            dynamic retVal = null;

            string result = await content.ReadAsStringAsync().ConfigureAwait(false);
            if (result != null) {
                JObject jobject = JObject.Parse(result);
                JToken memberName = (JArray)jobject["weather"];
                retVal = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(result);
                retVal.primary = memberName.ToObject<List<Weather>>().ToArray();
            }

            //return result == null ? null : Newtonsoft.Json.JsonConvert.DeserializeObject<T>(result);

            return retVal;
        }

        /// <summary>
        /// Constructs an API url from parameters
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        private string BuildParameters(string args) {

            //Create service that first requires user to sign up to site
            //then enter in their API key...            
            if (args != null) {
                paritalURL += string.Format("?q={0}{1}", args, secretKey);
            }
            else {
                throw new ArgumentNullException("BuildParameters() Error: Invalid argument was given.");
            }

            return paritalURL;

        }

        #endregion Private Methods

        #region Public Methods 

        /// <summary>
        /// Provides the location to the actual API call
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public CurrentWeather GetCurrentWeather(string location) {

            CurrentWeather retVal = null;
            string uriPath;

            if (location != null && location.Length > 0)
            {
                uriPath = BuildParameters(location);

                Task.Run(async () =>
                {
                    retVal = await GetAsync<CurrentWeather>(uriPath).ConfigureAwait(false);
                }).Wait();

            }
            else {
                throw new ArgumentNullException("GetCurrentWeather() Error: Invalid argument was given.");
            }

            return retVal;
        }

        #endregion Public Methods
    }
}
