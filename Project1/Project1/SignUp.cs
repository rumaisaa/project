using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Project1
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mail = email.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(mail);

            if (match.Success)
            {
                Console.WriteLine(MessageBox.Show("You are registred"));

                this.Hide();
                Entrance form = new Entrance();
                form.Show();
            }

            else
            {
                Console.WriteLine(MessageBox.Show("Your email id is wrong"));
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}
