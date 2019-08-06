namespace WeatherLibraryTester
{
    partial class WindSpeed
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
            this.lblWindSpeed = new System.Windows.Forms.Label();
            this.txtWindSpeed = new System.Windows.Forms.TextBox();
            this.cbWindspeed = new System.Windows.Forms.ComboBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cbResult = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(207, 188);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 33);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.AutoSize = true;
            this.lblWindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindSpeed.Location = new System.Drawing.Point(50, 28);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(363, 20);
            this.lblWindSpeed.TabIndex = 1;
            this.lblWindSpeed.Text = "Enter a Wind Speed that you would like to convert:";
            // 
            // txtWindSpeed
            // 
            this.txtWindSpeed.Location = new System.Drawing.Point(105, 66);
            this.txtWindSpeed.Name = "txtWindSpeed";
            this.txtWindSpeed.Size = new System.Drawing.Size(121, 20);
            this.txtWindSpeed.TabIndex = 2;
            // 
            // cbWindspeed
            // 
            this.cbWindspeed.FormattingEnabled = true;
            this.cbWindspeed.Items.AddRange(new object[] {
            "mph",
            "knots"});
            this.cbWindspeed.Location = new System.Drawing.Point(105, 92);
            this.cbWindspeed.Name = "cbWindspeed";
            this.cbWindspeed.Size = new System.Drawing.Size(121, 21);
            this.cbWindspeed.TabIndex = 3;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(239, 81);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(28, 16);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "To:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(273, 66);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(121, 20);
            this.txtResult.TabIndex = 5;
            // 
            // cbResult
            // 
            this.cbResult.FormattingEnabled = true;
            this.cbResult.Items.AddRange(new object[] {
            "mph",
            "knots"});
            this.cbResult.Location = new System.Drawing.Point(273, 92);
            this.cbResult.Name = "cbResult";
            this.cbResult.Size = new System.Drawing.Size(121, 21);
            this.cbResult.TabIndex = 6;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(207, 136);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "From:";
            // 
            // WindSpeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 243);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.cbResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.cbWindspeed);
            this.Controls.Add(this.txtWindSpeed);
            this.Controls.Add(this.lblWindSpeed);
            this.Controls.Add(this.btnClose);
            this.Name = "WindSpeed";
            this.Text = "Wind Speed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblWindSpeed;
        private System.Windows.Forms.TextBox txtWindSpeed;
        private System.Windows.Forms.ComboBox cbWindspeed;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ComboBox cbResult;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label1;
    }
}