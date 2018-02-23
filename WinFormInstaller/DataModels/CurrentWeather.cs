using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormInstaller.DataModels
{
    /// <summary>
    /// Represents the total JSON object returned
    /// </summary>
    public class CurrentWeather
    {
        public Coordinates coord { get; set; }
        //public string[] weather { get; set; }

        public Main main { get; set; }

        public int visibility { get; set; }

        public Wind wind { get; set; }
        public Clouds clouds { get; set; }
        public int dt { get; set; }
        public Sys sys { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }

    }

    /// <summary>
    /// The geographical coordinates of a location
    /// </summary>
    public class Coordinates {

        public double lon { get; set; }
        public double lat { get; set; }
        public string Base { get; set; }

    }

    /// <summary>
    /// Represents the actual weather conditions of a location
    /// </summary>
    //public class Weather {

    //    public int id { get; set; }
    //    public string main { get; set; }
    //    public string description { get; set; }
    //    public string icon { get; set; }

    //}
    //ERROR: Cannot use this class because data is enclosed within a JSON array, thus
    //making the object not elligible for class conversion


    ///<summary>
    /// Represents numeric data associated with weather conditions
    /// </summary>
    public class Main {

        public double temp { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }

    }

    /// <summary>
    /// Represents numeric data associated with wind conditions
    /// </summary>
    public class Wind {

        public double speed { get; set; }
        public int deg { get; set; }

    }

    /// <summary>
    /// Represents numeric data regarding cloud formations
    /// </summary>
    public class Clouds {

        public int all { get; set; }

    }

    /// <summary>
    /// Represents data associated with geography, and solar position
    /// </summary>
    public class Sys
    {

        public string type { get; set; }
        public int id { get; set; }
        public double message { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }

    }

}
