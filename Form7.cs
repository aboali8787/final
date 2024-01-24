using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_form
{
    public partial class Form7 : Form
    {
        
        public Form8 form8;
        public Form7()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form8 form = new Form8();
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
                Form8 f8 = new Form8();
                f8.Show();

                f8.listBox1.Items.Add(textBox1.Text + "\t" + textBox1.Text + "\t " + textBox2.Text + "\t " + textBox3.Text + "\t " + textBox4.Text);
                this.Hide();
            }

        }
    }
}
