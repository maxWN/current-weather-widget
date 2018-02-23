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
        private string paritalURL = "https://api.openweathermap.org/data/2.5/weather";

        #region Private Methods

        ///// <summary>
        ///// Gets the asynchronous response after making the call to the API.
        ///// </summary>
        private async Task<T> GetAsync<T>(string requestUrl) where T : class
        {
            #region Local Variables

            T retVal = null;

            #endregion Local Variables

            #region Actions

            Console.WriteLine("GetAsync() has Started execution successfully.");

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


        private async Task<T> ParseContent<T>(HttpContent content) where T : class {

            //T retVal;

            string result = await content.ReadAsStringAsync();
            //WeatherMap type = Type.GetType(result);
            //object instance = Activator.CreateInstance(type);

            return result == null ? null : Newtonsoft.Json.JsonConvert.DeserializeObject<T>(result);
        }

        private string BuildParameters(string args) {

            string secretKey="";

            //Create service that first requires user to sign up to site
            //then enter in their API key...            
            if (args != null)
            {
                paritalURL += string.Format("?q={0} {1}", args, secretKey);
            }
            else {
                throw new ArgumentNullException("BuildParameters() Error: Invalid argument was given.");
            }

            return paritalURL;

        }

        private async Task<T> GetOpenWeatherMapResponse<T>(string args) where T: class {

            T retVal = null;

            retVal = await GetAsync<T>(args);

            return retVal;

        }


        #endregion Private Methods

        #region Public Methods 

        public CurrentWeather GetCurrentWeather(string location) {

            CurrentWeather retVal = null;
            string uriPath;

            if (location != null) {
                uriPath = BuildParameters(location);

                Task.Run(async () =>
                {
                    retVal = await GetAsync<CurrentWeather>(uriPath);

                }).Wait();

            }

            return retVal;

        }

        #endregion Public Methods
    }
}
