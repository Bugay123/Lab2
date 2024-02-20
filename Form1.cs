using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control tabPage in tabControl1.Controls)
            {
                foreach (Control control in tabPage.Controls)
                {
                    if (control is NumericUpDown)
                    {
                        NumericUpDown numericUpDown = (NumericUpDown)control;
                        numericUpDown.Value = 0;
                        }
                }
            }
            label10.Text = string.Empty;
            label10.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = ((int)numericUpDown1.Value * int.Parse(textBox1.Text)) +
                ((int)numericUpDown2.Value * int.Parse(textBox2.Text)) +
                ((int)numericUpDown3.Value * int.Parse(textBox3.Text)) +
                ((int)numericUpDown4.Value * int.Parse(textBox4.Text)) +
                ((int)numericUpDown5.Value * int.Parse(textBox5.Text)) +
                ((int)numericUpDown6.Value * int.Parse(textBox6.Text)) +
                ((int)numericUpDown7.Value * int.Parse(textBox7.Text)) +
                ((int)numericUpDown8.Value * int.Parse(textBox8.Text)) +
                ((int)numericUpDown9.Value * int.Parse(textBox9.Text));
            label10.Visible = true;
            label10.Text = "Загальна сума замовлення " + result.ToString();
        }
    }
}
