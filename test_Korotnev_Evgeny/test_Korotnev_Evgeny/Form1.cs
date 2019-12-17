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

    public class Users
    {
        public List<string> Logins = new List<string>(); //login 
        public List<string> Passwords = new List<string>(); //password 

    }

    public partial class Form1 : Form

    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox_login.Text == "login") && (textBox_password.Text == "pass"))
            {
                Form3 f = new Form3();
                f.Show();
            }
        }
    }
}
