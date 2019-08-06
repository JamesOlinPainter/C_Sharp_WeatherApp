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
    public partial class VolumeOfRain : Form
    {
        public VolumeOfRain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtVolume.Text = volumeOfRain(double.Parse(txtArea.Text), double.Parse(txtRainfall.Text)).ToString() + " cubic units";
        }
    }
}
