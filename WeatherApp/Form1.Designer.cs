namespace WeatherApp
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.showButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCondition = new System.Windows.Forms.Label();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sunriseLabelResults = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sunsetLabelResults = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.windSpeedLabel = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.currentTempLabel = new System.Windows.Forms.Label();
            this.feelsLikeLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TemperatureGroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.TemperatureGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.Color.Transparent;
            this.showButton.ForeColor = System.Drawing.Color.White;
            this.showButton.Location = new System.Drawing.Point(254, 43);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "Search";
            this.showButton.UseVisualStyleBackColor = false;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "City";
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.BackColor = System.Drawing.Color.Transparent;
            this.labelCondition.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCondition.ForeColor = System.Drawing.Color.White;
            this.labelCondition.Location = new System.Drawing.Point(89, 85);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(39, 23);
            this.labelCondition.TabIndex = 1;
            this.labelCondition.Text = "N/A";
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.BackColor = System.Drawing.Color.Transparent;
            this.detailsLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsLabel.ForeColor = System.Drawing.Color.White;
            this.detailsLabel.Location = new System.Drawing.Point(89, 108);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(39, 23);
            this.detailsLabel.TabIndex = 1;
            this.detailsLabel.Text = "N/A";
            this.detailsLabel.Click += new System.EventHandler(this.detailsLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sunrise:";
            // 
            // sunriseLabelResults
            // 
            this.sunriseLabelResults.AutoSize = true;
            this.sunriseLabelResults.BackColor = System.Drawing.Color.Transparent;
            this.sunriseLabelResults.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunriseLabelResults.ForeColor = System.Drawing.Color.White;
            this.sunriseLabelResults.Location = new System.Drawing.Point(131, 108);
            this.sunriseLabelResults.Name = "sunriseLabelResults";
            this.sunriseLabelResults.Size = new System.Drawing.Size(39, 23);
            this.sunriseLabelResults.TabIndex = 1;
            this.sunriseLabelResults.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(63, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sunset:";
            // 
            // sunsetLabelResults
            // 
            this.sunsetLabelResults.AutoSize = true;
            this.sunsetLabelResults.BackColor = System.Drawing.Color.Transparent;
            this.sunsetLabelResults.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunsetLabelResults.ForeColor = System.Drawing.Color.White;
            this.sunsetLabelResults.Location = new System.Drawing.Point(131, 131);
            this.sunsetLabelResults.Name = "sunsetLabelResults";
            this.sunsetLabelResults.Size = new System.Drawing.Size(39, 23);
            this.sunsetLabelResults.TabIndex = 1;
            this.sunsetLabelResults.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Wind Speed:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(47, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Pressure:";
            // 
            // pressureLabel
            // 
            this.pressureLabel.AutoSize = true;
            this.pressureLabel.BackColor = System.Drawing.Color.Transparent;
            this.pressureLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressureLabel.ForeColor = System.Drawing.Color.White;
            this.pressureLabel.Location = new System.Drawing.Point(131, 85);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(39, 23);
            this.pressureLabel.TabIndex = 1;
            this.pressureLabel.Text = "N/A";
            // 
            // windSpeedLabel
            // 
            this.windSpeedLabel.AutoSize = true;
            this.windSpeedLabel.BackColor = System.Drawing.Color.Transparent;
            this.windSpeedLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windSpeedLabel.ForeColor = System.Drawing.Color.White;
            this.windSpeedLabel.Location = new System.Drawing.Point(131, 62);
            this.windSpeedLabel.Name = "windSpeedLabel";
            this.windSpeedLabel.Size = new System.Drawing.Size(39, 23);
            this.windSpeedLabel.TabIndex = 1;
            this.windSpeedLabel.Text = "N/A";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(70, 16);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(58, 65);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 3;
            this.picIcon.TabStop = false;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(139, 44);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Current Temp:";
            // 
            // currentTempLabel
            // 
            this.currentTempLabel.AutoSize = true;
            this.currentTempLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentTempLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTempLabel.ForeColor = System.Drawing.Color.White;
            this.currentTempLabel.Location = new System.Drawing.Point(131, 16);
            this.currentTempLabel.Name = "currentTempLabel";
            this.currentTempLabel.Size = new System.Drawing.Size(39, 23);
            this.currentTempLabel.TabIndex = 6;
            this.currentTempLabel.Text = "N/A";
            // 
            // feelsLikeLabel
            // 
            this.feelsLikeLabel.AutoSize = true;
            this.feelsLikeLabel.BackColor = System.Drawing.Color.Transparent;
            this.feelsLikeLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feelsLikeLabel.ForeColor = System.Drawing.Color.White;
            this.feelsLikeLabel.Location = new System.Drawing.Point(131, 39);
            this.feelsLikeLabel.Name = "feelsLikeLabel";
            this.feelsLikeLabel.Size = new System.Drawing.Size(39, 23);
            this.feelsLikeLabel.TabIndex = 8;
            this.feelsLikeLabel.Text = "N/A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(38, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 23);
            this.label9.TabIndex = 7;
            this.label9.Text = "Feels Like:";
            // 
            // TemperatureGroupBox
            // 
            this.TemperatureGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.TemperatureGroupBox.Controls.Add(this.label6);
            this.TemperatureGroupBox.Controls.Add(this.label9);
            this.TemperatureGroupBox.Controls.Add(this.feelsLikeLabel);
            this.TemperatureGroupBox.Controls.Add(this.sunriseLabelResults);
            this.TemperatureGroupBox.Controls.Add(this.windSpeedLabel);
            this.TemperatureGroupBox.Controls.Add(this.sunsetLabelResults);
            this.TemperatureGroupBox.Controls.Add(this.currentTempLabel);
            this.TemperatureGroupBox.Controls.Add(this.label3);
            this.TemperatureGroupBox.Controls.Add(this.label4);
            this.TemperatureGroupBox.Controls.Add(this.label2);
            this.TemperatureGroupBox.Controls.Add(this.pressureLabel);
            this.TemperatureGroupBox.Controls.Add(this.label5);
            this.TemperatureGroupBox.Location = new System.Drawing.Point(12, 70);
            this.TemperatureGroupBox.Name = "TemperatureGroupBox";
            this.TemperatureGroupBox.Size = new System.Drawing.Size(227, 170);
            this.TemperatureGroupBox.TabIndex = 9;
            this.TemperatureGroupBox.TabStop = false;
            this.TemperatureGroupBox.Text = "Temperature";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-2, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Condition:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(21, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Details:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.picIcon);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.labelCondition);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.detailsLabel);
            this.groupBox1.Location = new System.Drawing.Point(245, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 170);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Condition";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(476, 301);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TemperatureGroupBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showButton);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.TemperatureGroupBox.ResumeLayout(false);
            this.TemperatureGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sunriseLabelResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sunsetLabelResults;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.Label windSpeedLabel;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label currentTempLabel;
        private System.Windows.Forms.Label feelsLikeLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox TemperatureGroupBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

