namespace IA04
{
    partial class MainView
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
            this.dgv_companies = new System.Windows.Forms.DataGridView();
            this.dgv_divisions = new System.Windows.Forms.DataGridView();
            this.dgv_projects = new System.Windows.Forms.DataGridView();
            this.dgv_departments = new System.Windows.Forms.DataGridView();
            this.dgv_employees = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_companies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_divisions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_projects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_departments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employees)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_companies
            // 
            this.dgv_companies.AllowUserToAddRows = false;
            this.dgv_companies.AllowUserToDeleteRows = false;
            this.dgv_companies.AllowUserToResizeColumns = false;
            this.dgv_companies.AllowUserToResizeRows = false;
            this.dgv_companies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_companies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_companies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnCode});
            this.dgv_companies.Location = new System.Drawing.Point(12, 51);
            this.dgv_companies.MultiSelect = false;
            this.dgv_companies.Name = "dgv_companies";
            this.dgv_companies.ReadOnly = true;
            this.dgv_companies.RowHeadersVisible = false;
            this.dgv_companies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_companies.Size = new System.Drawing.Size(230, 407);
            this.dgv_companies.TabIndex = 0;
            this.dgv_companies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_companies_CellClick);
            // 
            // dgv_divisions
            // 
            this.dgv_divisions.AllowUserToAddRows = false;
            this.dgv_divisions.AllowUserToDeleteRows = false;
            this.dgv_divisions.AllowUserToResizeColumns = false;
            this.dgv_divisions.AllowUserToResizeRows = false;
            this.dgv_divisions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_divisions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_divisions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgv_divisions.Location = new System.Drawing.Point(248, 51);
            this.dgv_divisions.MultiSelect = false;
            this.dgv_divisions.Name = "dgv_divisions";
            this.dgv_divisions.ReadOnly = true;
            this.dgv_divisions.RowHeadersVisible = false;
            this.dgv_divisions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_divisions.Size = new System.Drawing.Size(230, 407);
            this.dgv_divisions.TabIndex = 0;
            this.dgv_divisions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_divisions_CellClick);
            // 
            // dgv_projects
            // 
            this.dgv_projects.AllowUserToAddRows = false;
            this.dgv_projects.AllowUserToDeleteRows = false;
            this.dgv_projects.AllowUserToResizeColumns = false;
            this.dgv_projects.AllowUserToResizeRows = false;
            this.dgv_projects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_projects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgv_projects.Location = new System.Drawing.Point(484, 51);
            this.dgv_projects.MultiSelect = false;
            this.dgv_projects.Name = "dgv_projects";
            this.dgv_projects.ReadOnly = true;
            this.dgv_projects.RowHeadersVisible = false;
            this.dgv_projects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_projects.Size = new System.Drawing.Size(230, 407);
            this.dgv_projects.TabIndex = 0;
            this.dgv_projects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_projects_CellClick);
            // 
            // dgv_departments
            // 
            this.dgv_departments.AllowUserToAddRows = false;
            this.dgv_departments.AllowUserToDeleteRows = false;
            this.dgv_departments.AllowUserToResizeColumns = false;
            this.dgv_departments.AllowUserToResizeRows = false;
            this.dgv_departments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_departments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_departments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgv_departments.Location = new System.Drawing.Point(720, 51);
            this.dgv_departments.MultiSelect = false;
            this.dgv_departments.Name = "dgv_departments";
            this.dgv_departments.ReadOnly = true;
            this.dgv_departments.RowHeadersVisible = false;
            this.dgv_departments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_departments.Size = new System.Drawing.Size(230, 407);
            this.dgv_departments.TabIndex = 0;
            this.dgv_departments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_departments_CellClick);
            // 
            // dgv_employees
            // 
            this.dgv_employees.AllowUserToAddRows = false;
            this.dgv_employees.AllowUserToDeleteRows = false;
            this.dgv_employees.AllowUserToResizeColumns = false;
            this.dgv_employees.AllowUserToResizeRows = false;
            this.dgv_employees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFirstName,
            this.ColumnLastName});
            this.dgv_employees.Location = new System.Drawing.Point(956, 51);
            this.dgv_employees.MultiSelect = false;
            this.dgv_employees.Name = "dgv_employees";
            this.dgv_employees.ReadOnly = true;
            this.dgv_employees.RowHeadersVisible = false;
            this.dgv_employees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_employees.Size = new System.Drawing.Size(230, 407);
            this.dgv_employees.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Division";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Project";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(717, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(953, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Employees";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 60F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Code";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 60F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Code";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 60F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Code";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnFirstName
            // 
            this.ColumnFirstName.HeaderText = "First Name";
            this.ColumnFirstName.Name = "ColumnFirstName";
            this.ColumnFirstName.ReadOnly = true;
            this.ColumnFirstName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnLastName
            // 
            this.ColumnLastName.FillWeight = 130F;
            this.ColumnLastName.HeaderText = "Last Name";
            this.ColumnLastName.Name = "ColumnLastName";
            this.ColumnLastName.ReadOnly = true;
            this.ColumnLastName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnCode
            // 
            this.ColumnCode.FillWeight = 60F;
            this.ColumnCode.HeaderText = "Code";
            this.ColumnCode.Name = "ColumnCode";
            this.ColumnCode.ReadOnly = true;
            this.ColumnCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 615);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_employees);
            this.Controls.Add(this.dgv_departments);
            this.Controls.Add(this.dgv_projects);
            this.Controls.Add(this.dgv_divisions);
            this.Controls.Add(this.dgv_companies);
            this.Name = "MainView";
            this.Text = "MainView";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_companies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_divisions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_projects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_departments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_companies;
        private System.Windows.Forms.DataGridView dgv_divisions;
        private System.Windows.Forms.DataGridView dgv_projects;
        private System.Windows.Forms.DataGridView dgv_departments;
        private System.Windows.Forms.DataGridView dgv_employees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLastName;
    }
}

