namespace XMLWeather
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
            this.dayComboBox = new System.Windows.Forms.ComboBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.windSpeedLabel = new System.Windows.Forms.Label();
            this.currentTempLabel = new System.Windows.Forms.Label();
            this.windDirectionLabel = new System.Windows.Forms.Label();
            this.highLowTempLabel = new System.Windows.Forms.Label();
            this.windLabel = new System.Windows.Forms.Label();
            this.conditionBox = new System.Windows.Forms.PictureBox();
            this.popBox = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.conditionBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dayComboBox
            // 
            this.dayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayComboBox.FormattingEnabled = true;
            this.dayComboBox.Items.AddRange(new object[] {
            "Today",
            "Tomorrow",
            "Tomorrow\'s Tomorrow",
            "The Day After That"});
            this.dayComboBox.Location = new System.Drawing.Point(31, 35);
            this.dayComboBox.Name = "dayComboBox";
            this.dayComboBox.Size = new System.Drawing.Size(211, 28);
            this.dayComboBox.TabIndex = 9;
            this.dayComboBox.SelectedIndexChanged += new System.EventHandler(this.dayComboBox_SelectedIndexChanged);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft MHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(722, 413);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(72, 48);
            this.locationLabel.TabIndex = 10;
            this.locationLabel.Text = "city";
            // 
            // windSpeedLabel
            // 
            this.windSpeedLabel.AutoSize = true;
            this.windSpeedLabel.Font = new System.Drawing.Font("Microsoft MHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windSpeedLabel.Location = new System.Drawing.Point(74, 336);
            this.windSpeedLabel.Name = "windSpeedLabel";
            this.windSpeedLabel.Size = new System.Drawing.Size(191, 48);
            this.windSpeedLabel.TabIndex = 11;
            this.windSpeedLabel.Text = "windSpeed";
            // 
            // currentTempLabel
            // 
            this.currentTempLabel.AutoSize = true;
            this.currentTempLabel.Font = new System.Drawing.Font("Microsoft MHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTempLabel.Location = new System.Drawing.Point(668, 84);
            this.currentTempLabel.Name = "currentTempLabel";
            this.currentTempLabel.Size = new System.Drawing.Size(217, 48);
            this.currentTempLabel.TabIndex = 12;
            this.currentTempLabel.Text = "currentTemp";
            // 
            // windDirectionLabel
            // 
            this.windDirectionLabel.AutoSize = true;
            this.windDirectionLabel.Font = new System.Drawing.Font("Microsoft MHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windDirectionLabel.Location = new System.Drawing.Point(74, 256);
            this.windDirectionLabel.Name = "windDirectionLabel";
            this.windDirectionLabel.Size = new System.Drawing.Size(233, 48);
            this.windDirectionLabel.TabIndex = 13;
            this.windDirectionLabel.Text = "windDirection";
            // 
            // highLowTempLabel
            // 
            this.highLowTempLabel.AutoSize = true;
            this.highLowTempLabel.Font = new System.Drawing.Font("Microsoft MHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highLowTempLabel.Location = new System.Drawing.Point(381, 84);
            this.highLowTempLabel.Name = "highLowTempLabel";
            this.highLowTempLabel.Size = new System.Drawing.Size(177, 48);
            this.highLowTempLabel.TabIndex = 15;
            this.highLowTempLabel.Text = "highTemp";
            // 
            // windLabel
            // 
            this.windLabel.AutoSize = true;
            this.windLabel.Font = new System.Drawing.Font("Microsoft MHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windLabel.Location = new System.Drawing.Point(74, 189);
            this.windLabel.Name = "windLabel";
            this.windLabel.Size = new System.Drawing.Size(110, 48);
            this.windLabel.TabIndex = 17;
            this.windLabel.Text = "Wind:";
            // 
            // conditionBox
            // 
            this.conditionBox.InitialImage = global::XMLWeather.Properties.Resources.sun;
            this.conditionBox.Location = new System.Drawing.Point(662, 174);
            this.conditionBox.Name = "conditionBox";
            this.conditionBox.Size = new System.Drawing.Size(200, 200);
            this.conditionBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.conditionBox.TabIndex = 16;
            this.conditionBox.TabStop = false;
            // 
            // popBox
            // 
            this.popBox.AutoSize = true;
            this.popBox.Font = new System.Drawing.Font("Microsoft MHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popBox.Location = new System.Drawing.Point(184, 445);
            this.popBox.Name = "popBox";
            this.popBox.Size = new System.Drawing.Size(81, 48);
            this.popBox.TabIndex = 18;
            this.popBox.Text = "PoP";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft MHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(459, 15);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(88, 48);
            this.dateLabel.TabIndex = 19;
            this.dateLabel.Text = "date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(927, 558);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.popBox);
            this.Controls.Add(this.windLabel);
            this.Controls.Add(this.conditionBox);
            this.Controls.Add(this.highLowTempLabel);
            this.Controls.Add(this.windDirectionLabel);
            this.Controls.Add(this.currentTempLabel);
            this.Controls.Add(this.windSpeedLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.dayComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central Weather";
            ((System.ComponentModel.ISupportInitialize)(this.conditionBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox dayComboBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label windSpeedLabel;
        private System.Windows.Forms.Label currentTempLabel;
        private System.Windows.Forms.Label windDirectionLabel;
        private System.Windows.Forms.Label highLowTempLabel;
        private System.Windows.Forms.PictureBox conditionBox;
        private System.Windows.Forms.Label windLabel;
        private System.Windows.Forms.Label popBox;
        private System.Windows.Forms.Label dateLabel;
    }
}

