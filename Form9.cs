using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace new_form
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "")
            {
                MessageBox.Show("کتابی انتخاب نشده است");
            }
            else
            {
                string na = comboBox1.Text;
                SqlConnection sc = new SqlConnection(@"C:\Users\ASAD RAYANco\source\repos\new form\new form\Database3.mdf");
                sc.Open();
                SqlCommand comm = new SqlCommand("SELECT name FROM book WHERE name=N'" + na + "'", sc);
                SqlDataReader reader = comm.ExecuteReader();
                reader.Read();
                textBox1.Text = reader["name"].ToString();
                sc.Close();


                SqlConnection sc1 = new SqlConnection(@"C:\Users\ASAD RAYANco\source\repos\new form\new form\Database3.mdf");
                sc1.Open();
                SqlCommand comm1 = new SqlCommand("SELECT code FROM book WHERE name=N'" + na + "'", sc1);
                SqlDataReader reader1 = comm1.ExecuteReader();
                reader1.Read();
                textBox2.Text = reader1["code"].ToString();
                sc1.Close();

                SqlConnection sc2 = new SqlConnection(@"C:\Users\ASAD RAYANco\source\repos\new form\new form\Database3.mdf");
                sc2.Open();
                SqlCommand comm2 = new SqlCommand("SELECT zhanre FROM book WHERE name=N'" + na + "'", sc2);
                SqlDataReader reader2 = comm2.ExecuteReader();
                reader2.Read();
                textBox3.Text = reader2["zhanre"].ToString();
                sc2.Close();

                SqlConnection sc3 = new SqlConnection(@"C:\Users\ASAD RAYANco\source\repos\new form\new form\Database3.mdf");
                sc3.Open();
                SqlCommand comm3 = new SqlCommand("SELECT writer FROM book WHERE name=N'" + na + "'", sc3);
                SqlDataReader reader3 = comm3.ExecuteReader();
                reader3.Read();
                textBox4.Text = reader3["writer"].ToString();
                sc3.Close();




            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ASAD RAYANco\source\repos\new form\new form\Database3.mdf"";Integrated Security=True");
            
            string query = "SELECT * FROM book ";
            SqlCommand command = new SqlCommand(query, sc);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader["name"].ToString());
            }

            
        }
    }
}
