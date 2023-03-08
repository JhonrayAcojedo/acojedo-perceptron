using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace acojedo_perceptron_app
{
    public partial class Form1 : Form
    {
        int[] w0 = new int[26] { 1,1,1,1,1,
                                 1,0,0,1,1,
                                 1,0,1,0,1,
                                 1,1,0,0,1,
                                 1,1,1,1,1,
                                 0};
        int[] w1 = new int[26] { 1,1,1,0,0,
                                 0,0,1,0,0,
                                 0,0,1,0,0,
                                 0,0,1,0,0,
                                 1,1,1,1,1,
                                 1};
        int[] w2 = new int[26] { 1,1,1,1,1,
                                 0,0,0,0,1,
                                 1,1,1,1,1,
                                 1,0,0,0,0,
                                 1,1,1,1,1,
                                 0};
        int[] w3 = new int[26] { 1,1,1,1,1,
                                 0,0,0,0,1,
                                 1,1,1,1,1,
                                 0,0,0,0,1,
                                 1,1,1,1,1,
                                 1};
        int[] w4 = new int[26] { 1,0,0,0,1,
                                 1,0,0,0,1,
                                 1,1,1,1,1,
                                 0,0,0,0,1,
                                 0,0,0,0,1,
                                 0};
        int[] w5 = new int[26] { 1,1,1,1,1,
                                 1,0,0,0,0,
                                 1,1,1,1,1,
                                 0,0,0,0,1,
                                 1,1,1,1,1,
                                 1};
        int[] w6 = new int[26] { 1,1,1,1,1,
                                 1,0,0,0,0,
                                 1,1,1,1,1,
                                 1,0,0,0,1,
                                 1,1,1,1,1,
                                 0};
        int[] w7 = new int[26] { 1,1,1,1,1,
                                 0,0,0,1,0,
                                 0,0,1,0,0,
                                 0,1,0,0,0,
                                 1,0,0,0,0,
                                 1};
        int[] w8 = new int[26] { 1,1,1,1,1,
                                 1,0,0,0,1,
                                 1,1,1,1,1,
                                 1,0,0,0,1,
                                 1,1,1,1,1,
                                 0};
        int[] w9 = new int[26] { 1,1,1,1,1,
                                 1,0,0,0,1,
                                 1,1,1,1,1,
                                 0,0,0,0,1,
                                 1,1,1,1,1,
                                 1};
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
