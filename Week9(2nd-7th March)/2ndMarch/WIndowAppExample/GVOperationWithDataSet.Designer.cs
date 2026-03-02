namespace WIndowAppExample
{
    partial class GVOperationWithDataSet
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
            btn_Insert = new Button();
            txtEmpId = new TextBox();
            empid_label = new Label();
            EmpName_label = new Label();
            txtEmpName = new TextBox();
            txtEmpDesig = new TextBox();
            btnClear = new Button();
            deptno_label = new Label();
            salary_label = new Label();
            designation_label = new Label();
            DOJ_label = new Label();
            txtEmpDOJ = new TextBox();
            txtEmpSal = new TextBox();
            txtDeptNo = new TextBox();
            btn_Find = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClose = new Button();
            btnUpdateDB = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_Insert
            // 
            btn_Insert.BackColor = SystemColors.ActiveCaption;
            btn_Insert.Location = new Point(170, 504);
            btn_Insert.Name = "btn_Insert";
            btn_Insert.Size = new Size(142, 66);
            btn_Insert.TabIndex = 0;
            btn_Insert.Text = "Insert";
            btn_Insert.UseVisualStyleBackColor = false;
            btn_Insert.Click += button1_Click;
            // 
            // txtEmpId
            // 
            txtEmpId.Location = new Point(376, 50);
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(347, 39);
            txtEmpId.TabIndex = 1;
            // 
            // empid_label
            // 
            empid_label.AutoSize = true;
            empid_label.Location = new Point(69, 50);
            empid_label.Name = "empid_label";
            empid_label.Size = new Size(143, 32);
            empid_label.TabIndex = 2;
            empid_label.Text = "Enter EmpId";
            empid_label.Click += name_Click;
            // 
            // EmpName_label
            // 
            EmpName_label.AutoSize = true;
            EmpName_label.Location = new Point(69, 114);
            EmpName_label.Name = "EmpName_label";
            EmpName_label.Size = new Size(187, 32);
            EmpName_label.TabIndex = 3;
            EmpName_label.Text = "Enter EmpName";
            EmpName_label.Click += label2_Click;
            // 
            // txtEmpName
            // 
            txtEmpName.Location = new Point(376, 114);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(347, 39);
            txtEmpName.TabIndex = 4;
            txtEmpName.TextChanged += textBox2_TextChanged;
            // 
            // txtEmpDesig
            // 
            txtEmpDesig.Location = new Point(376, 182);
            txtEmpDesig.Name = "txtEmpDesig";
            txtEmpDesig.Size = new Size(347, 39);
            txtEmpDesig.TabIndex = 5;
            txtEmpDesig.TextChanged += textBox3_TextChanged;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ActiveCaption;
            btnClear.Location = new Point(534, 506);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(148, 64);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += button1_Click_1;
            // 
            // deptno_label
            // 
            deptno_label.AutoSize = true;
            deptno_label.Location = new Point(69, 386);
            deptno_label.Name = "deptno_label";
            deptno_label.Size = new Size(164, 32);
            deptno_label.TabIndex = 7;
            deptno_label.Text = "Enter DeptNO";
            // 
            // salary_label
            // 
            salary_label.AutoSize = true;
            salary_label.Location = new Point(69, 324);
            salary_label.Name = "salary_label";
            salary_label.Size = new Size(139, 32);
            salary_label.TabIndex = 8;
            salary_label.Text = "Enter Salary";
            salary_label.Click += salary_label_Click;
            // 
            // designation_label
            // 
            designation_label.AutoSize = true;
            designation_label.Location = new Point(69, 182);
            designation_label.Name = "designation_label";
            designation_label.Size = new Size(204, 32);
            designation_label.TabIndex = 9;
            designation_label.Text = "Enter Designation";
            // 
            // DOJ_label
            // 
            DOJ_label.AutoSize = true;
            DOJ_label.Location = new Point(69, 256);
            DOJ_label.Name = "DOJ_label";
            DOJ_label.Size = new Size(120, 32);
            DOJ_label.TabIndex = 10;
            DOJ_label.Text = "Enter DOJ";
            // 
            // txtEmpDOJ
            // 
            txtEmpDOJ.Location = new Point(376, 256);
            txtEmpDOJ.Name = "txtEmpDOJ";
            txtEmpDOJ.Size = new Size(347, 39);
            txtEmpDOJ.TabIndex = 11;
            // 
            // txtEmpSal
            // 
            txtEmpSal.Location = new Point(376, 324);
            txtEmpSal.Name = "txtEmpSal";
            txtEmpSal.Size = new Size(347, 39);
            txtEmpSal.TabIndex = 12;
            // 
            // txtDeptNo
            // 
            txtDeptNo.Location = new Point(376, 386);
            txtDeptNo.Name = "txtDeptNo";
            txtDeptNo.Size = new Size(347, 39);
            txtDeptNo.TabIndex = 13;
            // 
            // btn_Find
            // 
            btn_Find.BackColor = SystemColors.ActiveCaption;
            btn_Find.Location = new Point(308, 504);
            btn_Find.Name = "btn_Find";
            btn_Find.Size = new Size(142, 66);
            btn_Find.TabIndex = 14;
            btn_Find.Text = "Find";
            btn_Find.UseVisualStyleBackColor = false;
            btn_Find.Click += btn_Find_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ActiveCaption;
            btnDelete.Location = new Point(308, 567);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(142, 66);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveCaption;
            btnUpdate.Location = new Point(170, 567);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(142, 66);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btn_Update_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ActiveCaption;
            btnClose.Location = new Point(534, 567);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(148, 64);
            btnClose.TabIndex = 17;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnUpdateDB
            // 
            btnUpdateDB.BackColor = SystemColors.ActiveCaption;
            btnUpdateDB.Location = new Point(865, 550);
            btnUpdateDB.Name = "btnUpdateDB";
            btnUpdateDB.Size = new Size(267, 65);
            btnUpdateDB.TabIndex = 18;
            btnUpdateDB.Text = "Update Into DataBase";
            btnUpdateDB.UseVisualStyleBackColor = false;
            btnUpdateDB.Click += btnUpdateDB_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(813, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(628, 362);
            dataGridView1.TabIndex = 19;
            // 
            // GVOperationWithDataSet
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 698);
            Controls.Add(dataGridView1);
            Controls.Add(btnUpdateDB);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btn_Find);
            Controls.Add(txtDeptNo);
            Controls.Add(txtEmpSal);
            Controls.Add(txtEmpDOJ);
            Controls.Add(DOJ_label);
            Controls.Add(designation_label);
            Controls.Add(salary_label);
            Controls.Add(deptno_label);
            Controls.Add(btnClear);
            Controls.Add(txtEmpDesig);
            Controls.Add(txtEmpName);
            Controls.Add(EmpName_label);
            Controls.Add(empid_label);
            Controls.Add(txtEmpId);
            Controls.Add(btn_Insert);
            Name = "GVOperationWithDataSet";
            Text = "GVOperationWithDataSet";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Insert;
        private TextBox txtEmpId;
        private Label empid_label;
        private Label EmpName_label;
        private TextBox txtEmpName;
        private TextBox txtEmpDesig;
        private Button btnClear;
        private Label deptno_label;
        private Label salary_label;
        private Label designation_label;
        private Label DOJ_label;
        private TextBox txtEmpDOJ;
        private TextBox txtEmpSal;
        private TextBox txtDeptNo;
        private Button btn_Find;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClose;
        private Button btnUpdateDB;
        private DataGridView dataGridView1;
    }
}
