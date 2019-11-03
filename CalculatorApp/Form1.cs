using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class calculatorUI : Form
    {
        public calculatorUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secoundNumber = Convert.ToDouble(secoundNumberTextBox.Text);

            double result = Add(firstNumber, secoundNumber);

            resultTextBox.Text = result.ToString();
        }

        double Add (double firstNumber, double secoundNumber)
        {
            return firstNumber + secoundNumber;
        }
    }
}
