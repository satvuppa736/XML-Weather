using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//
namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            cityOutput.Text = Form1.days[0].location;

            //date1.Text = Form1.days[1].date;
            date1.Text = DateTime.Now.AddDays(1).ToString("ddd MMMM dd");
            min1.Text = Form1.days[1].tempLow + "°C";
            max1.Text = Form1.days[1].tempHigh + "°C";

            #region     DAY 1 PICTURES
            if (Convert.ToInt16(Form1.days[1].condition) == 800) //clear
            {
                day1Weather.Image = Properties.Resources.sun;
            }
            else if (200 <= Convert.ToInt16(Form1.days[1].condition) << 600) //rain
            {
                day1Weather.Image = Properties.Resources.rain;
            }
            else if (800 <= Convert.ToInt16(Form1.days[1].condition) << 806) //clouds
            {
                day1Weather.Image = Properties.Resources.clouds;
            }
            else if (700 <= Convert.ToInt16(Form1.days[1].condition) << 782) //low visibility
            {
                day1Weather.Image = Properties.Resources.fog;
            }
            else
            {
            }
            #endregion


            // date2.Text = Form1.days[2].date;
            date2.Text = DateTime.Now.AddDays(2).ToString("ddd MMMM dd");
            min2.Text = Form1.days[2].tempLow + "°C";
            max2.Text = Form1.days[2].tempHigh + "°C";

            #region     DAY 2 PICTURES
            if (Convert.ToInt16(Form1.days[2].condition) == 800) //clear
            {
                day2Weather.Image = Properties.Resources.sun;
            }
            else if (200 <= Convert.ToInt16(Form1.days[2].condition) << 600) //rain
            {
                day2Weather.Image = Properties.Resources.rain;
            }
            else if (800 <= Convert.ToInt16(Form1.days[2].condition) << 806) //clouds
            {
                day2Weather.Image = Properties.Resources.clouds;
            }
            else if (700 <= Convert.ToInt16(Form1.days[2].condition) << 782) //low visibility
            {
                day2Weather.Image = Properties.Resources.fog;
            }
            else
            {
            }
            #endregion


            //date3.Text = Form1.days[3].date;
            date3.Text = DateTime.Now.AddDays(3).ToString("ddd MMMM dd");
            min3.Text = Form1.days[3].tempLow + "°C";
            max3.Text = Form1.days[3].tempHigh + "°C";

            #region     DAY 3 PICTURES
            if (Convert.ToInt16(Form1.days[3].condition) == 800) //clear
            {
                day3Weather.Image = Properties.Resources.sun;
            }
            else if (200 <= Convert.ToInt16(Form1.days[3].condition) << 600) //rain
            {
                day3Weather.Image = Properties.Resources.rain;
            }
            else if (800 <= Convert.ToInt16(Form1.days[3].condition) << 806) //clouds
            {
                day3Weather.Image = Properties.Resources.clouds;
            }
            else if (700 <= Convert.ToInt16(Form1.days[3].condition) << 782) //low visibility
            {
                day3Weather.Image = Properties.Resources.fog;
            }
            else
            {
            }
            #endregion


            dateLabel.Text = DateTime.Now.ToString("dddd MMMM dd yyyy");
            updateTimeLabel.Text = DateTime.Now.ToString("hh:mm tt");

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

    }
}
