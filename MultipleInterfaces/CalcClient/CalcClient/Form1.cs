using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcClient.Calc_SvcRef.AddClient addProxy = new Calc_SvcRef.AddClient();
            var res = addProxy.Add(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label3.Text = res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalcClient.Calc_SvcRef.SubClient subProxy = new Calc_SvcRef.SubClient();
            var res = subProxy.Sub(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label3.Text = res.ToString();

        }
    }
}
