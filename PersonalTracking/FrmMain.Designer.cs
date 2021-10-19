
namespace PersonalTracking
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.salaryBtn = new System.Windows.Forms.Button();
            this.taskBtn = new System.Windows.Forms.Button();
            this.positionBtn = new System.Windows.Forms.Button();
            this.employeeBtn = new System.Windows.Forms.Button();
            this.permissionBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.departmentBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salaryBtn
            // 
            this.salaryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryBtn.Image = ((System.Drawing.Image)(resources.GetObject("salaryBtn.Image")));
            this.salaryBtn.Location = new System.Drawing.Point(502, 35);
            this.salaryBtn.Name = "salaryBtn";
            this.salaryBtn.Size = new System.Drawing.Size(195, 155);
            this.salaryBtn.TabIndex = 2;
            this.salaryBtn.Text = "Salary";
            this.salaryBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.salaryBtn.UseVisualStyleBackColor = true;
            this.salaryBtn.Click += new System.EventHandler(this.salaryBtn_Click);
            // 
            // taskBtn
            // 
            this.taskBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskBtn.Image = ((System.Drawing.Image)(resources.GetObject("taskBtn.Image")));
            this.taskBtn.Location = new System.Drawing.Point(273, 35);
            this.taskBtn.Name = "taskBtn";
            this.taskBtn.Size = new System.Drawing.Size(195, 155);
            this.taskBtn.TabIndex = 1;
            this.taskBtn.Text = "Task";
            this.taskBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.taskBtn.UseVisualStyleBackColor = true;
            this.taskBtn.Click += new System.EventHandler(this.taskBtn_Click);
            // 
            // positionBtn
            // 
            this.positionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionBtn.Image = ((System.Drawing.Image)(resources.GetObject("positionBtn.Image")));
            this.positionBtn.Location = new System.Drawing.Point(502, 238);
            this.positionBtn.Name = "positionBtn";
            this.positionBtn.Size = new System.Drawing.Size(195, 155);
            this.positionBtn.TabIndex = 5;
            this.positionBtn.Text = "Position";
            this.positionBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.positionBtn.UseVisualStyleBackColor = true;
            this.positionBtn.Click += new System.EventHandler(this.positionBtn_Click);
            // 
            // employeeBtn
            // 
            this.employeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeBtn.Image = ((System.Drawing.Image)(resources.GetObject("employeeBtn.Image")));
            this.employeeBtn.Location = new System.Drawing.Point(51, 35);
            this.employeeBtn.Name = "employeeBtn";
            this.employeeBtn.Size = new System.Drawing.Size(195, 155);
            this.employeeBtn.TabIndex = 0;
            this.employeeBtn.Text = "Employee";
            this.employeeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.employeeBtn.UseVisualStyleBackColor = true;
            this.employeeBtn.Click += new System.EventHandler(this.employeeBtn_Click);
            // 
            // permissionBtn
            // 
            this.permissionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permissionBtn.Image = ((System.Drawing.Image)(resources.GetObject("permissionBtn.Image")));
            this.permissionBtn.Location = new System.Drawing.Point(51, 238);
            this.permissionBtn.Name = "permissionBtn";
            this.permissionBtn.Size = new System.Drawing.Size(195, 155);
            this.permissionBtn.TabIndex = 3;
            this.permissionBtn.Text = "Permission";
            this.permissionBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.permissionBtn.UseVisualStyleBackColor = true;
            this.permissionBtn.Click += new System.EventHandler(this.permissionBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.Location = new System.Drawing.Point(160, 417);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(195, 155);
            this.logoutBtn.TabIndex = 6;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // departmentBtn
            // 
            this.departmentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentBtn.Image = ((System.Drawing.Image)(resources.GetObject("departmentBtn.Image")));
            this.departmentBtn.Location = new System.Drawing.Point(273, 238);
            this.departmentBtn.Name = "departmentBtn";
            this.departmentBtn.Size = new System.Drawing.Size(195, 155);
            this.departmentBtn.TabIndex = 4;
            this.departmentBtn.Text = "Department";
            this.departmentBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.departmentBtn.UseVisualStyleBackColor = true;
            this.departmentBtn.Click += new System.EventHandler(this.departmentBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.Location = new System.Drawing.Point(404, 417);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(195, 155);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 584);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.departmentBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.permissionBtn);
            this.Controls.Add(this.employeeBtn);
            this.Controls.Add(this.positionBtn);
            this.Controls.Add(this.taskBtn);
            this.Controls.Add(this.salaryBtn);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button salaryBtn;
        private System.Windows.Forms.Button taskBtn;
        private System.Windows.Forms.Button positionBtn;
        private System.Windows.Forms.Button employeeBtn;
        private System.Windows.Forms.Button permissionBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button departmentBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}