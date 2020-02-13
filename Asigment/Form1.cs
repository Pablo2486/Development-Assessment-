using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asigment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            //Declarations

            double longDistance;
            double longTime;
            double shortDistance;
            double shortTime;

            double workoutDistance;
            double workingTime;

            double CSS; //Critical Swim Speed
            double NSS; //Normalized Swim Speed
            double IF;  //Intensity Factor 
            double TSS; //Training Stress Score

            //Inputs

            longDistance = double.Parse(lblLongerDistance.Text);
            longTime = double.Parse(lblLongerTime.Text);

            shortDistance = double.Parse(lblShorterDistance.Text);
            shortTime = double.Parse(lblShorterTime.Text);

            workoutDistance = double.Parse(lblWorkoutDistance.Text);
            workingTime = double.Parse(lblWorkingTime.Text);

            //Processing

            CSS = (longDistance - shortDistance) / (longTime - shortTime);
            NSS = (workoutDistance / workingTime);
            IF = (NSS / CSS);
            TSS = ((IF * IF * IF) * (workingTime/3600) * 100);

            //OutPut

            lblCSS.Text = CSS.ToString();
            lblNSS.Text = NSS.ToString();
            lblIF.Text = IF.ToString();
            lblTSS.Text = TSS.ToString();
        }
    }
}
