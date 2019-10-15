using Serilog;
using System;
using System.Windows.Forms;
using WinFormInstaller.Controllers;
using WinFormInstaller.DataModels;

namespace WinFormInstaller
{
    public partial class Form1 : Form
    {

        private WeatherMap weatherMap;
        private CurrentWeather formData;
        private ImageConfigurationController imgConfig;
        public Boolean developmentMode = true;

        public Form1(WeatherMap _weatherMap, ImageConfigurationController _imgConfig)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.File(path: "error-log.txt").CreateLogger();

            weatherMap = _weatherMap;
            imgConfig = _imgConfig;

            InitializeComponent();
            InitializeFormData();
        }

        private void InitializeFormData() {

            Log.Information("Form initialzed at: " + DateTime.Now);

            string defaultLocale = "London";

            // TODO: Remove all unecessary default/initial app behavior
            // Remove unecessary comments
            // Relocate distinct features to controller classes

            SetDefaultAppView();

            formData = weatherMap.GetCurrentWeather(defaultLocale);
            ConfigureListView(formData);

            Log.Information("Form finished initialization at: " + DateTime.Now);

        }

        /// <summary>
        /// Loads basic app UI
        /// </summary>
        public void SetDefaultAppView() {

            //define list attributes
            listView1.View = View.Details;
            listView1.LabelEdit = true;
            listView1.AllowColumnReorder = true;
            listView1.GridLines = true;

        }

        /// <summary>
        /// Configure List with API data
        /// </summary>
        /// <param name="weatherMap"></param>
        public void ConfigureListView(CurrentWeather weatherMap) {

            if (weatherMap != null)
            {
                label1.Text = weatherMap.primary[0].main;
                imgConfig.SetWeatherImage(this, label1.Text);

                // Create three items and three sets of subitems for each item.
                ListViewItem item1 = new ListViewItem(weatherMap.name, 0);
                item1.SubItems.Add(weatherMap.clouds.all.ToString() + " %");
                item1.SubItems.Add(weatherMap.main.temp.ToString() + " °C");
                item1.SubItems.Add(weatherMap.wind.speed.ToString() + " MPH");

                // Create columns for the items and subitems.
                // Width of -2 indicates auto-size.
                listView1.Columns.Add("Region", -2, HorizontalAlignment.Left);
                listView1.Columns.Add("Perspiration", -2, HorizontalAlignment.Left);
                listView1.Columns.Add("Temperature", -2, HorizontalAlignment.Left);
                listView1.Columns.Add("Wind", -2, HorizontalAlignment.Center);

                // Add the items to the ListView.
                listView1.Items.AddRange(new ListViewItem[] { item1 });
            }
            else {
                // if no data was found, or error occurred, populate list with dummy data
                DefaultListViewPopulation();
            }

        }

        /// <summary>
        /// Populate list with default values if connection is broken
        /// </summary>
        public void DefaultListViewPopulation() {

            ListViewItem item1 = new ListViewItem("city name 1", 0);
            item1.SubItems.Add("severity of rainfall");
            item1.SubItems.Add("temp");
            item1.SubItems.Add("wind speed");
            //ListViewItem first argument in constructor represents the name of a new column
            ListViewItem item2 = new ListViewItem("city name 2", 1);
            item2.SubItems.Add("z");
            item2.SubItems.Add("x");
            item2.SubItems.Add("y");
            ListViewItem item3 = new ListViewItem("city name 3", 0);

            item3.Checked = true;
            item3.SubItems.Add("z");
            item3.SubItems.Add("x");
            item3.SubItems.Add("y");

            // Create columns for the items and subitems.
            // Width of -2 represents auto-size.
            listView1.Columns.Add("Location", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Perspiration", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Temperature", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Wind", -2, HorizontalAlignment.Center);
            listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 });

        }

        #region Events

        /// <summary>
        /// Submit location to obtain weather data
        /// </summary>=
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitLocation_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != null)
                {
                    // update API request with location
                    formData = weatherMap.GetCurrentWeather(textBox1.Text);
                    if (weatherMap != null)
                    {
                        ConfigureListView(formData);
                    }
                }
            }
            catch (Exception ex) {
                Log.Information("The following error, " + ex + ", occurred in submitLocation_Click() at" + DateTime.Now);
                this.errorMessage.Visible = true;
            }
        }

        /// <summary>
        /// Sets application mode to either dev mode or display mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setDebugMode_Click(object sender, EventArgs e)
        {
            developmentMode = !developmentMode;
            if (developmentMode)
            {
                debugModeMenuItem.Text = "Debug Mode";
            }
            else
            {
                debugModeMenuItem.Text = "Non Debug Mode";
            }
        }
        #endregion Events
    }
}
