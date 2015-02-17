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
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
          
        }


        private void user_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            { this.BackColor = Color.Red; }
            if (comboBox1.SelectedIndex == 1)
            { this.BackColor = Color.Blue; }
            if (comboBox1.SelectedIndex == 2)
            { this.BackColor = Color.Green; }
            if (comboBox1.SelectedIndex == 3)
            { this.BackColor = Color.White; }
            if (comboBox1.SelectedIndex == 4)
            { this.BackColor = Color.Black; }
            if (comboBox1.SelectedIndex == 5)
            { this.BackColor = Color.Orange; }
            if (comboBox1.SelectedIndex == 6)
            { this.BackColor = Color.Yellow; }
        }

   

    }
}
