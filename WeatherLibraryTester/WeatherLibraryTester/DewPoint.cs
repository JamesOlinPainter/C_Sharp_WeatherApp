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
    public partial class DewPoint : Form
    {
        public DewPoint()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtDewPoint.Text = dewPoint_C(double.Parse(txtTemp.Text), double.Parse(txtRH.Text)).ToString();
        }
    }
}
