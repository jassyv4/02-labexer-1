using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_labexer_1
{
    public partial class QueuingForm : Form
    {
        private CashierClass cashier;
        public QueuingForm()
        {
            InitializeComponent();

            cashier = new CashierClass();

            CustomerView customerForm = new CustomerView();
            customerForm.Show();
        }
        public class CashierClass
        {
            private int x;
            public static string getNumberInQueue = "";
            public static Queue<string> CashierQueue;
            public CashierClass()
            {
                x = 10000;
                CashierQueue = new Queue<string>();
            }
            public string CashierGeneratedNumber(string CashierNumber)
            {
                x++;
                CashierNumber = CashierNumber + x.ToString();
                return CashierNumber;
            }
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            CashierClass cashier = new CashierClass();

            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CashierWindowQueueForm cashierWindow = new CashierWindowQueueForm();
            cashierWindow.DisplayCashierQueue(CashierClass.CashierQueue);

            cashierWindow.Show();
        }
    }
}
