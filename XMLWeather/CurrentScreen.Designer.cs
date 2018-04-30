namespace XMLWeather
{
    partial class CurrentScreen
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
            this.cityOutput = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.windOutput = new System.Windows.Forms.Label();
            this.windLabel = new System.Windows.Forms.Label();
            this.updateTimeLabel = new System.Windows.Forms.Label();
            this.humidityOut = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.weatherNameOut = new System.Windows.Forms.Label();
            this.pressureOutput = new System.Windows.Forms.Label();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.weatherOutput = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.weatherOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.8F, System.Drawing.FontStyle.Bold);
            this.cityOutput.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cityOutput.Location = new System.Drawing.Point(7, 16);
            this.cityOutput.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(302, 28);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.maxOutput.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.8F, System.Drawing.FontStyle.Bold);
            this.maxOutput.Location = new System.Drawing.Point(210, 397);
            this.maxOutput.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(63, 24);
            this.maxOutput.TabIndex = 32;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.8F, System.Drawing.FontStyle.Bold);
            this.maxLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.maxLabel.Location = new System.Drawing.Point(20, 397);
            this.maxLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(168, 24);
            this.maxLabel.TabIndex = 31;
            this.maxLabel.Text = "Max Temperature";
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.minOutput.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.8F, System.Drawing.FontStyle.Bold);
            this.minOutput.Location = new System.Drawing.Point(210, 443);
            this.minOutput.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(63, 24);
            this.minOutput.TabIndex = 30;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.BackColor = System.Drawing.Color.Transparent;
            this.minLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.8F, System.Drawing.FontStyle.Bold);
            this.minLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.minLabel.Location = new System.Drawing.Point(20, 443);
            this.minLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(163, 24);
            this.minLabel.TabIndex = 29;
            this.minLabel.Text = "Min Temperature";
            // 
            // currentOutput
            // 
            this.currentOutput.AutoSize = true;
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.Font = new System.Drawing.Font("Bahnschrift SemiBold", 28F, System.Drawing.FontStyle.Bold);
            this.currentOutput.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.currentOutput.Location = new System.Drawing.Point(318, 125);
            this.currentOutput.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(113, 57);
            this.currentOutput.TabIndex = 28;
            this.currentOutput.Text = "10°C";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(344, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 34);
            this.label3.TabIndex = 40;
            this.label3.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forecastLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.8F, System.Drawing.FontStyle.Bold);
            this.forecastLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.forecastLabel.Location = new System.Drawing.Point(504, 16);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(110, 34);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "3 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(319, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 33);
            this.label5.TabIndex = 42;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // windOutput
            // 
            this.windOutput.AutoSize = true;
            this.windOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.windOutput.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.8F, System.Drawing.FontStyle.Bold);
            this.windOutput.Location = new System.Drawing.Point(442, 397);
            this.windOutput.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.windOutput.Name = "windOutput";
            this.windOutput.Size = new System.Drawing.Size(88, 24);
            this.windOutput.TabIndex = 44;
            this.windOutput.Text = "Wind Out";
            // 
            // windLabel
            // 
            this.windLabel.AutoSize = true;
            this.windLabel.BackColor = System.Drawing.Color.Transparent;
            this.windLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.8F, System.Drawing.FontStyle.Bold);
            this.windLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.windLabel.Location = new System.Drawing.Point(311, 397);
            this.windLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.windLabel.Name = "windLabel";
            this.windLabel.Size = new System.Drawing.Size(113, 24);
            this.windLabel.TabIndex = 43;
            this.windLabel.Text = "Wind Speed";
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
            this.updateTimeLabel.TabIndex = 46;
            this.updateTimeLabel.Text = "Time";
            // 
            // humidityOut
            // 
            this.humidityOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.humidityOut.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.8F, System.Drawing.FontStyle.Bold);
            this.humidityOut.Location = new System.Drawing.Point(210, 485);
            this.humidityOut.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.humidityOut.Name = "humidityOut";
            this.humidityOut.Size = new System.Drawing.Size(63, 24);
            this.humidityOut.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(20, 485);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 47;
            this.label2.Text = "Humidity";
            // 
            // weatherNameOut
            // 
            this.weatherNameOut.AutoSize = true;
            this.weatherNameOut.BackColor = System.Drawing.Color.Transparent;
            this.weatherNameOut.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Bold);
            this.weatherNameOut.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.weatherNameOut.Location = new System.Drawing.Point(324, 182);
            this.weatherNameOut.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.weatherNameOut.Name = "weatherNameOut";
            this.weatherNameOut.Size = new System.Drawing.Size(89, 30);
            this.weatherNameOut.TabIndex = 49;
            this.weatherNameOut.Text = "Clouds";
            // 
            // pressureOutput
            // 
            this.pressureOutput.AutoSize = true;
            this.pressureOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pressureOutput.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.8F, System.Drawing.FontStyle.Bold);
            this.pressureOutput.ForeColor = System.Drawing.Color.Black;
            this.pressureOutput.Location = new System.Drawing.Point(442, 443);
            this.pressureOutput.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pressureOutput.Name = "pressureOutput";
            this.pressureOutput.Size = new System.Drawing.Size(124, 24);
            this.pressureOutput.TabIndex = 52;
            this.pressureOutput.Text = "pressure out";
            // 
            // pressureLabel
            // 
            this.pressureLabel.AutoSize = true;
            this.pressureLabel.BackColor = System.Drawing.Color.Transparent;
            this.pressureLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.8F, System.Drawing.FontStyle.Bold);
            this.pressureLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pressureLabel.Location = new System.Drawing.Point(311, 443);
            this.pressureLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(93, 24);
            this.pressureLabel.TabIndex = 51;
            this.pressureLabel.Text = "Pressure";
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
            this.dateLabel.TabIndex = 53;
            this.dateLabel.Text = "Date";
            // 
            // weatherOutput
            // 
            this.weatherOutput.BackColor = System.Drawing.Color.Transparent;
            this.weatherOutput.Location = new System.Drawing.Point(24, 125);
            this.weatherOutput.Name = "weatherOutput";
            this.weatherOutput.Size = new System.Drawing.Size(256, 256);
            this.weatherOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weatherOutput.TabIndex = 45;
            this.weatherOutput.TabStop = false;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.humidityOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.pressureOutput);
            this.Controls.Add(this.pressureLabel);
            this.Controls.Add(this.weatherNameOut);
            this.Controls.Add(this.updateTimeLabel);
            this.Controls.Add(this.windOutput);
            this.Controls.Add(this.windLabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.weatherOutput);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(613, 551);
            ((System.ComponentModel.ISupportInitialize)(this.weatherOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label windOutput;
        private System.Windows.Forms.Label windLabel;
        private System.Windows.Forms.PictureBox weatherOutput;
        private System.Windows.Forms.Label updateTimeLabel;
        private System.Windows.Forms.Label humidityOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label weatherNameOut;
        private System.Windows.Forms.Label pressureOutput;
        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.Label dateLabel;
    }
}
