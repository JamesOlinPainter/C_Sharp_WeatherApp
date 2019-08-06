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
    public partial class WindChill : Form
    {
        public WindChill()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtFeelsLike.Text = windChill_C(double.Parse(txtWindSpeed.Text), double.Parse(txtTemp.Text)).ToString();
        }
    }
}
