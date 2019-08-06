namespace WeatherLibraryTester
{
    partial class VolumeOfRain
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
            this.lblArea = new System.Windows.Forms.Label();
            this.lblRainfall = new System.Windows.Forms.Label();
            this.txtRainfall = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblVolume = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(175, 164);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(11, 14);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(203, 16);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Enter the size of the surface area:";
            // 
            // lblRainfall
            // 
            this.lblRainfall.AutoSize = true;
            this.lblRainfall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRainfall.Location = new System.Drawing.Point(12, 53);
            this.lblRainfall.Name = "lblRainfall";
            this.lblRainfall.Size = new System.Drawing.Size(137, 16);
            this.lblRainfall.TabIndex = 2;
            this.lblRainfall.Text = "Enter Rainfall amount:";
            // 
            // txtRainfall
            // 
            this.txtRainfall.Location = new System.Drawing.Point(281, 49);
            this.txtRainfall.Name = "txtRainfall";
            this.txtRainfall.Size = new System.Drawing.Size(121, 20);
            this.txtRainfall.TabIndex = 3;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(280, 14);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(121, 20);
            this.txtArea.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(175, 83);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.Location = new System.Drawing.Point(84, 127);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(102, 16);
            this.lblVolume.TabIndex = 7;
            this.lblVolume.Text = "Volume of Rain:";
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(235, 123);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.ReadOnly = true;
            this.txtVolume.Size = new System.Drawing.Size(100, 20);
            this.txtVolume.TabIndex = 8;
            // 
            // VolumeOfRain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 212);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtRainfall);
            this.Controls.Add(this.lblRainfall);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.btnClose);
            this.Name = "VolumeOfRain";
            this.Text = "Volume Of Rain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblRainfall;
        private System.Windows.Forms.TextBox txtRainfall;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TextBox txtVolume;
    }
}