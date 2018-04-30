namespace XMLWeather
{
    partial class ForecastScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.min1 = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.max1 = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.Label();
            this.min2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.max2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cityOutput = new System.Windows.Forms.Label();
            this.date3 = new System.Windows.Forms.Label();
            this.min3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.max3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.updateTimeLabel = new System.Windows.Forms.Label();
            this.day2Weather = new System.Windows.Forms.PictureBox();
            this.day1Weather = new System.Windows.Forms.PictureBox();
            this.day3Weather = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.day2Weather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.day1Weather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.day3Weather)).BeginInit();
            this.SuspendLayout();
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forecastLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.8F, System.Drawing.FontStyle.Bold);
            this.forecastLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.forecastLabel.Location = new System.Drawing.Point(504, 16);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(110, 34);
            this.forecastLabel.TabIndex = 62;
            this.forecastLabel.Text = "3 Day";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(344, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 34);
            this.label3.TabIndex = 61;
            this.label3.Text = "Today";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // min1
            // 
            this.min1.AutoSize = true;
            this.min1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.min1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.8F, System.Drawing.FontStyle.Bold);
            this.min1.ForeColor = System.Drawing.Color.Black;
            this.min1.Location = new System.Drawing.Point(193, 278);
            this.min1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.min1.Name = "min1";
            this.min1.Size = new System.Drawing.Size(0, 24);
            this.min1.TabIndex = 48;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.BackColor = System.Drawing.Color.Transparent;
            this.minLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.8F, System.Drawing.FontStyle.Bold);
            this.minLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.minLabel.Location = new System.Drawing.Point(10, 275);
            this.minLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(163, 24);
            this.minLabel.TabIndex = 46;
            this.minLabel.Text = "Min Temperature";
            // 
            // max1
            // 
            this.max1.AutoSize = true;
            this.max1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.max1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.8F, System.Drawing.FontStyle.Bold);
            this.max1.ForeColor = System.Drawing.Color.Black;
            this.max1.Location = new System.Drawing.Point(193, 239);
            this.max1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max1.Name = "max1";
            this.max1.Size = new System.Drawing.Size(0, 24);
            this.max1.TabIndex = 45;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.8F, System.Drawing.FontStyle.Bold);
            this.maxLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.maxLabel.Location = new System.Drawing.Point(12, 239);
            this.maxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(168, 24);
            this.maxLabel.TabIndex = 44;
            this.maxLabel.Text = "Max Temperature";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(462, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 33);
            this.label5.TabIndex = 63;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // date1
            // 
            this.date1.AutoSize = true;
            this.date1.BackColor = System.Drawing.Color.Transparent;
            this.date1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.8F, System.Drawing.FontStyle.Bold);
            this.date1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.date1.Location = new System.Drawing.Point(11, 206);
            this.date1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(52, 24);
            this.date1.TabIndex = 64;
            this.date1.Text = "Date";
            // 
            // date2
            // 
            this.date2.AutoSize = true;
            this.date2.BackColor = System.Drawing.Color.Transparent;
            this.date2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.8F, System.Drawing.FontStyle.Bold);
            this.date2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.date2.Location = new System.Drawing.Point(331, 206);
            this.date2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(52, 24);
            this.date2.TabIndex = 69;
            this.date2.Text = "Date";
            // 
            // min2
            // 
            this.min2.AutoSize = true;
            this.min2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.min2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.8F, System.Drawing.FontStyle.Bold);
            this.min2.ForeColor = System.Drawing.Color.Black;
            this.min2.Location = new System.Drawing.Point(512, 278);
            this.min2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.min2.Name = "min2";
            this.min2.Size = new System.Drawing.Size(0, 24);
            this.min2.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(330, 275);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 24);
            this.label4.TabIndex = 67;
            this.label4.Text = "Min Temperature";
            // 
            // max2
            // 
            this.max2.AutoSize = true;
            this.max2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.max2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.8F, System.Drawing.FontStyle.Bold);
            this.max2.ForeColor = System.Drawing.Color.Black;
            this.max2.Location = new System.Drawing.Point(512, 242);
            this.max2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max2.Name = "max2";
            this.max2.Size = new System.Drawing.Size(0, 24);
            this.max2.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(331, 239);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 24);
            this.label7.TabIndex = 65;
            this.label7.Text = "Max Temperature";
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.8F, System.Drawing.FontStyle.Bold);
            this.cityOutput.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cityOutput.Location = new System.Drawing.Point(7, 16);
            this.cityOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(302, 28);
            this.cityOutput.TabIndex = 70;
            this.cityOutput.Text = "City";
            // 
            // date3
            // 
            this.date3.AutoSize = true;
            this.date3.BackColor = System.Drawing.Color.Transparent;
            this.date3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.8F, System.Drawing.FontStyle.Bold);
            this.date3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.date3.Location = new System.Drawing.Point(11, 431);
            this.date3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date3.Name = "date3";
            this.date3.Size = new System.Drawing.Size(52, 24);
            this.date3.TabIndex = 79;
            this.date3.Text = "Date";
            // 
            // min3
            // 
            this.min3.AutoSize = true;
            this.min3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.min3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.8F, System.Drawing.FontStyle.Bold);
            this.min3.ForeColor = System.Drawing.Color.Black;
            this.min3.Location = new System.Drawing.Point(192, 500);
            this.min3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.min3.Name = "min3";
            this.min3.Size = new System.Drawing.Size(0, 24);
            this.min3.TabIndex = 78;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.8F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(10, 500);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 24);
            this.label12.TabIndex = 77;
            this.label12.Text = "Min Temperature";
            // 
            // max3
            // 
            this.max3.AutoSize = true;
            this.max3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.max3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.8F, System.Drawing.FontStyle.Bold);
            this.max3.ForeColor = System.Drawing.Color.Black;
            this.max3.Location = new System.Drawing.Point(192, 467);
            this.max3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max3.Name = "max3";
            this.max3.Size = new System.Drawing.Size(0, 24);
            this.max3.TabIndex = 76;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.8F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(11, 464);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(168, 24);
            this.label14.TabIndex = 75;
            this.label14.Text = "Max Temperature";
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.8F, System.Drawing.FontStyle.Bold);
            this.dateLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dateLabel.Location = new System.Drawing.Point(7, 54);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(302, 28);
            this.dateLabel.TabIndex = 80;
            this.dateLabel.Text = "Date";
            // 
            // updateTimeLabel
            // 
            this.updateTimeLabel.AutoSize = true;
            this.updateTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.updateTimeLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.updateTimeLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.updateTimeLabel.Location = new System.Drawing.Point(7, 85);
            this.updateTimeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.updateTimeLabel.Name = "updateTimeLabel";
            this.updateTimeLabel.Size = new System.Drawing.Size(46, 21);
            this.updateTimeLabel.TabIndex = 81;
            this.updateTimeLabel.Text = "Time";
            // 
            // day2Weather
            // 
            this.day2Weather.BackColor = System.Drawing.Color.Transparent;
            this.day2Weather.Location = new System.Drawing.Point(447, 85);
            this.day2Weather.Name = "day2Weather";
            this.day2Weather.Size = new System.Drawing.Size(128, 128);
            this.day2Weather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.day2Weather.TabIndex = 84;
            this.day2Weather.TabStop = false;
            // 
            // day1Weather
            // 
            this.day1Weather.BackColor = System.Drawing.Color.Transparent;
            this.day1Weather.Location = new System.Drawing.Point(128, 85);
            this.day1Weather.Name = "day1Weather";
            this.day1Weather.Size = new System.Drawing.Size(128, 128);
            this.day1Weather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.day1Weather.TabIndex = 83;
            this.day1Weather.TabStop = false;
            // 
            // day3Weather
            // 
            this.day3Weather.BackColor = System.Drawing.Color.Transparent;
            this.day3Weather.Location = new System.Drawing.Point(127, 317);
            this.day3Weather.Name = "day3Weather";
            this.day3Weather.Size = new System.Drawing.Size(128, 128);
            this.day3Weather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.day3Weather.TabIndex = 82;
            this.day3Weather.TabStop = false;
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.date1);
            this.Controls.Add(this.date3);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.day2Weather);
            this.Controls.Add(this.day1Weather);
            this.Controls.Add(this.updateTimeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.min3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.max3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.min2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.max2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.min1);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.max1);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.day3Weather);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(613, 551);
            ((System.ComponentModel.ISupportInitialize)(this.day2Weather)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.day1Weather)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.day3Weather)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label min1;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label max1;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label min2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label max2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label date3;
        private System.Windows.Forms.Label min3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label max3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label updateTimeLabel;
        private System.Windows.Forms.PictureBox day3Weather;
        private System.Windows.Forms.PictureBox day1Weather;
        private System.Windows.Forms.PictureBox day2Weather;
    }
}
