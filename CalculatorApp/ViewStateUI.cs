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
    public partial class ViewStateUI : Form
    {
        public ViewStateUI()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;

            nameTextBox.Text = string.Empty;
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            nameLavel.Text = nameTextBox.Text;
        }
    }
}
