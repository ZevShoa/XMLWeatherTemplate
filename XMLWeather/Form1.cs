using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    
    public partial class Form1 : Form
    {
        public static string whatDay;
        string currrentCity, currentDirection, currentTemp, currentHighTemp, currentLowTemp, currentWindSpeed;
        //string tomorowCity, tomorowDirection, tomorowTemp, tomorowHighTemp, tomorowLowTemp, tomorowWindSpeed;
        //string tomorowTomorowCity, tomorowTomorowDirection, tomorowTomorowTemp, tomorowTomorowHighTemp, tomorowTomorowLowTemp, tomorowTomorowWindSpeed;
        int currentConditions, tomorowConditions, tomorowTomorowConditions;
        Day ds;
       
        public Form1()
        {
           
            InitializeComponent();

            // get information about current and forecast weather from the internet
            GetData();
           


        }

        private static void GetData()
        {
            // taking the weather 
            WebClient client = new WebClient();

            string currentFile = "http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0";
            string forecastFile = "http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0";

            client.DownloadFile(currentFile, "WeatherData.xml");
            client.DownloadFile(forecastFile, "WeatherData7Day.xml");
        }
       

      //making sure that the right picture is sent to the picture box
        public void conditionPictureChooser()
        {
            if (ds.conditions  >= 200 && ds.conditions <= 299)
            {
                conditionBox.Image = Properties.Resources.storm;
            }
            else if (ds.conditions >= 300 && ds.conditions <= 532)
            {
                conditionBox.Image = Properties.Resources.storm;
            }
            else if (ds.conditions >= 600 && ds.conditions  <= 632)
            {
                conditionBox.Image = Properties.Resources.snow;
            }
            else if (ds.conditions == 781)
            {
                conditionBox.Image = Properties.Resources.Tornado;
            }
            else if (ds.conditions == 800)
            {
                conditionBox.Image = Properties.Resources.sun;
            }
            else if (ds.conditions >= 801 && ds.conditions <= 804)
            {
                conditionBox.Image = Properties.Resources.cloud;
            }
            else if (ds.conditions >= 951 && ds.conditions <= 962)
            {
                conditionBox.Image = Properties.Resources.cloud;
            }
            else
            {
                conditionBox.Image = null;
            }






        }

        private void MakePictureParent()
        {
            
        }
        //choosing the day to pull the weather from 
        private void dayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds = new Day(currrentCity, currentDirection, currentTemp, currentHighTemp, currentLowTemp, currentWindSpeed, currentConditions);
            whatDay = "day1";
            ds.weatherChooser();
            locationLabel.Text = ds.city;
            if (dayComboBox.Text == "Today")
            {
                ds = new Day(currrentCity, currentDirection, currentTemp, currentHighTemp, currentLowTemp, currentWindSpeed, currentConditions);
                whatDay = "day1";
                ds.weatherChooser();
                highLowTempLabel.Text =ds.highTemp+"/"+ds.lowTemp;
                currentTempLabel.Text = ds.currentTemp+ "°C";
                windDirectionLabel.Text = ds.windDirection;
                windSpeedLabel.Text = ds.windSpeed;
                locationLabel.Text = ds.city;
                conditionPictureChooser();
                popBox.Text = null;
                dateLabel.Text = DateTime.Now.ToString("dddd, MMMM dd, yyy");
               
            }
            else if(dayComboBox.Text == "Tomorrow")
            {
                ds = new Day(currrentCity, currentDirection, currentTemp, currentHighTemp, currentLowTemp, currentWindSpeed, currentConditions);
                whatDay = "day2";
                ds.weatherChooser();
                highLowTempLabel.Text = ds.highTemp + "/" + ds.lowTemp;
                currentTempLabel.Text = ds.currentTemp + "°C";
                windDirectionLabel.Text = ds.windDirection;
                popBox.Text = ds.windSpeed + "%";
                //locationLabel.Text = ds.city;
                conditionPictureChooser();
                dateLabel.Text = DateTime.Now.AddDays(1).ToString("dddd, MMMM dd, yyy");

            }
            else if (dayComboBox.Text == "Tomorrow's Tomorrow")
            {
                ds = new Day(currrentCity, currentDirection, currentTemp, currentHighTemp, currentLowTemp, currentWindSpeed, currentConditions);
                whatDay = "day3";
                ds.weatherChooser();
                highLowTempLabel.Text = ds.highTemp + "/" + ds.lowTemp;
                currentTempLabel.Text = ds.currentTemp + "°C";
                windDirectionLabel.Text = ds.windDirection;
                popBox.Text = ds.windSpeed + "%";
               // locationLabel.Text = ds.city;
                conditionPictureChooser();
                dateLabel.Text = DateTime.Now.AddDays(2).ToString("dddd, MMMM dd, yyy");
            }
            else if (dayComboBox.Text == "The Day After That")
            {
                ds = new Day(currrentCity, currentDirection, currentTemp, currentHighTemp, currentLowTemp, currentWindSpeed, currentConditions);
                whatDay = "day4";
                ds.weatherChooser();
                highLowTempLabel.Text = ds.highTemp + "/" + ds.lowTemp;
                currentTempLabel.Text = ds.currentTemp + "°C";
                windDirectionLabel.Text = ds.windDirection;
                popBox.Text = ds.windSpeed + "%";
               // locationLabel.Text = ds.city;
                conditionPictureChooser();
                dateLabel.Text = DateTime.Now.AddDays(3).ToString("dddd, MMMM dd, yyy");
            }
        }

    }
}
