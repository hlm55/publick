using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_Korotnev_Evgeny
{
    public partial class Form2 : Form
    {
        public string login = string.Empty;
        public string password = string.Empty;
        private Users user = new Users ();

 

        public Form2()
        {
            InitializeComponent();
          
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Close();
        }
    }
}
