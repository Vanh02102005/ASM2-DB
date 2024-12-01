namespace asm1_db
{
    partial class Employee
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbEmployeeManagement = new System.Windows.Forms.TabPage();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txtEmployeeAddress = new System.Windows.Forms.TextBox();
            this.txtEmployeeEmail = new System.Windows.Forms.TextBox();
            this.txtEmployeePhone = new System.Windows.Forms.TextBox();
            this.lbEmployeeAddress = new System.Windows.Forms.Label();
            this.lbEmployeeEmail = new System.Windows.Forms.Label();
            this.lbEmployeePhone = new System.Windows.Forms.Label();
            this.gvEmployee = new System.Windows.Forms.DataGridView();
            this.btnSeach = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPosition = new System.Windows.Forms.Label();
            this.lbEmployeeName = new System.Windows.Forms.Label();
            this.lbEmployeeID = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbEmployeeManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbEmployeeManagement);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1037, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tbEmployeeManagement
            // 
            this.tbEmployeeManagement.Controls.Add(this.btnChangePassword);
            this.tbEmployeeManagement.Controls.Add(this.txtEmployeeAddress);
            this.tbEmployeeManagement.Controls.Add(this.txtEmployeeEmail);
            this.tbEmployeeManagement.Controls.Add(this.txtEmployeePhone);
            this.tbEmployeeManagement.Controls.Add(this.lbEmployeeAddress);
            this.tbEmployeeManagement.Controls.Add(this.lbEmployeeEmail);
            this.tbEmployeeManagement.Controls.Add(this.lbEmployeePhone);
            this.tbEmployeeManagement.Controls.Add(this.gvEmployee);
            this.tbEmployeeManagement.Controls.Add(this.btnSeach);
            this.tbEmployeeManagement.Controls.Add(this.button4);
            this.tbEmployeeManagement.Controls.Add(this.btnDelete);
            this.tbEmployeeManagement.Controls.Add(this.btnEdit);
            this.tbEmployeeManagement.Controls.Add(this.btnAdd);
            this.tbEmployeeManagement.Controls.Add(this.cbPosition);
            this.tbEmployeeManagement.Controls.Add(this.txtPassword);
            this.tbEmployeeManagement.Controls.Add(this.txtUsername);
            this.tbEmployeeManagement.Controls.Add(this.txtEmployeeName);
            this.tbEmployeeManagement.Controls.Add(this.txtEmployeeID);
            this.tbEmployeeManagement.Controls.Add(this.lbPassword);
            this.tbEmployeeManagement.Controls.Add(this.lbUsername);
            this.tbEmployeeManagement.Controls.Add(this.lbPosition);
            this.tbEmployeeManagement.Controls.Add(this.lbEmployeeName);
            this.tbEmployeeManagement.Controls.Add(this.lbEmployeeID);
            this.tbEmployeeManagement.Location = new System.Drawing.Point(4, 25);
            this.tbEmployeeManagement.Name = "tbEmployeeManagement";
            this.tbEmployeeManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tbEmployeeManagement.Size = new System.Drawing.Size(1029, 397);
            this.tbEmployeeManagement.TabIndex = 0;
            this.tbEmployeeManagement.Text = "Employee Management";
            this.tbEmployeeManagement.UseVisualStyleBackColor = true;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(570, 197);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(174, 28);
            this.btnChangePassword.TabIndex = 26;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txtEmployeeAddress
            // 
            this.txtEmployeeAddress.Location = new System.Drawing.Point(141, 141);
            this.txtEmployeeAddress.Name = "txtEmployeeAddress";
            this.txtEmployeeAddress.Size = new System.Drawing.Size(112, 22);
            this.txtEmployeeAddress.TabIndex = 25;
            // 
            // txtEmployeeEmail
            // 
            this.txtEmployeeEmail.Location = new System.Drawing.Point(482, 102);
            this.txtEmployeeEmail.Name = "txtEmployeeEmail";
            this.txtEmployeeEmail.Size = new System.Drawing.Size(112, 22);
            this.txtEmployeeEmail.TabIndex = 24;
            // 
            // txtEmployeePhone
            // 
            this.txtEmployeePhone.Location = new System.Drawing.Point(141, 99);
            this.txtEmployeePhone.Name = "txtEmployeePhone";
            this.txtEmployeePhone.Size = new System.Drawing.Size(112, 22);
            this.txtEmployeePhone.TabIndex = 23;
            // 
            // lbEmployeeAddress
            // 
            this.lbEmployeeAddress.AutoSize = true;
            this.lbEmployeeAddress.Location = new System.Drawing.Point(12, 141);
            this.lbEmployeeAddress.Name = "lbEmployeeAddress";
            this.lbEmployeeAddress.Size = new System.Drawing.Size(123, 16);
            this.lbEmployeeAddress.TabIndex = 22;
            this.lbEmployeeAddress.Text = "Employee Address";
            // 
            // lbEmployeeEmail
            // 
            this.lbEmployeeEmail.AutoSize = true;
            this.lbEmployeeEmail.Location = new System.Drawing.Point(346, 105);
            this.lbEmployeeEmail.Name = "lbEmployeeEmail";
            this.lbEmployeeEmail.Size = new System.Drawing.Size(106, 16);
            this.lbEmployeeEmail.TabIndex = 21;
            this.lbEmployeeEmail.Text = "Employee Email";
            // 
            // lbEmployeePhone
            // 
            this.lbEmployeePhone.AutoSize = true;
            this.lbEmployeePhone.Location = new System.Drawing.Point(12, 102);
            this.lbEmployeePhone.Name = "lbEmployeePhone";
            this.lbEmployeePhone.Size = new System.Drawing.Size(111, 16);
            this.lbEmployeePhone.TabIndex = 20;
            this.lbEmployeePhone.Text = "Employee Phone";
            // 
            // gvEmployee
            // 
            this.gvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEmployee.Location = new System.Drawing.Point(-61, 267);
            this.gvEmployee.Name = "gvEmployee";
            this.gvEmployee.RowHeadersWidth = 51;
            this.gvEmployee.RowTemplate.Height = 24;
            this.gvEmployee.Size = new System.Drawing.Size(1498, 155);
            this.gvEmployee.TabIndex = 19;
            // 
            // btnSeach
            // 
            this.btnSeach.Location = new System.Drawing.Point(466, 197);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(75, 28);
            this.btnSeach.TabIndex = 18;
            this.btnSeach.Text = "Seach";
            this.btnSeach.UseVisualStyleBackColor = true;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(630, 297);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(8, 8);
            this.button4.TabIndex = 17;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(326, 197);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 28);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(178, 199);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 28);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(48, 202);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "Admin",
            "Sales",
            "Warehouse"});
            this.cbPosition.Location = new System.Drawing.Point(482, 139);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(112, 24);
            this.cbPosition.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(482, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(111, 22);
            this.txtPassword.TabIndex = 10;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(482, 27);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(112, 22);
            this.txtUsername.TabIndex = 9;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(141, 62);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(109, 22);
            this.txtEmployeeName.TabIndex = 8;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(141, 21);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(112, 22);
            this.txtEmployeeID.TabIndex = 7;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(346, 68);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(67, 16);
            this.lbPassword.TabIndex = 6;
            this.lbPassword.Text = "Password";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(343, 27);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(70, 16);
            this.lbUsername.TabIndex = 5;
            this.lbUsername.Text = "Username";
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Location = new System.Drawing.Point(346, 147);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(55, 16);
            this.lbPosition.TabIndex = 2;
            this.lbPosition.Text = "Position";
            // 
            // lbEmployeeName
            // 
            this.lbEmployeeName.AutoSize = true;
            this.lbEmployeeName.Location = new System.Drawing.Point(12, 65);
            this.lbEmployeeName.Name = "lbEmployeeName";
            this.lbEmployeeName.Size = new System.Drawing.Size(109, 16);
            this.lbEmployeeName.TabIndex = 1;
            this.lbEmployeeName.Text = "Employee Name";
            // 
            // lbEmployeeID
            // 
            this.lbEmployeeID.AutoSize = true;
            this.lbEmployeeID.Location = new System.Drawing.Point(12, 27);
            this.lbEmployeeID.Name = "lbEmployeeID";
            this.lbEmployeeID.Size = new System.Drawing.Size(85, 16);
            this.lbEmployeeID.TabIndex = 0;
            this.lbEmployeeID.Text = "Employee ID";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 576);
            this.Controls.Add(this.tabControl1);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbEmployeeManagement.ResumeLayout(false);
            this.tbEmployeeManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbEmployeeManagement;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.Label lbEmployeeName;
        private System.Windows.Forms.Label lbEmployeeID;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.DataGridView gvEmployee;
        private System.Windows.Forms.Label lbEmployeeAddress;
        private System.Windows.Forms.Label lbEmployeeEmail;
        private System.Windows.Forms.Label lbEmployeePhone;
        private System.Windows.Forms.TextBox txtEmployeeAddress;
        private System.Windows.Forms.TextBox txtEmployeeEmail;
        private System.Windows.Forms.TextBox txtEmployeePhone;
        private System.Windows.Forms.Button btnChangePassword;
    }
}