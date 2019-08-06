namespace WeatherLibraryTester
{
    partial class HeatIndex
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
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtRH = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblHeatIndex = new System.Windows.Forms.Label();
            this.txtHeatIndex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(156, 192);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 37);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(225, 30);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 20);
            this.txtTemp.TabIndex = 2;
            // 
            // txtRH
            // 
            this.txtRH.Location = new System.Drawing.Point(225, 67);
            this.txtRH.Name = "txtRH";
            this.txtRH.Size = new System.Drawing.Size(100, 20);
            this.txtRH.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(156, 114);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblHeatIndex
            // 
            this.lblHeatIndex.AutoSize = true;
            this.lblHeatIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeatIndex.Location = new System.Drawing.Point(90, 157);
            this.lblHeatIndex.Name = "lblHeatIndex";
            this.lblHeatIndex.Size = new System.Drawing.Size(73, 16);
            this.lblHeatIndex.TabIndex = 6;
            this.lblHeatIndex.Text = "Feels Like:";
            // 
            // txtHeatIndex
            // 
            this.txtHeatIndex.Location = new System.Drawing.Point(225, 154);
            this.txtHeatIndex.Name = "txtHeatIndex";
            this.txtHeatIndex.ReadOnly = true;
            this.txtHeatIndex.Size = new System.Drawing.Size(100, 20);
            this.txtHeatIndex.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Temperauter in Fahrenheit: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Relative Humidity:";
            // 
            // HeatIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 245);
            this.Controls.Add(this.txtHeatIndex);
            this.Controls.Add(this.lblHeatIndex);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtRH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Name = "HeatIndex";
            this.Text = "Heat Index";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtRH;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblHeatIndex;
        private System.Windows.Forms.TextBox txtHeatIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}