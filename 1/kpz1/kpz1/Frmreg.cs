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
    public partial class Frmreg : Form
    {
        int tries=4;
        public string fname;
        public Frmreg()
        {
            InitializeComponent();
            
            this.Text="Реєстрація(кількість спроб "+tries+")";
        }
        bool verify(string text)
		{
			char[] arr;
			arr = text.ToCharArray (0, text.Length);
			for (int i = 0; i < text.Length; i =+ 1){
				if (i % 2 == 1){
					if (Char.IsNumber(arr [i]))
						;
				else return false;}
			}
			return true;
		}
        private void login_Click(object sender, EventArgs e)
        {
            if (familia.Text != " " && name.Text != " " && textBox1.Text != " " && textBox2.Text != " " && textBox3.Text != " " && textBox4.Text != " " && textBox5.Text != " ")
            {
                if ((verify(textBox1.Text)) && (verify(textBox2.Text)) && (verify(textBox3.Text)) && (verify(textBox4.Text)) && (verify(textBox5.Text)))
                {
                
                 
                    user userf = new user();
                    userf.Text = "Роботу проводить:" + fname;
                    userf.ShowDialog();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Incorrect password");
                    tries -= 1;
                }
            }
            else
                MessageBox.Show("Empty fields");
            this.Text = "Реєстрація(кількість спроб " + tries + ")";
            if (tries <= 0)
            {
                this.Text = "Ви використали всі спроби! Кнопка заблокована!";
                login.Enabled = false;
            }
        }

        private void Frmreg_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        
    }
}
