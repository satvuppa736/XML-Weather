﻿using System;
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
        // TODO: create list to hold day objects
        public static List<Day> days = new List<Day>();
        Day d = new Day();

        public Form1()
        {
            InitializeComponent();
            GetData();
            ExtractCurrent();
            ExtractForecast();

            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        private static void GetData()
        {
            WebClient client = new WebClient();

            // one day forecast
            client.DownloadFile("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0", "WeatherData.xml");
            // mulit day forecast
            client.DownloadFile("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0", "WeatherData7Day.xml");
        }

        private void ExtractCurrent()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData.xml");

            XmlNode city = doc.SelectSingleNode("current/city");
            XmlNode temp = doc.SelectSingleNode("current/temperature");
            XmlNode windSpeed = doc.SelectSingleNode("current/wind/speed");
            XmlNode windDirec = doc.SelectSingleNode("current/wind/directon");
            XmlNode precipitation = doc.SelectSingleNode("current/precipitation");
            XmlNode conditions = doc.SelectSingleNode("current/weather");
            XmlNode weather = doc.SelectSingleNode("current/weather");
            XmlNode pressure = doc.SelectSingleNode("current/pressure");
            XmlNode humidity = doc.SelectSingleNode("current/humidity");


            XmlNode time = doc.SelectSingleNode("current/lastupdate");

            Day d = new Day();

            d.location = city.Attributes["name"].Value;
            d.currentTemp = temp.Attributes["value"].Value;
            d.tempHigh = temp.Attributes["max"].Value;
            d.tempLow = temp.Attributes["min"].Value;
            d.windSpeed = windSpeed.Attributes["value"].Value;
            d.condition = conditions.Attributes["number"].Value;
            d.pressure = pressure.Attributes["value"].Value;
            d.weatherName = weather.Attributes["value"].Value;
            d.humidity = humidity.Attributes["value"].Value;

            d.time = time.Attributes["value"].Value;

            days.Add(d);
            
        }
              
        private void ExtractForecast()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData7Day.xml");
            XmlNodeList dateList = doc.GetElementsByTagName("time");
            XmlNodeList tempList = doc.GetElementsByTagName("temperature");
            XmlNodeList cloudsList = doc.GetElementsByTagName("clouds");
            XmlNodeList windSpeed = doc.GetElementsByTagName("windSpeed");
            XmlNodeList conditionList = doc.GetElementsByTagName("symbol");


            for (int i = 1; i < tempList.Count; i++)
            {
                d = new Day();

                d.date = dateList[i].Attributes["day"].Value;
                d.tempHigh = tempList[i].Attributes["max"].Value;
                d.tempLow = tempList[i].Attributes["min"].Value;
                d.windSpeed = windSpeed[i].Attributes["mps"].Value;
                d.condition = conditionList[i].Attributes["number"].Value;
                days.Add(d);

            }
        }
    }
}
