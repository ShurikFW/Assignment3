using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Body_Mass_Index
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Weight, Heigth, calc;
            Weight = double.Parse(textBox2.Text);
            Heigth = double.Parse(textBox1.Text);
            double Heigth_in_meters = Heigth / 100;
            calc = Weight / Math.Pow(Heigth_in_meters,2);
            label3.Text = calc.ToString();
            string status = "";
            if ( calc > 25)
            {
                status = "Overweight";
            }
            if (calc < 18.5)
            {
                status = "Underweigth";
            }
            if (calc >= 18.5 && calc <= 25)
            {
                status = "Normal weight";
            }
            label3.Text = String.Format("BMI: {0}\nStatus: {1}", calc, status);
        }
    }
}
