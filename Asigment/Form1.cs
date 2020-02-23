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

            string userName;
            string monthOfTraining; 

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

            userName = Console.ReadLine();  //Reads the Variable
            monthOfTraining = Console.ReadLine();  //Reads the Variable


            longDistance = double.Parse(lblLongerDistance.Text);
            longTime = double.Parse(lblLongerTime.Text);

            shortDistance = double.Parse(lblShorterDistance.Text);
            shortTime = double.Parse(lblShorterTime.Text);

            workoutDistance = double.Parse(lblWorkoutDistance.Text);
            workingTime = double.Parse(lblWorkingTime.Text);

            //Processing
            userName = lblName.Text;  //Takes the name of the Swimmer (entered by the user) and 'saves' it
            monthOfTraining = lblMonthOfTraining.Text;  //Takes the Month the Swimmer is training (entered by the user) and 'saves' it

            CSS = (longDistance - shortDistance) / (longTime - shortTime);
            NSS = (workoutDistance / workingTime);
            IF = (NSS / CSS);
            TSS = ((IF * IF * IF) * (workingTime/3600) * 100);

            //Displaying the Array

            string[,,] Array_ThreeDimension = new string[3, 2, 2];  //x = 3; y = 3; z = 3;   //Multiplying this 3 numbers, we obtaing 10, as we need to create it for 10 swimmers
              
            Array_ThreeDimension[1, 1, 1] = "Hello World";  //Used to check that the Array temporaly works

            int x = 0;  //Intial 'x' value
            int y = 0;  //Intial 'y' value
            int z = 0;  //Intial 'z' value

            for (x = 0; x <= 9; x++)
            {
                for(y = 0; y <= 9; y++)
                {
                    for(z = 0; z <= 9; z++)
                    {
                        Console.WriteLine("{0, 9}  {0, 9}  {0, 9}", x, y, z);
                        if(Array_ThreeDimension [x, y, z] == null)  //null = empty
                        {
                            Console.WriteLine("Empty");
                        }
                        else
                        {
                            Console.WriteLine("{0}", Array_ThreeDimension[x, y, z]);
                        }
                    }                    
                }
            }



            //OutPut

            lblName.Text = userName.ToString();
            lblMonthOfTraining.Text = monthOfTraining.ToString();

            lblCSS.Text = CSS.ToString();
            lblNSS.Text = NSS.ToString();
            lblIF.Text = IF.ToString();
            lblTSS.Text = TSS.ToString();
        }
    }
}
