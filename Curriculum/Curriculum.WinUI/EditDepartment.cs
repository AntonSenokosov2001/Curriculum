using System;
using System.Windows.Forms;
using System.Drawing;

namespace Curriculum.WinUI
{
    public partial class EditDepartment : Form
    {
        public EditDepartment(int num, string name)
        {
            InitializeComponent();
            this.Text += " " + num;
            NewNumDep.Text = num.ToString();
            NewNameDep.Text = name;
        }

        private void NewNumDep_TextChanged(object sender, EventArgs e)
        {
            bool valid = int.TryParse(NewNumDep.Text, out int ignored);

            if (valid || NewNumDep.Text == "")
            {
                NewNumDep.ForeColor = Color.Black;
                label3.Visible = false;
            }
            else
            {
                NewNumDep.ForeColor = Color.Red;
                label3.Visible = true;
            }
        }

        private void ClearNum_Click(object sender, EventArgs e)
        {
            NewNumDep.Clear();
            NewNumDep.Focus();
        }

        private void ClearName_Click(object sender, EventArgs e)
        {
            NewNameDep.Clear();
            NewNameDep.Focus();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {
                MessageBox.Show("Невірний формат введених даних. Спробуйте ще.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
