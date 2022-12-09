﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string APIKey = "********";
       

        private void showButton_Click(object sender, EventArgs e)
        {
            getWeather();
           
        }

        void getWeather()
        {
            // TODO error checking the city 
            string city = cityTextBox.Text;
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", city, APIKey);
                var json = web.DownloadString(url);
                //using the Newtonsoft Json convert class to process the json data
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                picIcon.ImageLocation = "https://api.openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                labelCondition.Text = Info.weather[0].main;
                detailsLabel.Text = Info.weather[0].description;
                sunsetLabelResults.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();
                sunriseLabelResults.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();

                windSpeedLabel.Text = Info.wind.speed.ToString();
                pressureLabel.Text = Info.main.pressure.ToString();
            }
        }

        // converts the sunset and sunrise times to be in appropriate format
        DateTime convertDateTime(long time)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(time).ToLocalTime();
            return day;

        }
    }
}
