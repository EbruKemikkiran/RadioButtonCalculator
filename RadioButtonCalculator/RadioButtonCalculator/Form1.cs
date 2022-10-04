using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonCalculator
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        

        double number1 = Convert.ToString(textBox1.Text);
        double number2 = Convert.ToString(textBox2.Text);
        double Addition, Multiplication, Division, Subtraction;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
  

         private void radioButton1_Click(object sender, EventArgs e)
         {
            Addition = number1 + number2;
            label1.Text = Addition.ToString();
         }


        


    }
}
