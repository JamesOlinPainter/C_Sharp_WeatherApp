namespace WeatherLibraryTester
{
    partial class Humidity
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
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtDewPoint = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.txtHumidity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(173, 198);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(58, 43);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(183, 16);
            this.lblTemp.TabIndex = 1;
            this.lblTemp.Text = "Enter Temperature in Celsius:";
            // 
            // lblDewPoint
            // 
            this.lblDewPoint.AutoSize = true;
            this.lblDewPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDewPoint.Location = new System.Drawing.Point(58, 84);
            this.lblDewPoint.Name = "lblDewPoint";
            this.lblDewPoint.Size = new System.Drawing.Size(165, 16);
            this.lblDewPoint.TabIndex = 2;
            this.lblDewPoint.Text = "Enter Dew Point in Celsius:";
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(247, 43);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 20);
            this.txtTemp.TabIndex = 3;
            // 
            // txtDewPoint
            // 
            this.txtDewPoint.Location = new System.Drawing.Point(247, 80);
            this.txtDewPoint.Name = "txtDewPoint";
            this.txtDewPoint.Size = new System.Drawing.Size(100, 20);
            this.txtDewPoint.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(173, 120);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidity.Location = new System.Drawing.Point(86, 161);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(116, 16);
            this.lblHumidity.TabIndex = 6;
            this.lblHumidity.Text = "Relative Humidity:";
            // 
            // txtHumidity
            // 
            this.txtHumidity.Location = new System.Drawing.Point(247, 160);
            this.txtHumidity.Name = "txtHumidity";
            this.txtHumidity.ReadOnly = true;
            this.txtHumidity.Size = new System.Drawing.Size(100, 20);
            this.txtHumidity.TabIndex = 7;
            // 
            // Humidity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 395);
            this.Controls.Add(this.txtHumidity);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtDewPoint);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.lblDewPoint);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.btnClose);
            this.Name = "Humidity";
            this.Text = "Humidity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblDewPoint;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtDewPoint;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.TextBox txtHumidity;
    }
}