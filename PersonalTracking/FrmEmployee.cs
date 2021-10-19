using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DAL.DTO;
using System.IO;



namespace PersonalTracking
{
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void txtUserNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();       
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }
        EmployeeDTO dto = new EmployeeDTO();
        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            dto = EmployeeBLL.GetAll();
            departmentCMB.DataSource = dto.Departments;
            departmentCMB.DisplayMember = "DepartmentName";
            departmentCMB.ValueMember = "DepartmentID";
            positionCMB.DataSource = dto.Positions;
            positionCMB.DisplayMember = "PositionName";
            positionCMB.ValueMember = "PositionID";
            departmentCMB.SelectedIndex = -1;
            positionCMB.SelectedIndex = -1;
            comboFull = true;
        }
        bool comboFull = false;
        private void departmentCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFull)
            {
                int departmentID = Convert.ToInt32(departmentCMB.SelectedValue);
                positionCMB.DataSource = dto.Positions.Where(x => x.DepartmentID == departmentID).ToList();
            }
        }
        string fileName = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                pictureBox1.Load(openFileDialog1.FileName);
                imagepathTxt.Text = openFileDialog1.FileName;
                string unique = Guid.NewGuid().ToString();
                fileName = unique + openFileDialog1.SafeFileName;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (txtUserNo.Text.Trim() == "")
                MessageBox.Show("User No. is empty");
            else if (!EmployeeBLL.isUnique(Convert.ToInt32(txtUserNo.Text)))
                MessageBox.Show("This user No. is used by another employee. Please change");
            else if (txtPassword.Text.Trim() == "")
                MessageBox.Show("Password is empty");
            else if (nameTxt.Text.Trim() == "")
                MessageBox.Show("Name is empty");
            else if (surnameTxt.Text.Trim() == "")
                MessageBox.Show("Surname is empty");
            else if (salaryTxt.Text.Trim() == "")
                MessageBox.Show("Salary is empty");
            else if (departmentCMB.SelectedIndex == -1)
                MessageBox.Show("You must select a department");
            else if (positionCMB.SelectedIndex == -1)
                MessageBox.Show("You must select a position");
            else
            {
                EMPLOYEE employee = new EMPLOYEE();
                employee.EmployeeUserNo = Convert.ToInt32(txtUserNo.Text);
                employee.Password = txtPassword.Text;
                employee.Name = nameTxt.Text;
                employee.SurName = surnameTxt.Text;
                employee.Salary = Convert.ToInt32(txtSalary.Text);
                employee.DepartmentID = Convert.ToInt32(departmentCMB.SelectedValue);
                employee.PositionID = Convert.ToInt32(positionCMB.SelectedValue);
                employee.Address = addressTxt.Text;
                employee.BirthDay = dateTimePicker1.Value;
                employee.ImagePath = fileName;
                EmployeeBLL.AddEmployee(employee);
                File.Copy(imagepathTxt.Text, @"images\" + fileName);
                MessageBox.Show("Employee was added!");
                txtUserNo.Clear();
                txtPassword.Clear();
                nameTxt.Clear();
                surnameTxt.Clear();
                txtSalary.Clear();
                departmentCMB.SelectedIndex = -1;
                positionCMB.SelectedIndex = -1;
                positionCMB.DataSource = dto.Positions;
                addressTxt.Clear();
                dateTimePicker1.Value = DateTime.Today;
                adminCB.Checked = false;
                imagepathTxt.Clear();
                pictureBox1.Image = null;
                comboFull = false;
            }
        }
        bool isUnique = false;
        private void checkBtn_Click(object sender, EventArgs e)
        {
            if (txtUserNo.Text.Trim() == "")
                MessageBox.Show("User No. is empty");
            else
            {
                isUnique = EmployeeBLL.isUnique(Convert.ToInt32(txtUserNo.Text));
                if (!isUnique)
                    MessageBox.Show("User No. is used by another employee. Please enter a different number");
                else
                    MessageBox.Show("This User No. is usable");
            }
        }
    }
}
