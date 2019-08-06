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
    public partial class WindSpeed : Form
    {
        public WindSpeed()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if ((cbWindspeed.SelectedIndex == -1) || (cbResult.SelectedIndex == -1)) //Nothing selected
            {
                MessageBox.Show("You must select a conversion type", "Error");
            }
            else
            {
                switch (cbWindspeed.SelectedIndex)
                {
                    case 0:
                        switch (cbResult.SelectedIndex)
                        {
                            case 0:
                                txtResult.Text = txtWindSpeed.Text;
                                break;
                            case 1:
                                txtResult.Text = MPHtoKnots(double.Parse(txtWindSpeed.Text)).ToString();
                                break;
                        }
                        break;
                    case 1:
                        switch (cbResult.SelectedIndex)
                        {
                            case 0:
                                txtResult.Text = KnotsToMPH(double.Parse(txtWindSpeed.Text)).ToString();
                                break;
                            case 1:
                                txtResult.Text = txtWindSpeed.Text;
                                break;
                        }
                        break;

                }
            }
        }
    }
}
