using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherLibraryTester
{
    public partial class WeatherCalculator : Form
    {
        public WeatherCalculator()
        {
            InitializeComponent();
        }

        private void btnTC_Click(object sender, EventArgs e)
        {
            //create instance of TemperatureConversion class
            TemperatureConversion myTemperatureConversion = new TemperatureConversion();

            //Display form
            myTemperatureConversion.ShowDialog();
        }

        private void btnHeatIndex_Click(object sender, EventArgs e)
        {
            //instance of HeatIndex
            HeatIndex myHeatIndex = new HeatIndex();

            //display form
            myHeatIndex.ShowDialog();
        }

        private void btnWindChill_Click(object sender, EventArgs e)
        {
            //instance of WindChill
            WindChill myWindChill = new WindChill();

            //display form
            myWindChill.ShowDialog();
        }

        private void btnDewPoint_Click(object sender, EventArgs e)
        {
            //instance of DewPoint
            DewPoint myDewPoint = new DewPoint();

            //display form
            myDewPoint.ShowDialog();
        }

        private void btnVT_Click(object sender, EventArgs e)
        {
            //instance of VirtualTemperature
            VirtualTemperature myVirtualTemperature = new VirtualTemperature();

            //display form
            myVirtualTemperature.ShowDialog();
        }

        private void btnHumidity_Click(object sender, EventArgs e)
        {
            //instance of Humidity
            Humidity myHumidity = new Humidity();

            //display form
            myHumidity.ShowDialog();
        }

        private void btnVR_Click(object sender, EventArgs e)
        {
            //instance of VolumeOfRain
            VolumeOfRain myVolumeOfRain = new VolumeOfRain();

            //display form
            myVolumeOfRain.ShowDialog();
        }

        private void btnMixingRatio_Click(object sender, EventArgs e)
        {
            //instance of MixingRatio
            MixingRatio myMixingRatio = new MixingRatio();

            //show form
            myMixingRatio.ShowDialog();
        }

        private void btnWindSpeed_Click(object sender, EventArgs e)
        {
            //instance of WindSpeed
            WindSpeed myWindSpeed = new WindSpeed();

            //show form
            myWindSpeed.ShowDialog();
        }
    }//end class
}//end namespace