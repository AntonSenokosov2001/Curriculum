using System;
using System.Drawing;
using System.Windows.Forms;
using Curriculum.Domain.Concrete;
using Curriculum.Domain.Entities;

namespace Curriculum.WinUI
{
    public partial class AddDepartment : Form
    {
        private readonly EFDepartment _department;

        public AddDepartment()
        {
            InitializeComponent();
            _department = new EFDepartment();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                //SomeCode

                if(NameDep.Text == "")
                {
                    throw new Exception();
                }
                else
                {
                    var departm = new Department { NameDepartment = NameDep.Text, NumberDepartment = int.Parse(NumDep.Text) };
                    _department.SaveDepartment(departm);
                }
               
            }
            catch
            {
                MessageBox.Show("Невірний формат введених даних. Спробуйте ще.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NumDep_TextChanged(object sender, EventArgs e)
        {
            bool valid = int.TryParse(NumDep.Text, out int ignored);

            if (valid || NumDep.Text == "")
            {
                NumDep.ForeColor = Color.Black;
                label3.Visible = false;
            }
            else
            {
                NumDep.ForeColor = Color.Red;
                label3.Visible = true;
            }
            
        }
    }
}
