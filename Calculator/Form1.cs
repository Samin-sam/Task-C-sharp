using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation= " ";
        bool operation_pressed = false;
      

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
               if ((txtResult.Text == "0") || (operation_pressed))
                   txtResult.Clear();

            operation_pressed = false;
            Button b = (Button)sender;

            txtResult.Text = txtResult.Text + b.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(txtResult.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;
           
            
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            equation.Text = " ";
            switch (operation)
            {
                case "+":
                    txtResult.Text = (value  + Double.Parse(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (value - Double.Parse(txtResult.Text)).ToString();
                    break;
                case "*":
                    txtResult.Text = (value * Double.Parse(txtResult.Text)).ToString();
                    break;
                case "/":
                    txtResult.Text = (value / Double.Parse(txtResult.Text)).ToString();
                    break;
                case "%":
                    txtResult.Text = (value/100).ToString();
                    break;
                default:
                    break;
                    
            }
          
        }

        private void btnClearAll(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            value = 0;
        }

        private void btnClear(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            value = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Equation_Click(object sender, EventArgs e)
        {

        }
    }
}
