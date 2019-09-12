using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowsFormsApp
{
    public partial class DataUI : Form
    {
        public DataUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            String name = nameTextBox.Text;
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);

            int result = firstNumber + secondNumber;

            MessageBox.Show("Name : " + name + " Result : " + result.ToString());

        }
    }
}
