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
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_company_edit = new System.Windows.Forms.Button();
            this.btn_company_show = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_CompanyDirector = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_ProjectDirector = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_DivisionDirector = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_DepartmentHead = new System.Windows.Forms.Label();
            this.btn_division_edit = new System.Windows.Forms.Button();
            this.btn_division_show = new System.Windows.Forms.Button();
            this.btn_project_edit = new System.Windows.Forms.Button();
            this.btn_project_show = new System.Windows.Forms.Button();
            this.btn_department_edit = new System.Windows.Forms.Button();
            this.btn_department_show = new System.Windows.Forms.Button();
            this.btn_employee_edit = new System.Windows.Forms.Button();
            this.btn_employee_show = new System.Windows.Forms.Button();
            this.btn_employee_fire = new System.Windows.Forms.Button();
            this.btn_employee_hire = new System.Windows.Forms.Button();
            this.btn_company_setLead = new System.Windows.Forms.Button();
            this.btn_division_setLead = new System.Windows.Forms.Button();
            this.btn_project_setLead = new System.Windows.Forms.Button();
            this.btn_department_setLead = new System.Windows.Forms.Button();
            this.dgv_divisions = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_projects = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_departments = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_employees = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_company_remove = new System.Windows.Forms.Button();
            this.btn_company_add = new System.Windows.Forms.Button();
            this.btn_division_remove = new System.Windows.Forms.Button();
            this.btn_division_add = new System.Windows.Forms.Button();
            this.btn_project_remove = new System.Windows.Forms.Button();
            this.btn_project_add = new System.Windows.Forms.Button();
            this.btn_department_remove = new System.Windows.Forms.Button();
            this.btn_department_add = new System.Windows.Forms.Button();
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
            this.ColumnID,
            this.ColumnName,
            this.ColumnCode});
            this.dgv_companies.Location = new System.Drawing.Point(12, 25);
            this.dgv_companies.MultiSelect = false;
            this.dgv_companies.Name = "dgv_companies";
            this.dgv_companies.ReadOnly = true;
            this.dgv_companies.RowHeadersVisible = false;
            this.dgv_companies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_companies.Size = new System.Drawing.Size(230, 407);
            this.dgv_companies.TabIndex = 0;
            this.dgv_companies.SelectionChanged += new System.EventHandler(this.dgv_companies_SelectionChanged);
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Visible = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Division";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Project";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(717, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(953, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Employees";
            // 
            // btn_company_edit
            // 
            this.btn_company_edit.Location = new System.Drawing.Point(12, 467);
            this.btn_company_edit.Name = "btn_company_edit";
            this.btn_company_edit.Size = new System.Drawing.Size(114, 23);
            this.btn_company_edit.TabIndex = 2;
            this.btn_company_edit.Text = "Edit Company";
            this.btn_company_edit.UseVisualStyleBackColor = true;
            // 
            // btn_company_show
            // 
            this.btn_company_show.Location = new System.Drawing.Point(12, 438);
            this.btn_company_show.Name = "btn_company_show";
            this.btn_company_show.Size = new System.Drawing.Size(114, 23);
            this.btn_company_show.TabIndex = 2;
            this.btn_company_show.Text = "Company Details";
            this.btn_company_show.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 506);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Director";
            // 
            // lbl_CompanyDirector
            // 
            this.lbl_CompanyDirector.AutoSize = true;
            this.lbl_CompanyDirector.Location = new System.Drawing.Point(38, 519);
            this.lbl_CompanyDirector.Name = "lbl_CompanyDirector";
            this.lbl_CompanyDirector.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_CompanyDirector.Size = new System.Drawing.Size(88, 13);
            this.lbl_CompanyDirector.TabIndex = 4;
            this.lbl_CompanyDirector.Text = "company director";
            this.lbl_CompanyDirector.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(481, 506);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Project Lead";
            // 
            // lbl_ProjectDirector
            // 
            this.lbl_ProjectDirector.AutoSize = true;
            this.lbl_ProjectDirector.Location = new System.Drawing.Point(507, 519);
            this.lbl_ProjectDirector.Name = "lbl_ProjectDirector";
            this.lbl_ProjectDirector.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_ProjectDirector.Size = new System.Drawing.Size(71, 13);
            this.lbl_ProjectDirector.TabIndex = 4;
            this.lbl_ProjectDirector.Text = "project leader";
            this.lbl_ProjectDirector.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 506);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Division director";
            // 
            // lbl_DivisionDirector
            // 
            this.lbl_DivisionDirector.AutoSize = true;
            this.lbl_DivisionDirector.Location = new System.Drawing.Point(271, 519);
            this.lbl_DivisionDirector.Name = "lbl_DivisionDirector";
            this.lbl_DivisionDirector.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_DivisionDirector.Size = new System.Drawing.Size(80, 13);
            this.lbl_DivisionDirector.TabIndex = 4;
            this.lbl_DivisionDirector.Text = "division director";
            this.lbl_DivisionDirector.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(717, 506);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Department Head";
            // 
            // lbl_DepartmentHead
            // 
            this.lbl_DepartmentHead.AutoSize = true;
            this.lbl_DepartmentHead.Location = new System.Drawing.Point(743, 519);
            this.lbl_DepartmentHead.Name = "lbl_DepartmentHead";
            this.lbl_DepartmentHead.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_DepartmentHead.Size = new System.Drawing.Size(57, 13);
            this.lbl_DepartmentHead.TabIndex = 4;
            this.lbl_DepartmentHead.Text = "dept Head";
            this.lbl_DepartmentHead.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_division_edit
            // 
            this.btn_division_edit.Location = new System.Drawing.Point(248, 467);
            this.btn_division_edit.Name = "btn_division_edit";
            this.btn_division_edit.Size = new System.Drawing.Size(114, 23);
            this.btn_division_edit.TabIndex = 2;
            this.btn_division_edit.Text = "Edit Division";
            this.btn_division_edit.UseVisualStyleBackColor = true;
            // 
            // btn_division_show
            // 
            this.btn_division_show.Location = new System.Drawing.Point(248, 438);
            this.btn_division_show.Name = "btn_division_show";
            this.btn_division_show.Size = new System.Drawing.Size(114, 23);
            this.btn_division_show.TabIndex = 2;
            this.btn_division_show.Text = "Division Details";
            this.btn_division_show.UseVisualStyleBackColor = true;
            // 
            // btn_project_edit
            // 
            this.btn_project_edit.Location = new System.Drawing.Point(484, 467);
            this.btn_project_edit.Name = "btn_project_edit";
            this.btn_project_edit.Size = new System.Drawing.Size(114, 23);
            this.btn_project_edit.TabIndex = 2;
            this.btn_project_edit.Text = "Edit Project";
            this.btn_project_edit.UseVisualStyleBackColor = true;
            // 
            // btn_project_show
            // 
            this.btn_project_show.Location = new System.Drawing.Point(484, 438);
            this.btn_project_show.Name = "btn_project_show";
            this.btn_project_show.Size = new System.Drawing.Size(114, 23);
            this.btn_project_show.TabIndex = 2;
            this.btn_project_show.Text = "Project Details";
            this.btn_project_show.UseVisualStyleBackColor = true;
            // 
            // btn_department_edit
            // 
            this.btn_department_edit.Location = new System.Drawing.Point(720, 467);
            this.btn_department_edit.Name = "btn_department_edit";
            this.btn_department_edit.Size = new System.Drawing.Size(114, 23);
            this.btn_department_edit.TabIndex = 2;
            this.btn_department_edit.Text = "Edit Department";
            this.btn_department_edit.UseVisualStyleBackColor = true;
            // 
            // btn_department_show
            // 
            this.btn_department_show.Location = new System.Drawing.Point(720, 438);
            this.btn_department_show.Name = "btn_department_show";
            this.btn_department_show.Size = new System.Drawing.Size(114, 23);
            this.btn_department_show.TabIndex = 2;
            this.btn_department_show.Text = "Department Details";
            this.btn_department_show.UseVisualStyleBackColor = true;
            // 
            // btn_employee_edit
            // 
            this.btn_employee_edit.Location = new System.Drawing.Point(956, 467);
            this.btn_employee_edit.Name = "btn_employee_edit";
            this.btn_employee_edit.Size = new System.Drawing.Size(114, 23);
            this.btn_employee_edit.TabIndex = 2;
            this.btn_employee_edit.Text = "Edit Employee";
            this.btn_employee_edit.UseVisualStyleBackColor = true;
            // 
            // btn_employee_show
            // 
            this.btn_employee_show.Location = new System.Drawing.Point(956, 438);
            this.btn_employee_show.Name = "btn_employee_show";
            this.btn_employee_show.Size = new System.Drawing.Size(114, 23);
            this.btn_employee_show.TabIndex = 2;
            this.btn_employee_show.Text = "Employee Details";
            this.btn_employee_show.UseVisualStyleBackColor = true;
            // 
            // btn_employee_fire
            // 
            this.btn_employee_fire.Location = new System.Drawing.Point(1072, 467);
            this.btn_employee_fire.Name = "btn_employee_fire";
            this.btn_employee_fire.Size = new System.Drawing.Size(114, 23);
            this.btn_employee_fire.TabIndex = 2;
            this.btn_employee_fire.Text = "Fire Employee";
            this.btn_employee_fire.UseVisualStyleBackColor = true;
            // 
            // btn_employee_hire
            // 
            this.btn_employee_hire.Location = new System.Drawing.Point(1072, 438);
            this.btn_employee_hire.Name = "btn_employee_hire";
            this.btn_employee_hire.Size = new System.Drawing.Size(114, 23);
            this.btn_employee_hire.TabIndex = 2;
            this.btn_employee_hire.Text = "Hire Employee";
            this.btn_employee_hire.UseVisualStyleBackColor = true;
            // 
            // btn_company_setLead
            // 
            this.btn_company_setLead.Location = new System.Drawing.Point(12, 554);
            this.btn_company_setLead.Name = "btn_company_setLead";
            this.btn_company_setLead.Size = new System.Drawing.Size(230, 23);
            this.btn_company_setLead.TabIndex = 2;
            this.btn_company_setLead.Text = "Set Director";
            this.btn_company_setLead.UseVisualStyleBackColor = true;
            // 
            // btn_division_setLead
            // 
            this.btn_division_setLead.Location = new System.Drawing.Point(248, 554);
            this.btn_division_setLead.Name = "btn_division_setLead";
            this.btn_division_setLead.Size = new System.Drawing.Size(230, 23);
            this.btn_division_setLead.TabIndex = 2;
            this.btn_division_setLead.Text = "Set Division Director";
            this.btn_division_setLead.UseVisualStyleBackColor = true;
            // 
            // btn_project_setLead
            // 
            this.btn_project_setLead.Location = new System.Drawing.Point(484, 554);
            this.btn_project_setLead.Name = "btn_project_setLead";
            this.btn_project_setLead.Size = new System.Drawing.Size(230, 23);
            this.btn_project_setLead.TabIndex = 2;
            this.btn_project_setLead.Text = "Set Project Lead";
            this.btn_project_setLead.UseVisualStyleBackColor = true;
            // 
            // btn_department_setLead
            // 
            this.btn_department_setLead.Location = new System.Drawing.Point(720, 554);
            this.btn_department_setLead.Name = "btn_department_setLead";
            this.btn_department_setLead.Size = new System.Drawing.Size(230, 23);
            this.btn_department_setLead.TabIndex = 2;
            this.btn_department_setLead.Text = "Set Department Head";
            this.btn_department_setLead.UseVisualStyleBackColor = true;
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
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn7});
            this.dgv_divisions.Location = new System.Drawing.Point(248, 25);
            this.dgv_divisions.MultiSelect = false;
            this.dgv_divisions.Name = "dgv_divisions";
            this.dgv_divisions.ReadOnly = true;
            this.dgv_divisions.RowHeadersVisible = false;
            this.dgv_divisions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_divisions.Size = new System.Drawing.Size(230, 407);
            this.dgv_divisions.TabIndex = 0;
            this.dgv_divisions.SelectionChanged += new System.EventHandler(this.dgv_divisions_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.FillWeight = 60F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Code";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn8});
            this.dgv_projects.Location = new System.Drawing.Point(484, 25);
            this.dgv_projects.MultiSelect = false;
            this.dgv_projects.Name = "dgv_projects";
            this.dgv_projects.ReadOnly = true;
            this.dgv_projects.RowHeadersVisible = false;
            this.dgv_projects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_projects.Size = new System.Drawing.Size(230, 407);
            this.dgv_projects.TabIndex = 0;
            this.dgv_projects.SelectionChanged += new System.EventHandler(this.dgv_projects_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.FillWeight = 60F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Code";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn9});
            this.dgv_departments.Location = new System.Drawing.Point(720, 25);
            this.dgv_departments.MultiSelect = false;
            this.dgv_departments.Name = "dgv_departments";
            this.dgv_departments.ReadOnly = true;
            this.dgv_departments.RowHeadersVisible = false;
            this.dgv_departments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_departments.Size = new System.Drawing.Size(230, 407);
            this.dgv_departments.TabIndex = 0;
            this.dgv_departments.SelectionChanged += new System.EventHandler(this.dgv_departments_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.FillWeight = 60F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Code";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dgv_employees.Location = new System.Drawing.Point(956, 25);
            this.dgv_employees.MultiSelect = false;
            this.dgv_employees.Name = "dgv_employees";
            this.dgv_employees.ReadOnly = true;
            this.dgv_employees.RowHeadersVisible = false;
            this.dgv_employees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_employees.Size = new System.Drawing.Size(230, 407);
            this.dgv_employees.TabIndex = 0;
            this.dgv_employees.SelectionChanged += new System.EventHandler(this.dgv_departments_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "ID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.FillWeight = 140F;
            this.dataGridViewTextBoxColumn12.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btn_company_remove
            // 
            this.btn_company_remove.Location = new System.Drawing.Point(128, 467);
            this.btn_company_remove.Name = "btn_company_remove";
            this.btn_company_remove.Size = new System.Drawing.Size(114, 23);
            this.btn_company_remove.TabIndex = 2;
            this.btn_company_remove.Text = "Remove Company";
            this.btn_company_remove.UseVisualStyleBackColor = true;
            // 
            // btn_company_add
            // 
            this.btn_company_add.Location = new System.Drawing.Point(128, 438);
            this.btn_company_add.Name = "btn_company_add";
            this.btn_company_add.Size = new System.Drawing.Size(114, 23);
            this.btn_company_add.TabIndex = 2;
            this.btn_company_add.Text = "Add Company";
            this.btn_company_add.UseVisualStyleBackColor = true;
            this.btn_company_add.Click += new System.EventHandler(this.btn_company_add_Click);
            // 
            // btn_division_remove
            // 
            this.btn_division_remove.Location = new System.Drawing.Point(364, 467);
            this.btn_division_remove.Name = "btn_division_remove";
            this.btn_division_remove.Size = new System.Drawing.Size(114, 23);
            this.btn_division_remove.TabIndex = 2;
            this.btn_division_remove.Text = "Remove Division";
            this.btn_division_remove.UseVisualStyleBackColor = true;
            // 
            // btn_division_add
            // 
            this.btn_division_add.Location = new System.Drawing.Point(364, 438);
            this.btn_division_add.Name = "btn_division_add";
            this.btn_division_add.Size = new System.Drawing.Size(114, 23);
            this.btn_division_add.TabIndex = 2;
            this.btn_division_add.Text = "Add Division";
            this.btn_division_add.UseVisualStyleBackColor = true;
            // 
            // btn_project_remove
            // 
            this.btn_project_remove.Location = new System.Drawing.Point(600, 467);
            this.btn_project_remove.Name = "btn_project_remove";
            this.btn_project_remove.Size = new System.Drawing.Size(114, 23);
            this.btn_project_remove.TabIndex = 2;
            this.btn_project_remove.Text = "Remove Project";
            this.btn_project_remove.UseVisualStyleBackColor = true;
            // 
            // btn_project_add
            // 
            this.btn_project_add.Location = new System.Drawing.Point(600, 438);
            this.btn_project_add.Name = "btn_project_add";
            this.btn_project_add.Size = new System.Drawing.Size(114, 23);
            this.btn_project_add.TabIndex = 2;
            this.btn_project_add.Text = "Add Project";
            this.btn_project_add.UseVisualStyleBackColor = true;
            // 
            // btn_department_remove
            // 
            this.btn_department_remove.Location = new System.Drawing.Point(836, 467);
            this.btn_department_remove.Name = "btn_department_remove";
            this.btn_department_remove.Size = new System.Drawing.Size(114, 23);
            this.btn_department_remove.TabIndex = 2;
            this.btn_department_remove.Text = "Remove Department";
            this.btn_department_remove.UseVisualStyleBackColor = true;
            // 
            // btn_department_add
            // 
            this.btn_department_add.Location = new System.Drawing.Point(836, 438);
            this.btn_department_add.Name = "btn_department_add";
            this.btn_department_add.Size = new System.Drawing.Size(114, 23);
            this.btn_department_add.TabIndex = 2;
            this.btn_department_add.Text = "Add Department";
            this.btn_department_add.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 594);
            this.Controls.Add(this.lbl_DivisionDirector);
            this.Controls.Add(this.lbl_DepartmentHead);
            this.Controls.Add(this.lbl_ProjectDirector);
            this.Controls.Add(this.lbl_CompanyDirector);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_employee_show);
            this.Controls.Add(this.btn_department_add);
            this.Controls.Add(this.btn_department_show);
            this.Controls.Add(this.btn_employee_hire);
            this.Controls.Add(this.btn_employee_fire);
            this.Controls.Add(this.btn_employee_edit);
            this.Controls.Add(this.btn_project_add);
            this.Controls.Add(this.btn_project_show);
            this.Controls.Add(this.btn_department_setLead);
            this.Controls.Add(this.btn_department_remove);
            this.Controls.Add(this.btn_department_edit);
            this.Controls.Add(this.btn_division_add);
            this.Controls.Add(this.btn_division_show);
            this.Controls.Add(this.btn_project_setLead);
            this.Controls.Add(this.btn_project_remove);
            this.Controls.Add(this.btn_project_edit);
            this.Controls.Add(this.btn_division_remove);
            this.Controls.Add(this.btn_division_setLead);
            this.Controls.Add(this.btn_division_edit);
            this.Controls.Add(this.btn_company_add);
            this.Controls.Add(this.btn_company_show);
            this.Controls.Add(this.btn_company_setLead);
            this.Controls.Add(this.btn_company_remove);
            this.Controls.Add(this.btn_company_edit);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_company_edit;
        private System.Windows.Forms.Button btn_company_show;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_CompanyDirector;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_ProjectDirector;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_DivisionDirector;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_DepartmentHead;
        private System.Windows.Forms.Button btn_division_edit;
        private System.Windows.Forms.Button btn_division_show;
        private System.Windows.Forms.Button btn_project_edit;
        private System.Windows.Forms.Button btn_project_show;
        private System.Windows.Forms.Button btn_department_edit;
        private System.Windows.Forms.Button btn_department_show;
        private System.Windows.Forms.Button btn_employee_edit;
        private System.Windows.Forms.Button btn_employee_show;
        private System.Windows.Forms.Button btn_employee_fire;
        private System.Windows.Forms.Button btn_employee_hire;
        private System.Windows.Forms.Button btn_company_setLead;
        private System.Windows.Forms.Button btn_division_setLead;
        private System.Windows.Forms.Button btn_project_setLead;
        private System.Windows.Forms.Button btn_department_setLead;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCode;
        private System.Windows.Forms.DataGridView dgv_divisions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridView dgv_projects;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView dgv_departments;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridView dgv_employees;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Button btn_company_remove;
        private System.Windows.Forms.Button btn_company_add;
        private System.Windows.Forms.Button btn_division_remove;
        private System.Windows.Forms.Button btn_division_add;
        private System.Windows.Forms.Button btn_project_remove;
        private System.Windows.Forms.Button btn_project_add;
        private System.Windows.Forms.Button btn_department_remove;
        private System.Windows.Forms.Button btn_department_add;
    }
}

