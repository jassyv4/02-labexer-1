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

            CashierWindowQueueForm cashierForm = new CashierWindowQueueForm();
            cashierForm.Show();

            CustomerView customerForm = new CustomerView();
            customerForm.Show();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            CashierClass cashier = new CashierClass();

            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);

        }

    }
}
