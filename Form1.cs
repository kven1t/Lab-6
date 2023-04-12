using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmr.Enabled = !tmr.Enabled;
            btnStart.Text = tmr.Enabled ? "Стоп" : "Старт";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            if (pct.Left + pct.Width + 20 > this.ClientSize.Width)
            {
                tmr.Enabled = true;
            }
            else
            {
                pct.Left += 20;
            }
        }
    }
}
