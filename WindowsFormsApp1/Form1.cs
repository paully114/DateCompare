using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string now, exp;

        public Form1()
        {
            InitializeComponent();
            now = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void Check_Click(object sender, EventArgs e)
        {
            exp = dtpExp.Value.ToString("dddd, dd MMMM yyyy");

            if (now == exp)
            {
                MessageBox.Show("Same");
            }
            else
            {
                MessageBox.Show("Not same");
            }
        }

        private void btnNow_Click(object sender, EventArgs e)
        {
            exp = dtpExp.Value.ToString("dddd, dd MMMM yyyy");
            MessageBox.Show(now);
            MessageBox.Show(exp);
        }
    }
}
