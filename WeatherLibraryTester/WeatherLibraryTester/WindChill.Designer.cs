namespace WeatherLibraryTester
{
    partial class WindChill
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lnlWindSpeed = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtWindSpeed = new System.Windows.Forms.TextBox();
            this.lblFeelsLike = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtFeelsLike = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(218, 200);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(39, 81);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(183, 16);
            this.lblTemp.TabIndex = 1;
            this.lblTemp.Text = "Enter Temperature in Celsius:";
            // 
            // lnlWindSpeed
            // 
            this.lnlWindSpeed.AutoSize = true;
            this.lnlWindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlWindSpeed.Location = new System.Drawing.Point(39, 47);
            this.lnlWindSpeed.Name = "lnlWindSpeed";
            this.lnlWindSpeed.Size = new System.Drawing.Size(254, 16);
            this.lnlWindSpeed.TabIndex = 2;
            this.lnlWindSpeed.Text = "Enter Wind Speed in Kilometers per Hour:";
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(309, 81);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 20);
            this.txtTemp.TabIndex = 3;
            // 
            // txtWindSpeed
            // 
            this.txtWindSpeed.Location = new System.Drawing.Point(309, 46);
            this.txtWindSpeed.Name = "txtWindSpeed";
            this.txtWindSpeed.Size = new System.Drawing.Size(100, 20);
            this.txtWindSpeed.TabIndex = 4;
            // 
            // lblFeelsLike
            // 
            this.lblFeelsLike.AutoSize = true;
            this.lblFeelsLike.Location = new System.Drawing.Point(153, 165);
            this.lblFeelsLike.Name = "lblFeelsLike";
            this.lblFeelsLike.Size = new System.Drawing.Size(58, 13);
            this.lblFeelsLike.TabIndex = 5;
            this.lblFeelsLike.Text = "Feels Like:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(218, 123);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtFeelsLike
            // 
            this.txtFeelsLike.Location = new System.Drawing.Point(249, 162);
            this.txtFeelsLike.Name = "txtFeelsLike";
            this.txtFeelsLike.ReadOnly = true;
            this.txtFeelsLike.Size = new System.Drawing.Size(100, 20);
            this.txtFeelsLike.TabIndex = 7;
            // 
            // WindChill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 263);
            this.Controls.Add(this.txtFeelsLike);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblFeelsLike);
            this.Controls.Add(this.txtWindSpeed);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.lnlWindSpeed);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.btnClose);
            this.Name = "WindChill";
            this.Text = "Wind Chill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lnlWindSpeed;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtWindSpeed;
        private System.Windows.Forms.Label lblFeelsLike;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtFeelsLike;
    }
}