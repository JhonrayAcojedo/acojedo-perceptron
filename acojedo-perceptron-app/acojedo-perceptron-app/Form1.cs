using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace acojedo_perceptron_app
{
    public partial class Form1 : Form
    {
        Perceptron perceptron;
        private void CreateBtn_Click(object sender, EventArgs e)
        {
           perceptron = new Perceptron();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void TrainBtn_Click(object sender, EventArgs e)
        {
            double[] weights = perceptron.Train(Convert.ToInt32(textBox2.Text));

            foreach(double i in weights)
            {
                Console.WriteLine(i);
            }
        }

        private void RunBtn_Click(object sender, EventArgs e)
        {
            int[] input;
            switch (Convert.ToInt32(textBox1.Text))
            {
                case 0:
                    input = new int[] { 1,1,1,1,1,
                                 1,0,0,1,1,
                                 1,0,1,0,1,
                                 1,1,0,0,1,
                                 1,1,1,1,1}; break;
                case 1: input = new int[] { 1,1,1,0,0,
                                 0,0,1,0,0,
                                 0,0,1,0,0,
                                 0,0,1,0,0,
                                 1,1,1,1,1}; break;
                case 2: input = new int[] { 1,1,1,1,1,
                                 0,0,0,0,1,
                                 1,1,1,1,1,
                                 1,0,0,0,0,
                                 1,1,1,1,1}; break;
                case 3: input = new int[] { 1,1,1,1,1,
                                 0,0,0,0,1,
                                 1,1,1,1,1,
                                 0,0,0,0,1,
                                 1,1,1,1,1}; break;
                case 4: input = new int[] {1,0,0,0,1,
                                 1,0,0,0,1,
                                 1,1,1,1,1,
                                 0,0,0,0,1,
                                 0,0,0,0,1}; break;
                case 5: input = new int[] {1,1,1,1,1,
                                 1,0,0,0,0,
                                 1,1,1,1,1,
                                 0,0,0,0,1,
                                 1,1,1,1,1}; break;
                case 6: input = new int[] { 1,1,1,1,1,
                                 1,0,0,0,0,
                                 1,1,1,1,1,
                                 1,0,0,0,1,
                                 1,1,1,1,1}; break;
                case 7: input = new int[] {1,1,1,1,1,
                                 0,0,0,1,0,
                                 0,0,1,0,0,
                                 0,1,0,0,0,
                                 1,0,0,0,0}; break;
                case 8: input = new int[] { 1,1,1,1,1,
                                 1,0,0,0,1,
                                 1,1,1,1,1,
                                 1,0,0,0,1,
                                 1,1,1,1,1}; break;
                case 9: input = new int[] {1,1,1,1,1,
                                 1,0,0,0,1,
                                 1,1,1,1,1,
                                 0,0,0,0,1,
                                 1,1,1,1,1}; break;
                default: input = new int[] { 1,1,1,1,1,
                                 1,0,0,1,1,
                                 1,0,1,0,1,
                                 1,1,0,0,1,
                                 1,1,1,1,1}; break;
            }

            if(perceptron.Predict(input) == 1)
                OutputLbl.Text = "Odd";
            else
                OutputLbl.Text = "Even";

        }
    }
}
