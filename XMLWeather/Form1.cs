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

            // take info from the current weather file and display it to the screen
            ExtractCurrent();

            // take info from the forecast weather file and display it to the screen
            ExtractForecast();
        }

        private static void GetData()
        {
            WebClient client = new WebClient();

            string currentFile = "http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0";
            string forecastFile = "http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0";

            client.DownloadFile(currentFile, "WeatherData.xml");
            client.DownloadFile(forecastFile, "WeatherData7Day.xml");
        }
        private void ExtractCurrent()
        {
            //XmlDocument doc = new XmlDocument();
            //doc.Load("WeatherData.xml");

            ////create a node variable to represent the parent element
            //XmlNode parent;
            //parent = doc.DocumentElement;

            ////check each child of the parent element
            //foreach (XmlNode child in parent.ChildNodes)
            //{
            //    // TODO if the "city" element is found display the value of it's "name" attribute
            //    if (child.Name == "city")
            //    {
            //       currrentCity = child.Attributes["name"].Value;
            //    }
            //    if (child.Name == "temperature")
            //    {
            //        currentHighTemp = child.Attributes["max"].Value;
            //        currentLowTemp = child.Attributes["min"].Value;
            //        currentTemp = child.Attributes["value"].Value;
            //    }
            //    if (child.Name == "wind")
            //    {
            //        foreach (XmlNode grandChild in child.ChildNodes)
            //        {
            //            if (grandChild.Name == "speed")
            //            {
            //                currentWindSpeed = grandChild.Attributes["name"].Value;
            //            }
            //            if (grandChild.Name == "direction")
            //            {
            //                currentDirection = grandChild.Attributes["name"].Value;
            //            }
            //        }
            //    }
            //    if(child.Name == "weather")
            //    {
            //        currentConditions = Convert.ToInt32(child.Attributes["number"].Value);
            //    }
            //}
        }

        private void ExtractForecast()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData7Day.xml");

            //create a node variable to represent the parent element
            XmlNode parent;
            parent = doc.DocumentElement;
            int day = 1;
            //check each child of the parent element
            foreach (XmlNode child in parent.ChildNodes)
            {
                if (child.Name == "forecast")
                {
                    foreach (XmlNode grandChild in child.ChildNodes)
                    {
                        foreach (XmlNode greatGrandChild in grandChild.ChildNodes)
                        {
                            if(greatGrandChild.Name == "symbol")
                            {
                                //switch (day)
                                //{
                                //    case 1:
                                //        break;
                                //    case 2:
                                //        tomorowConditions = Convert.ToInt32(grandChild.Attributes["number"].Value);
                                //        break;
                                //    case 3:
                                //        tomorowTomorowConditions = Convert.ToInt32(grandChild.Attributes["number"].Value);
                                //        break;
                                //    case 4:
                                //        break;
                                //    default:
                                //        break;
                                //}
                            }
                            if (greatGrandChild.Name == "temperature")
                            {
                                switch(day)
                                {
                                    case 1:
                                        //maxForeOut.Text = greatGrandChild.Attributes["max"].Value;
                                        //minForeOut.Text = greatGrandChild.Attributes["min"].Value;
                                        break;
                                    case 2:
                                        //tomorowTemp = greatGrandChild.Attributes["day"].Value;
                                        //tomorowHighTemp = greatGrandChild.Attributes["max"].Value;
                                        //tomorowLowTemp = greatGrandChild.Attributes["min"].Value;
                                        break;
                                    default:
                                        break;
                                } 
                            }
                            if(greatGrandChild.Name == "clouds")
                            {
                                switch (day)
                                {
                                    case 1:
                                        //cloudLabel1.Text = greatGrandChild.Attributes["value"].Value;
                                        day++;
                                        break;
                                    case 2:
                                        //cloudLabel2.Text = greatGrandChild.Attributes["value"].Value;
                                        day++;
                                        break;
                                    default:
                                        break;
                                }
                            }
                           
                        }
                    }
                }
            }
        }
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

        private void dayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
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
            }
            else if(dayComboBox.Text == "Tomorrow")
            {
                ds = new Day(currrentCity, currentDirection, currentTemp, currentHighTemp, currentLowTemp, currentWindSpeed, currentConditions);
                whatDay = "day2";
                ds.weatherChooser();
                highLowTempLabel.Text = ds.highTemp + "/" + ds.lowTemp;
                currentTempLabel.Text = ds.currentTemp + "°C";
                windDirectionLabel.Text = ds.windDirection;
                windSpeedLabel.Text = ds.windSpeed;
                locationLabel.Text = ds.city;
                conditionPictureChooser();

            }
        }

    }
}
