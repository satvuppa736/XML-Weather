using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location;
            currentOutput.Text = Form1.days[0].currentTemp + "°C";
            minOutput.Text = Form1.days[0].tempLow + "°C";
            maxOutput.Text = Form1.days[0].tempHigh + "°C";
            windOutput.Text = Form1.days[0].windSpeed + " Mps";
            pressureOutput.Text = Form1.days[0].pressure + " hPa";
            humidityOut.Text = Form1.days[0].humidity + "%";

            weatherNameOut.Text = Form1.days[0].weatherName;

            updateTimeLabel.Text = DateTime.Now.ToString("hh:mm tt");

            dateLabel.Text = DateTime.Now.ToString("dddd MMMM dd yyyy");

            if (Convert.ToInt16(Form1.days[0].condition) == 800) //clear
            {
                weatherOutput.Image = Properties.Resources.sun;
            }
            else if (200 <= Convert.ToInt16(Form1.days[0].condition) << 600) //clouds
            {
                weatherOutput.Image = Properties.Resources.clouds;
            }
            else if (800 <= Convert.ToInt16(Form1.days[0].condition) << 806) //rain
            {
                weatherOutput.Image = Properties.Resources.rain;
            }
            else if (700 <= Convert.ToInt16(Form1.days[0].condition) << 782) //low visibility
            {
                weatherOutput.Image = Properties.Resources.fog;
            }
            else
            {
            }

        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
    }
}
