using DatabaseCommunication;
using Support;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IA04
{
    public partial class MainView : Form
    {
        private MainViewModel _mainViewModel;
        private List<Button> _companyButtons;
        private List<Button> _divisionButtons;
        private List<Button> _projectButtons;
        private List<Button> _departmentButtons;
        private List<Button> _employeeButtons;

        public MainView()
        {
            InitializeComponent();
            _mainViewModel = new MainViewModel();
            LoadGrid(dgv_companies, _mainViewModel.ListOfCompanies);
            SetUpButtons();
            LockButtons();
        }

        #region Selection Changed
        private void dgv_companies_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_companies.SelectedRows.Count != 0)
            {
                _mainViewModel.LoadListOfDivisions(Convert.ToInt32(dgv_companies.SelectedRows[0].Cells[0].Value));
                lbl_CompanyDirector.Text = _mainViewModel.GetLeader(Convert.ToInt32(dgv_companies.SelectedRows[0].Cells[3].Value));
                LoadGrid(dgv_divisions, _mainViewModel.ListOfDivisions);
            }
            else
            {
                dgv_divisions.Rows.Clear();
                lbl_CompanyDirector.Text = "";
            }
            LockButtons();
        }

        private void dgv_divisions_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_divisions.SelectedRows.Count != 0)
            {
                _mainViewModel.LoadListOfProjects(Convert.ToInt32(dgv_divisions.SelectedRows[0].Cells[0].Value));
                lbl_DivisionDirector.Text = _mainViewModel.GetLeader(Convert.ToInt32(dgv_divisions.SelectedRows[0].Cells[3].Value));
                LoadGrid(dgv_projects, _mainViewModel.ListOfProjects);
            }
            else
            {
                dgv_projects.Rows.Clear();
                lbl_DivisionDirector.Text = "";
            }
            LockButtons();
        }

        private void dgv_projects_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_projects.SelectedRows.Count != 0)
            {
                _mainViewModel.LoadListOfDepartments(Convert.ToInt32(dgv_projects.SelectedRows[0].Cells[0].Value));
                lbl_ProjectDirector.Text = _mainViewModel.GetLeader(Convert.ToInt32(dgv_projects.SelectedRows[0].Cells[3].Value));
                LoadGrid(dgv_departments, _mainViewModel.ListOfDepartments);
            }
            else
            {
                dgv_departments.Rows.Clear();
                lbl_ProjectDirector.Text = "";
            }
            LockButtons();
        }

        private void dgv_departments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_departments.SelectedRows.Count != 0)
            {
                _mainViewModel.LoadListOfEmployees(Convert.ToInt32(dgv_departments.SelectedRows[0].Cells[0].Value));
                lbl_DepartmentHead.Text = _mainViewModel.GetLeader(Convert.ToInt32(dgv_departments.SelectedRows[0].Cells[3].Value));
                LoadGrid(dgv_employees, _mainViewModel.ListOfEmployees);
            }
            else
            {
                dgv_employees.Rows.Clear();
                lbl_DepartmentHead.Text = "";
            }
            LockButtons();
        }

        #endregion

        #region Adding Buttons

        private void btn_company_add_Click(object sender, EventArgs e)
        {
            using (EditNodeView addCompany = new EditNodeView(HierarchyLevel.Company, null))
            {
                addCompany.ShowDialog();
            }
            ReloadGrids();
        }

        private void btn_division_add_Click(object sender, EventArgs e)
        {
            int parentNodeID = Convert.ToInt32(dgv_companies.SelectedRows[0].Cells[0].Value);
            using (EditNodeView addDivision = new EditNodeView(HierarchyLevel.Division, parentNodeID))
            {
                addDivision.ShowDialog();
            }
            ReloadGrids();
        }

        private void btn_project_add_Click(object sender, EventArgs e)
        {
            int parentNodeID = Convert.ToInt32(dgv_divisions.SelectedRows[0].Cells[0].Value);
            using (EditNodeView addProject = new EditNodeView(HierarchyLevel.Project, parentNodeID))
            {
                addProject.ShowDialog();
            }
            ReloadGrids();
        }

        private void btn_department_add_Click(object sender, EventArgs e)
        {
            int parentNodeID = Convert.ToInt32(dgv_projects.SelectedRows[0].Cells[0].Value);
            using (EditNodeView addDepartment = new EditNodeView(HierarchyLevel.Project, parentNodeID))
            {
                addDepartment.ShowDialog();
            }
            ReloadGrids();
        }

        #endregion

        #region Removing Buttons

        private void btn_department_remove_Click(object sender, EventArgs e)
        {
            _mainViewModel.RemoveNode(Convert.ToInt32(dgv_departments.SelectedRows[0].Cells[0].Value));
            ReloadGrids();
        }

        private void btn_project_remove_Click(object sender, EventArgs e)
        {
            _mainViewModel.RemoveNode(Convert.ToInt32(dgv_projects.SelectedRows[0].Cells[0].Value));
            ReloadGrids();
        }

        private void btn_division_remove_Click(object sender, EventArgs e)
        {
            _mainViewModel.RemoveNode(Convert.ToInt32(dgv_divisions.SelectedRows[0].Cells[0].Value));
            ReloadGrids();
        }

        private void btn_company_remove_Click(object sender, EventArgs e)
        {
            _mainViewModel.RemoveNode(Convert.ToInt32(dgv_companies.SelectedRows[0].Cells[0].Value));
            ReloadGrids();
        }

        #endregion

        #region Editing Buttons

        private void btn_company_edit_Click(object sender, EventArgs e)
        {
            using (EditNodeView editCompany = new EditNodeView(Convert.ToInt32(dgv_companies.SelectedCells[0].Value)))
            {
                editCompany.ShowDialog();
            }
            ReloadGrids();
        }

        private void btn_division_edit_Click(object sender, EventArgs e)
        {
            using (EditNodeView editCompany = new EditNodeView(Convert.ToInt32(dgv_divisions.SelectedCells[0].Value)))
            {
                editCompany.ShowDialog();
            }
            ReloadGrids();
        }

        private void btn_project_edit_Click(object sender, EventArgs e)
        {
            using (EditNodeView editCompany = new EditNodeView(Convert.ToInt32(dgv_projects.SelectedCells[0].Value)))
            {
                editCompany.ShowDialog();
            }
            ReloadGrids();
        }

        private void btn_department_edit_Click(object sender, EventArgs e)
        {
            using (EditNodeView editCompany = new EditNodeView(Convert.ToInt32(dgv_departments.SelectedCells[0].Value)))
            {
                editCompany.ShowDialog();
            }
            ReloadGrids();
        }

        #endregion

        #region Setting Lead Buttons

        private void btn_company_setLead_Click(object sender, EventArgs e)
        {
            using (SetLeaderView setLeader = new SetLeaderView(Convert.ToInt32(dgv_companies.SelectedCells[0].Value)))
            {
                setLeader.ShowDialog();
            }
            ReloadGrids();
        }

        private void btn_division_setLead_Click(object sender, EventArgs e)
        {
            using (SetLeaderView setLeader = new SetLeaderView(Convert.ToInt32(dgv_divisions.SelectedCells[0].Value)))
            {
                setLeader.ShowDialog();
            }
            ReloadGrids();
        }

        private void btn_project_setLead_Click(object sender, EventArgs e)
        {
            using (SetLeaderView setLeader = new SetLeaderView(Convert.ToInt32(dgv_projects.SelectedCells[0].Value)))
            {
                setLeader.ShowDialog();
            }
            ReloadGrids();
        }

        private void btn_department_setLead_Click(object sender, EventArgs e)
        {
            using (SetLeaderView setLeader = new SetLeaderView(Convert.ToInt32(dgv_departments.SelectedCells[0].Value)))
            {
                setLeader.ShowDialog();
            }
            ReloadGrids();
        }

        #endregion

        #region Employee Buttons
        private void btn_ViewEmployees_Click(object sender, EventArgs e)
        {
            using (EmployeesView viewEmployees = new EmployeesView(null))
            {
                viewEmployees.ShowDialog();
            }
        }

        private void btn_AssignEmployee_Click(object sender, EventArgs e)
        {
            using (EmployeesView assignEmployee = new EmployeesView(Convert.ToInt32(dgv_departments.SelectedCells[0].Value)))
            {
                assignEmployee.ShowDialog();
            }
            ReloadGrids();
        }

        private void btn_RemoveEmployee_Click(object sender, EventArgs e)
        {
            _mainViewModel.RemoveEmployee(Convert.ToInt32(dgv_employees.SelectedCells[0].Value));
            ReloadGrids();
        }

        #endregion

        #region Handling Button Locking

        private void SetUpButtons()
        {
            _companyButtons = new List<Button>() { btn_company_edit, btn_company_remove, btn_company_setLead, btn_company_show, btn_division_add };
            _divisionButtons = new List<Button>() { btn_division_edit, btn_division_remove, btn_division_setLead, btn_division_show, btn_project_add };
            _projectButtons = new List<Button>() { btn_project_edit, btn_project_remove, btn_project_setLead, btn_project_show, btn_department_add };
            _departmentButtons = new List<Button>() { btn_department_edit, btn_department_remove, btn_department_setLead, btn_department_show, btn_AssignEmployee };
            _employeeButtons = new List<Button>() { btn_RemoveEmployee };
        }

        private void LockButtons()
        {
            int companyCounter = dgv_companies.Rows.Count;
            int divisionCounter = dgv_divisions.Rows.Count;
            int projectCounter = dgv_projects.Rows.Count;
            int departmentCounter = dgv_departments.Rows.Count;
            int employeeCounter = dgv_employees.Rows.Count;

            List<Button> companyButtons = new List<Button>() { btn_company_edit, btn_company_remove, btn_company_setLead, btn_company_show, btn_division_add };
            List<Button> divisionButtons = new List<Button>() { btn_division_edit, btn_division_remove, btn_division_setLead, btn_division_show, btn_project_add };
            List<Button> projectButtons = new List<Button>() { btn_project_edit, btn_project_remove, btn_project_setLead, btn_project_show, btn_department_add };
            List<Button> departmentButtons = new List<Button>() { btn_department_edit, btn_department_remove, btn_department_setLead, btn_department_show, btn_AssignEmployee };
            List<Button> employeeButtons = new List<Button>() { btn_RemoveEmployee };

            foreach (Button button in companyButtons)
            {
                button.Enabled = companyCounter != 0;
            }

            foreach (Button button in divisionButtons)
            {
                button.Enabled = divisionCounter != 0;
            }

            foreach (Button button in projectButtons)
            {
                button.Enabled = projectCounter != 0;
            }

            foreach (Button button in departmentButtons)
            {
                button.Enabled = departmentCounter != 0;
            }

            foreach (Button button in employeeButtons)
            {
                button.Enabled = employeeCounter != 0;
            }
        }

        #endregion

        private void ReloadGrids()
        {
            _mainViewModel.LoadListOfCompanies();
            LoadGrid(dgv_companies, _mainViewModel.ListOfCompanies);
            LockButtons();
        }

        private void LoadGrid(DataGridView dataGridView, List<NodeModel> listOfNodes)
        {
            dataGridView.Rows.Clear();
            foreach (var node in listOfNodes)
            {
                dataGridView.Rows.Add(node.NodeID, node.Name, node.Code, node.DirectorID);
            }
        }

        private void LoadGrid(DataGridView dataGridView, List<EmployeeModel> listOfEmployees)
        {
            dataGridView.Rows.Clear();
            foreach (var employee in listOfEmployees)
            {
                dataGridView.Rows.Add(employee.EmployeeID, employee.FirstName, employee.LastName);
            }
        }


    }
}


// unifying the selection functions
//private void SelectionChanged(object sender)
//{
//    DataGridView dgv = (DataGridView)sender;
//    if (dgv.SelectedRows.Count != 0)
//    {
//        _mainViewModel.LoadListOfProjects(Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value));
//        LoadGrid(dgv_projects, _mainViewModel.ListOfProjects);
//    }
//    else
//    {
//        dgv_projects.Rows.Clear();
//    }
//}