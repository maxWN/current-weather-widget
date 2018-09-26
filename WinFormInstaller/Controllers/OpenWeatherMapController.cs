using Newtonsoft.Json.Linq;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WinFormInstaller.DataModels;

namespace WinFormInstaller
{
    public class WeatherMap
    {
        //private string paritalURL = "https://api.openweathermap.org/data/2.5/weather";
        private string paritalURL = "https://samples.openweathermap.org/data/2.5/weather";

        #region Private Methods

        /// <summary>
        /// Gets the asynchronous response after making the call to the API.
        /// </summary>
        private async Task<T> GetAsync<T>(string requestUrl) where T : class
        {
            #region Local Variables

            T retVal = null;

            #endregion Local Variables

            #region Actions

            Console.WriteLine("GetAsync() has started execution successfully.");

            try
            {
                HttpClient client = new HttpClient();

                using (HttpResponseMessage response = await client.GetAsync(requestUrl))
                {
                    using (HttpContent content = response.Content)
                    {
                        if (response.StatusCode != HttpStatusCode.OK)
                        {
                            throw new Exception(response.ToString());
                        }
                        retVal = await ParseContent<T>(content);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            Console.WriteLine("GetAsync() has finished execution successfully.");

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

            string result = await content.ReadAsStringAsync();

            //WeatherMap type = Type.GetType(result);
            //object instance = Activator.CreateInstance(type);

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

            string secretKey= "&appid=b6907d289e10d714a6e88b30761fae22";

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

        #region Temporary Method
        //private async Task<T> GetOpenWeatherMapResponse<T>(string args) where T: class {

        //    T retVal = null;
        //    try
        //    {
        //        if (args != null)
        //        {

        //            retVal = await GetAsync<T>(args);

        //        }
        //    }
        //    catch (ArgumentException ex) {
        //        Log.Information("The following error, " + ex + ", occurred in GetOpenWeatherMapResonse() at" + DateTime.Now);
        //        throw;
        //    }
        //    return retVal;

        //}
        #endregion Temporary Method

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
                    retVal = await GetAsync<CurrentWeather>(uriPath);
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
