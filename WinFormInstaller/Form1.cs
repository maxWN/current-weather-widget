using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormInstaller.DataModels;

namespace WinFormInstaller
{
    public partial class Form1 : Form
    {

        private WeatherMap weatherMap;

        public Form1()
        {
            InitializeComponent();
            InitializeFormData();
        }
        //add icons from this url:
        //http://www.iconarchive.com/show/oxygen-icons-by-oxygen-icons.org.18.html

        private void InitializeFormData() {

            weatherMap = new WeatherMap();
            CurrentWeather formData = null;
            //weatherMap.GetCurrentWeather("nowhere");
            //if (weatherMap != null)
            //{
            //    ConfigureListView(formData);
            //}
            ConfigureListView(formData);

        }

        public void ConfigureListView(CurrentWeather weatherMap) {

            listView1.View = View.Details;
            listView1.LabelEdit = true;
            listView1.AllowColumnReorder = true;

            // Place a check mark next to the item.
            //item1.Checked = true;
            if (weatherMap != null)
            {
                // Create three items and three sets of subitems for each item.
                ListViewItem item1 = new ListViewItem(weatherMap.name, 0);
                item1.SubItems.Add(weatherMap.clouds.all.ToString());
                item1.SubItems.Add(weatherMap.main.temp.ToString());
                item1.SubItems.Add(weatherMap.wind.speed.ToString());

                // Create columns for the items and subitems.
                // Width of -2 indicates auto-size.
                listView1.Columns.Add("Conditions", -2, HorizontalAlignment.Left);
                listView1.Columns.Add("Perspiration", -2, HorizontalAlignment.Left);
                listView1.Columns.Add("Temperature", -2, HorizontalAlignment.Left);
                listView1.Columns.Add("Wind", -2, HorizontalAlignment.Center);

                //Add the items to the ListView.
                listView1.Items.AddRange(new ListViewItem[] { item1 });
            }
            else {
                //if no data was found, or err occurred, populate list with dummy data
                DefaultPopulateListView();
            }
        }

        public void DefaultPopulateListView() {

            ListViewItem item1 = new ListViewItem("city name", 0);
            item1.SubItems.Add("severity of rainfall");
            item1.SubItems.Add("temp");
            item1.SubItems.Add("wind speed");
            //ListViewItem first argument in constructor represents the name of a new column
            ListViewItem item2 = new ListViewItem("item2", 1);
            item2.SubItems.Add("4");
            item2.SubItems.Add("5");
            item2.SubItems.Add("6");
            ListViewItem item3 = new ListViewItem("item3", 0);

            item3.Checked = true;
            item3.SubItems.Add("7");
            item3.SubItems.Add("8");
            item3.SubItems.Add("9");

            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            listView1.Columns.Add("Conditions", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Perspiration", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Temperature", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Wind", -2, HorizontalAlignment.Center);
            listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 });

        }

        private void weather_title(object sender, EventArgs e)
        {

        }

        private void weather_image(object sender, EventArgs e)
        {

        }

        private void weather_location(object sender, EventArgs e)
        {

        }

        private void submitLocation_Click(object sender, EventArgs e)
        {

        }
    }
}
