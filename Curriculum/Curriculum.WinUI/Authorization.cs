using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curriculum.WinUI
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;

            if (login == "mylogin" && password == "qwerty12345")
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else if ((login == "mylogin" && password != "qwerty12345") || (login != "mylogin" && password == "qwerty12345") || (login != "mylogin" && password != "qwerty12345"))
            {
                MessageBox.Show("Неправильний логін або пароль");
            }
        }
    }
}
