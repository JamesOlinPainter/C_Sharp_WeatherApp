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
    public partial class TemperatureConversion : Form
    {
        public TemperatureConversion()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if ((cbFrom.SelectedIndex == -1) || (cbTo.SelectedIndex == -1)) //Nothing selected
            {
                MessageBox.Show("You must select a conversion type", "Error");
            }
            else
            {
                switch (cbFrom.SelectedIndex)
                {
                    case 0:
                        switch (cbTo.SelectedIndex)
                        {
                            case 0:
                                txtTo.Text = txtFrom.Text;
                                break;
                            case 1:
                                txtTo.Text = FahrenheitToCelsius(double.Parse(txtFrom.Text)).ToString();
                                break;
                            case 2:
                                txtTo.Text = FahrenheitToKelvin(double.Parse(txtFrom.Text)).ToString();
                                break;
                        }
                        break;
                    case 1:
                        switch (cbTo.SelectedIndex)
                        {
                            case 0:
                                txtTo.Text = CelsiusToFahrenheit(double.Parse(txtFrom.Text)).ToString();
                                break;
                            case 1:
                                txtTo.Text = txtFrom.Text;
                                break;
                            case 2:
                                txtTo.Text = CelsiusToKelvin(double.Parse(txtFrom.Text)).ToString();
                                break;
                        }
                        break;
                    case 2:
                        switch (cbTo.SelectedIndex)
                        {
                            case 0:
                                txtTo.Text = KelvinToFahrenheit(double.Parse(txtFrom.Text)).ToString();
                                break;
                            case 1:
                                txtTo.Text = KelvinToCelsius(double.Parse(txtFrom.Text)).ToString();
                                break;
                            case 2:
                                txtTo.Text = txtFrom.Text;
                                break;
                        }
                        break;
                }
            }
        }

    }
}
