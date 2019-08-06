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
    public partial class Humidity : Form
    {
        public Humidity()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtHumidity.Text = humidity(double.Parse(txtTemp.Text), double.Parse(txtDewPoint.Text)).ToString();
        }
    }
}
