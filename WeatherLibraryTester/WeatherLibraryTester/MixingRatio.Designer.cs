namespace WeatherLibraryTester
{
    partial class MixingRatio
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
            this.lblPressure = new System.Windows.Forms.Label();
            this.lblDewPoint = new System.Windows.Forms.Label();
            this.lblAMR = new System.Windows.Forms.Label();
            this.txtPressure = new System.Windows.Forms.TextBox();
            this.txtDewpoint = new System.Windows.Forms.TextBox();
            this.txtAMR = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.lblTemp = new System.Windows.Forms.Label();
            this.txtSMR = new System.Windows.Forms.TextBox();
            this.lblSMR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(161, 259);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 31);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressure.Location = new System.Drawing.Point(41, 98);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(209, 16);
            this.lblPressure.TabIndex = 1;
            this.lblPressure.Text = "Enter Station Pressure in Millibars:";
            // 
            // lblDewPoint
            // 
            this.lblDewPoint.AutoSize = true;
            this.lblDewPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDewPoint.Location = new System.Drawing.Point(41, 62);
            this.lblDewPoint.Name = "lblDewPoint";
            this.lblDewPoint.Size = new System.Drawing.Size(161, 16);
            this.lblDewPoint.TabIndex = 2;
            this.lblDewPoint.Text = "Enter Dewpoint in Celsius:";
            // 
            // lblAMR
            // 
            this.lblAMR.AutoSize = true;
            this.lblAMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAMR.Location = new System.Drawing.Point(71, 187);
            this.lblAMR.Name = "lblAMR";
            this.lblAMR.Size = new System.Drawing.Size(124, 16);
            this.lblAMR.TabIndex = 3;
            this.lblAMR.Text = "Actual Mixing Ratio:";
            // 
            // txtPressure
            // 
            this.txtPressure.Location = new System.Drawing.Point(256, 94);
            this.txtPressure.Name = "txtPressure";
            this.txtPressure.Size = new System.Drawing.Size(100, 20);
            this.txtPressure.TabIndex = 4;
            // 
            // txtDewpoint
            // 
            this.txtDewpoint.Location = new System.Drawing.Point(256, 58);
            this.txtDewpoint.Name = "txtDewpoint";
            this.txtDewpoint.Size = new System.Drawing.Size(100, 20);
            this.txtDewpoint.TabIndex = 5;
            // 
            // txtAMR
            // 
            this.txtAMR.Location = new System.Drawing.Point(216, 186);
            this.txtAMR.Name = "txtAMR";
            this.txtAMR.ReadOnly = true;
            this.txtAMR.Size = new System.Drawing.Size(100, 20);
            this.txtAMR.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(161, 146);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(256, 27);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 20);
            this.txtTemp.TabIndex = 10;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(41, 27);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(183, 16);
            this.lblTemp.TabIndex = 9;
            this.lblTemp.Text = "Enter Temperature in Celsius:";
            // 
            // txtSMR
            // 
            this.txtSMR.Location = new System.Drawing.Point(216, 219);
            this.txtSMR.Name = "txtSMR";
            this.txtSMR.ReadOnly = true;
            this.txtSMR.Size = new System.Drawing.Size(100, 20);
            this.txtSMR.TabIndex = 12;
            // 
            // lblSMR
            // 
            this.lblSMR.AutoSize = true;
            this.lblSMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSMR.Location = new System.Drawing.Point(71, 220);
            this.lblSMR.Name = "lblSMR";
            this.lblSMR.Size = new System.Drawing.Size(145, 16);
            this.lblSMR.TabIndex = 11;
            this.lblSMR.Text = "Saturated Mixing Ratio:";
            // 
            // MixingRatio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 317);
            this.Controls.Add(this.txtSMR);
            this.Controls.Add(this.lblSMR);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtAMR);
            this.Controls.Add(this.txtDewpoint);
            this.Controls.Add(this.txtPressure);
            this.Controls.Add(this.lblAMR);
            this.Controls.Add(this.lblDewPoint);
            this.Controls.Add(this.lblPressure);
            this.Controls.Add(this.btnClose);
            this.Name = "MixingRatio";
            this.Text = "Mixing Ratio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.Label lblDewPoint;
        private System.Windows.Forms.Label lblAMR;
        private System.Windows.Forms.TextBox txtPressure;
        private System.Windows.Forms.TextBox txtDewpoint;
        private System.Windows.Forms.TextBox txtAMR;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.TextBox txtSMR;
        private System.Windows.Forms.Label lblSMR;
    }
}