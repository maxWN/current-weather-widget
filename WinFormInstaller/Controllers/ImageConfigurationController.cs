using System;

namespace WinFormInstaller.Controllers
{
    public class ImageConfigurationController
    {

        Form1 frm = null;

        public ImageConfigurationController() { }

        #region public methods

        /// <summary>
        /// Sets the weather image, given the provided description
        /// </summary>
        /// <param name="weatherState"></param>
        /// <returns></returns>
        public string SetWeatherImage(Form1 _frm, string weatherState) {

            string retVal = null;

            if (weatherState != null && _frm != null) {

                frm = _frm;

                switch (weatherState)
                {
                    case "Rain":
                        frm.pictureBox1.BackgroundImage = Properties.Resources.Status_weather_showers_icon;
                        break;
                    case "Drizzle":
                        frm.pictureBox1.BackgroundImage = Properties.Resources.Status_weather_showers_icon;
                        break;
                    case "Mist":
                        frm.pictureBox1.BackgroundImage = Properties.Resources.Status_weather_many_clouds_icon;
                        break;
                    case "Sunny":
                        frm.pictureBox1.BackgroundImage = Properties.Resources.Status_weather_clear_icon;
                        break;
                    case "Clear":
                        frm.pictureBox1.BackgroundImage = Properties.Resources.Status_weather_clear_icon;
                        break;
                    case "Clouds":
                        frm.pictureBox1.BackgroundImage = Properties.Resources.Status_weather_clouds_icon;
                        break;
                    case "Flooding":
                        frm.pictureBox1.BackgroundImage = Properties.Resources.Status_weather_storm_day_icon;
                        break;
                    case "Snow":
                        frm.pictureBox1.BackgroundImage = Properties.Resources.Status_weather_snow_icon;
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }

            }

            return retVal;

        }

        #endregion public methods

    }
}
