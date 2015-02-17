using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kpz1
{
    public partial class splash : Form
    {
        private readonly Timer tmrShow;

        public splash()
        {
            InitializeComponent();
            tmrShow = new Timer();
            tmrShow.Interval = 5000;
            tmrShow.Tick += tmrShow_Tick;
            tmrShow.Enabled = true;

        }

        private void tmrShow_Tick(object sender, EventArgs e)
        {
            tmrShow.Stop();
            Frmreg fr = new Frmreg();
            this.Hide();
            fr.ShowDialog();
        }
    }
}
