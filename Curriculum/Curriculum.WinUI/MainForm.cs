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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BachelorFour bachelorFour = new BachelorFour();
            bachelorFour.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BachelorThree bachelorThree = new BachelorThree();
            bachelorThree.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MasterOne masterOne = new MasterOne();
            masterOne.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MasterTwo masterTwo = new MasterTwo();
            masterTwo.Show();
        }
    }
}
