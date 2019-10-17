using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankaccWindowsFormsApp
{
    public partial class Bankaccount : Form
    {
        public Bankaccount()
        {
            InitializeComponent();
        }

        Account account = new Account();
        private void createButton_Click(object sender, EventArgs e)
        {
            account.accountNumber = accountTextBox.Text;
            account.customerName = nameTextBox.Text;        
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            account.Deposite(amount);
            amountTextBox.Clear();
        }
        private void withdrawButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            account.withdraw(amount);
            amountTextBox.Clear();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            accountTextBox.Clear();
            nameTextBox.Clear();
            MessageBox.Show(account.Getinfo());
        }
       
    }
}
