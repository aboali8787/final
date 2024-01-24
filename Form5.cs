using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace new_form
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();
            this.Hide();

            if (textBox1.Text == "")
            {
                MessageBox.Show("اطلاعات را تکمیل کنید");
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("اطلاعات را تکمیل کنید");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("اطلاعات را تکمیل کنید");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("اطلاعات را تکمیل کنید");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("اطلاعات را تکمیل کنید");
            }
            else
            {
                Form6 f6 = new Form6();
                f6.Show();

                f6.listBox1.Items.Add(textBox1.Text + "\t\t" + textBox1.Text + "\t\t " + textBox2.Text + "\t\t " + textBox3.Text + "\t\t " + textBox4.Text);
                this.Hide();
            }
        }
    }
}
