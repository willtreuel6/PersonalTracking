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

namespace PersonalTracking
{
    public partial class FrmEmployeeList : Form
    {
        public FrmEmployeeList()
        {
            InitializeComponent();
        }

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            FrmEmployee frm = new FrmEmployee();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            FrmEmployee frm = new FrmEmployee();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
        EmployeeDTO dto = new EmployeeDTO();
        private bool comboFull = false;

        private void FrmEmployeeList_Load(object sender, EventArgs e)
        {
            dto = EmployeeBLL.GetAll();
            dataGridView1.DataSource = dto.Employees;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "User No";
            dataGridView1.Columns[2].HeaderText = "Name";
            dataGridView1.Columns[3].HeaderText = "Surname";
            dataGridView1.Columns[4].HeaderText = "Department";
            dataGridView1.Columns[5].HeaderText = "Position";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].HeaderText = "Salary";
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            //dataGridView1.Columns[13].Visible = false;
            comboFull = false;
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

        private void departmentCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFull)
            {
                positionCMB.DataSource = dto.Positions.Where(x => x.DepartmentID ==
                Convert.ToInt32(departmentCMB.SelectedValue)).ToList();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            List<EmployeeDetailDTO> list = dto.Employees;
            if (txtUserNo.Text.Trim() != "")
                list = list.Where(x => x.UserNo == Convert.ToInt32(txtUserNo.Text)).ToList();
            if (nameTxt.Text.Trim() != "")
                list = list.Where(x => x.Name.Contains(nameTxt.Text)).ToList();
            if (surnameTxt.Text.Trim() != "")
                list = list.Where(x => x.SurName.Contains(surnameTxt.Text)).ToList();
            if (departmentCMB.SelectedIndex != -1)
                list = list.Where(x => x.DepartmentID == Convert.ToInt32(departmentCMB.SelectedValue)).ToList();
            if (positionCMB.SelectedIndex != -1)
                list = list.Where(x => x.PositionID == Convert.ToInt32(positionCMB.SelectedValue)).ToList();
            dataGridView1.DataSource = list;

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtUserNo.Clear();
            nameTxt.Clear();
            surnameTxt.Clear();
            comboFull = false;
            departmentCMB.SelectedIndex = -1;
            positionCMB.SelectedIndex = -1;
            positionCMB.DataSource = dto.Positions;
            comboFull = true;
            dataGridView1.DataSource = dto.Employees;
        }
    }
}
