using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_form
{
    public partial class Form3 : Form
    {
        public static string name = "";
        public Form4 f4;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();

            if (textBox1.Text=="")
            {
                MessageBox.Show("اطلاعات را تکمیل کنید");
            }
            else if(textBox2.Text=="")
            {
                MessageBox.Show("اطلاعات را تکمیل کنید");
            }
            else if(textBox3.Text=="")
            {
                MessageBox.Show("اطلاعات را تکمیل کنید");
            }
            else if (textBox4.Text=="")
            {
                MessageBox.Show("اطلاعات را تکمیل کنید");
            }
            else if(textBox5.Text=="")
            {
                MessageBox.Show("اطلاعات را تکمیل کنید");
            }
            else
            {
                Form4 f4 = new Form4();
                f4.Show();

                f4.listBox1.Items.Add( textBox1.Text +"\t\t"  + textBox2.Text+"\t\t " + textBox3.Text+ "\t\t " +  textBox4.Text+ "\t\t " + textBox5.Text);
                this.Hide();
            }
        }

        public partial class form3:Form
        {
     
            
       
        }
    }
}
