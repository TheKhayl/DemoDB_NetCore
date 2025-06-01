namespace DemoDB_NetCore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            txtboxName = new TextBox();
            btnAdd = new Button();
            lblEmail = new Label();
            txtboxEmail = new TextBox();
            lblAddress = new Label();
            txtboxAddress = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvEmployee = new DataGridView();
            dgEmployeeID = new DataGridViewTextBoxColumn();
            dgEmployeeName = new DataGridViewTextBoxColumn();
            dgEmployeeEmail = new DataGridViewTextBoxColumn();
            dgEmployeeAddress = new DataGridViewTextBoxColumn();
            btnDeselect = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.Location = new Point(37, 48);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 28);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // txtboxName
            // 
            txtboxName.Location = new Point(127, 48);
            txtboxName.Name = "txtboxName";
            txtboxName.Size = new Size(275, 31);
            txtboxName.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(441, 131);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(124, 54);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.Location = new Point(37, 95);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 28);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            // 
            // txtboxEmail
            // 
            txtboxEmail.Location = new Point(127, 95);
            txtboxEmail.Name = "txtboxEmail";
            txtboxEmail.Size = new Size(275, 31);
            txtboxEmail.TabIndex = 1;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 10F);
            lblAddress.Location = new Point(37, 143);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(82, 28);
            lblAddress.TabIndex = 0;
            lblAddress.Text = "Address";
            // 
            // txtboxAddress
            // 
            txtboxAddress.Location = new Point(127, 143);
            txtboxAddress.Name = "txtboxAddress";
            txtboxAddress.Size = new Size(275, 31);
            txtboxAddress.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(580, 131);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(124, 54);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(722, 131);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(124, 54);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(441, 59);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(124, 54);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvEmployee
            // 
            dgvEmployee.AllowUserToAddRows = false;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Columns.AddRange(new DataGridViewColumn[] { dgEmployeeID, dgEmployeeName, dgEmployeeEmail, dgEmployeeAddress });
            dgvEmployee.Location = new Point(39, 206);
            dgvEmployee.MultiSelect = false;
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.ReadOnly = true;
            dgvEmployee.RowHeadersWidth = 62;
            dgvEmployee.Size = new Size(1185, 444);
            dgvEmployee.TabIndex = 3;
            dgvEmployee.DoubleClick += dgvEmployee_DoubleClick;
            // 
            // dgEmployeeID
            // 
            dgEmployeeID.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgEmployeeID.DataPropertyName = "EmployeeID";
            dgEmployeeID.HeaderText = "EmployeeID";
            dgEmployeeID.MinimumWidth = 8;
            dgEmployeeID.Name = "dgEmployeeID";
            dgEmployeeID.ReadOnly = true;
            dgEmployeeID.Width = 144;
            // 
            // dgEmployeeName
            // 
            dgEmployeeName.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgEmployeeName.DataPropertyName = "Name";
            dgEmployeeName.HeaderText = "Name";
            dgEmployeeName.MinimumWidth = 8;
            dgEmployeeName.Name = "dgEmployeeName";
            dgEmployeeName.ReadOnly = true;
            dgEmployeeName.Width = 95;
            // 
            // dgEmployeeEmail
            // 
            dgEmployeeEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgEmployeeEmail.DataPropertyName = "Email";
            dgEmployeeEmail.HeaderText = "Email";
            dgEmployeeEmail.MinimumWidth = 8;
            dgEmployeeEmail.Name = "dgEmployeeEmail";
            dgEmployeeEmail.ReadOnly = true;
            dgEmployeeEmail.Width = 90;
            // 
            // dgEmployeeAddress
            // 
            dgEmployeeAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgEmployeeAddress.DataPropertyName = "Address";
            dgEmployeeAddress.HeaderText = "Address";
            dgEmployeeAddress.MinimumWidth = 8;
            dgEmployeeAddress.Name = "dgEmployeeAddress";
            dgEmployeeAddress.ReadOnly = true;
            dgEmployeeAddress.Width = 113;
            // 
            // btnDeselect
            // 
            btnDeselect.Location = new Point(580, 59);
            btnDeselect.Name = "btnDeselect";
            btnDeselect.Size = new Size(124, 54);
            btnDeselect.TabIndex = 2;
            btnDeselect.Text = "Deselect";
            btnDeselect.UseVisualStyleBackColor = true;
            btnDeselect.Click += btnDeselect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 684);
            Controls.Add(dgvEmployee);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnDeselect);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txtboxAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtboxEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtboxName);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Sample Winforms with CRUD Using Code-First";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtboxName;
        private Button btnAdd;
        private Label lblEmail;
        private TextBox txtboxEmail;
        private Label lblAddress;
        private TextBox txtboxAddress;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvEmployee;
        private DataGridViewTextBoxColumn dgEmployeeID;
        private DataGridViewTextBoxColumn dgEmployeeName;
        private DataGridViewTextBoxColumn dgEmployeeEmail;
        private DataGridViewTextBoxColumn dgEmployeeAddress;
        private Button btnDeselect;
    }
}
