using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _02_labexer_1.QueuingForm;

namespace _02_labexer_1
{
    public partial class CustomerView : Form
    {
        private Timer timer;
        public CustomerView()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                lblQueueNum.Text = "P - " + CashierClass.CashierQueue.Peek();
            }
            else
            {
                lblQueueNum.Text = "No students in queue.";
            }
        }
    }
}
