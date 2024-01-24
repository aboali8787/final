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
    public partial class Form8 : Form
    {
        Form7 f7= new Form7();
        public Form8()
        {
            InitializeComponent();
            
        }
        public Form8(string name, string lastname, string id, string number)

        {
            InitializeComponent();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
