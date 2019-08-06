using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WeatherLibrary.weatherLibrary;


namespace WeatherLibraryTester
{
    public partial class MixingRatio : Form
    {
        public MixingRatio()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double[] answer = new double[2];
            answer = mixingRatio(double.Parse(txtTemp.Text), double.Parse(txtDewpoint.Text), double.Parse(txtPressure.Text));
            txtAMR.Text = answer[0].ToString();
            txtSMR.Text = answer[1].ToString();
        }
    }
}
