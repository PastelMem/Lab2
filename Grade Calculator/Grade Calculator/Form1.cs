using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_Calculator
{
    public partial class Form1 : Form
    {
        int arrayIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputID = tbInputID.Text;
            string inputName = tbInputName.Text;
            string inputScore = tbInputScore.Text;
            string[] arrID = new string[1000];
            string[] arrName = new string[1000];
            string[] arrScore = new string[1000];
            arrID[arrayIndex] = inputID;
            arrScore[arrayIndex] = inputScore;
            arrayIndex++;

            
        }
    }
}
