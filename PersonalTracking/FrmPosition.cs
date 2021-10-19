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
    public partial class FrmPosition : Form
    {
        public FrmPosition()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        List<DEPARTMENT> departmentList = new List<DEPARTMENT>();
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (txtPosition.Text.Equals(""))
                MessageBox.Show("You must enter a position.");
            else if (departmentCMB.SelectedIndex == -1)
                MessageBox.Show("Please Select a department");
            else
            {
                POSITION position = new POSITION();
                position.PositionName = txtPosition.Text;
                position.DepartmentID = Convert.ToInt32(departmentCMB.SelectedValue);
                BLL.PositionBLL.AddPosition(position);
                MessageBox.Show("Position was added!");
                txtPosition.Clear();
                departmentCMB.SelectedIndex = -1;
            }
        }



        private void FrmPosition_Load(object sender, EventArgs e)
        {
            departmentList = DepartmentBLL.GetDepartments();
            departmentCMB.DataSource = departmentList;
            departmentCMB.DisplayMember = "DepartmentName";
            departmentCMB.ValueMember = "DepartmentID";
            departmentCMB.SelectedIndex = -1;

        }

        private void departmentCMB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPosition_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
