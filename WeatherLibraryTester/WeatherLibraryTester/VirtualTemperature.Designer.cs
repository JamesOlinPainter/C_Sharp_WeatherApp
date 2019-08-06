namespace WeatherLibraryTester
{
    partial class VirtualTemperature
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
            this.lblDewPoint = new System.Windows.Forms.Label();
            this.lblPressure = new System.Windows.Forms.Label();
            this.lblVT = new System.Windows.Forms.Label();
            this.txtVT = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtDewPoint = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtPressure = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(197, 216);
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
            this.lblTemp.Location = new System.Drawing.Point(26, 23);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(183, 16);
            this.lblTemp.TabIndex = 1;
            this.lblTemp.Text = "Enter Temperature in Celsius:";
            // 
            // lblDewPoint
            // 
            this.lblDewPoint.AutoSize = true;
            this.lblDewPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDewPoint.Location = new System.Drawing.Point(26, 60);
            this.lblDewPoint.Name = "lblDewPoint";
            this.lblDewPoint.Size = new System.Drawing.Size(162, 16);
            this.lblDewPoint.TabIndex = 2;
            this.lblDewPoint.Text = "Enter Dew Point in Celsius";
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressure.Location = new System.Drawing.Point(26, 98);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(209, 16);
            this.lblPressure.TabIndex = 3;
            this.lblPressure.Text = "Enter Station Pressure in Millibars:";
            // 
            // lblVT
            // 
            this.lblVT.AutoSize = true;
            this.lblVT.Location = new System.Drawing.Point(80, 182);
            this.lblVT.Name = "lblVT";
            this.lblVT.Size = new System.Drawing.Size(102, 13);
            this.lblVT.TabIndex = 4;
            this.lblVT.Text = "Virtual Temperature:";
            // 
            // txtVT
            // 
            this.txtVT.Location = new System.Drawing.Point(274, 179);
            this.txtVT.Name = "txtVT";
            this.txtVT.ReadOnly = true;
            this.txtVT.Size = new System.Drawing.Size(100, 20);
            this.txtVT.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(197, 142);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtDewPoint
            // 
            this.txtDewPoint.Location = new System.Drawing.Point(274, 59);
            this.txtDewPoint.Name = "txtDewPoint";
            this.txtDewPoint.Size = new System.Drawing.Size(100, 20);
            this.txtDewPoint.TabIndex = 7;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(274, 23);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 20);
            this.txtTemp.TabIndex = 8;
            // 
            // txtPressure
            // 
            this.txtPressure.Location = new System.Drawing.Point(274, 98);
            this.txtPressure.Name = "txtPressure";
            this.txtPressure.Size = new System.Drawing.Size(100, 20);
            this.txtPressure.TabIndex = 9;
            // 
            // VirtualTemperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 290);
            this.Controls.Add(this.txtPressure);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.txtDewPoint);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtVT);
            this.Controls.Add(this.lblVT);
            this.Controls.Add(this.lblPressure);
            this.Controls.Add(this.lblDewPoint);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.btnClose);
            this.Name = "VirtualTemperature";
            this.Text = "Virtual Temperature";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblDewPoint;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.Label lblVT;
        private System.Windows.Forms.TextBox txtVT;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtDewPoint;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtPressure;
    }
}