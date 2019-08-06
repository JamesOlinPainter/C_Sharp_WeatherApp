namespace WeatherLibraryTester
{
    partial class DewPoint
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
            this.lblRH = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtRH = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtDewPoint = new System.Windows.Forms.TextBox();
            this.lblDewPoint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(159, 249);
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
            this.lblTemp.Location = new System.Drawing.Point(36, 41);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(183, 16);
            this.lblTemp.TabIndex = 1;
            this.lblTemp.Text = "Enter Temperature in Celsius:";
            // 
            // lblRH
            // 
            this.lblRH.AutoSize = true;
            this.lblRH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRH.Location = new System.Drawing.Point(36, 85);
            this.lblRH.Name = "lblRH";
            this.lblRH.Size = new System.Drawing.Size(178, 16);
            this.lblRH.TabIndex = 2;
            this.lblRH.Text = "Enter Relative Humidity in %:";
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(234, 37);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 20);
            this.txtTemp.TabIndex = 4;
            // 
            // txtRH
            // 
            this.txtRH.Location = new System.Drawing.Point(234, 85);
            this.txtRH.Name = "txtRH";
            this.txtRH.Size = new System.Drawing.Size(100, 20);
            this.txtRH.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(159, 148);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtDewPoint
            // 
            this.txtDewPoint.Location = new System.Drawing.Point(234, 202);
            this.txtDewPoint.Name = "txtDewPoint";
            this.txtDewPoint.ReadOnly = true;
            this.txtDewPoint.Size = new System.Drawing.Size(100, 20);
            this.txtDewPoint.TabIndex = 7;
            // 
            // lblDewPoint
            // 
            this.lblDewPoint.AutoSize = true;
            this.lblDewPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDewPoint.Location = new System.Drawing.Point(88, 206);
            this.lblDewPoint.Name = "lblDewPoint";
            this.lblDewPoint.Size = new System.Drawing.Size(71, 16);
            this.lblDewPoint.TabIndex = 8;
            this.lblDewPoint.Text = "Dew Point:";
            // 
            // DewPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 332);
            this.Controls.Add(this.lblDewPoint);
            this.Controls.Add(this.txtDewPoint);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtRH);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.lblRH);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.btnClose);
            this.Name = "DewPoint";
            this.Text = "Dew Point";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblRH;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtRH;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtDewPoint;
        private System.Windows.Forms.Label lblDewPoint;
    }
}