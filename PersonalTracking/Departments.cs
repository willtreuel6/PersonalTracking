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

namespace PersonalTracking
{
    public partial class Departments : Form
    {
        public Departments()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (departmentTxt.Text.Equals(""))
            {
                MessageBox.Show("Department field cannot be blank.");
            }
            else
            {
                DEPARTMENT department = new DEPARTMENT();
                department.DepartmentName = departmentTxt.Text;
                BLL.DepartmentBLL.AddDepartment(department);
                MessageBox.Show("Department was added");
                departmentTxt.Clear();
            }
        }
    }
}
