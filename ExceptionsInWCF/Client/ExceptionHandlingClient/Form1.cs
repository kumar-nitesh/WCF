using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExceptionHandlingClient.ServiceReference;

namespace ExceptionHandlingClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            // Creates a new instance for every call, so channel doesn't become faulty if exception occurs.
            DivideClient proxy = new DivideClient();
            lblResult.Text = proxy.DivideNumber(Convert.ToInt32(txtNum.Text), Convert.ToInt32(txtDenom.Text)).ToString();            
        }
    }
}
