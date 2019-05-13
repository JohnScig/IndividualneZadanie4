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

        public MainView()
        {
            InitializeComponent();
            _mainViewModel = new MainViewModel();
            LoadCompanyGrid();
            dgv_companies.ClearSelection();
        }

        private void LoadCompanyGrid()
        {
            //dgv_companies.DataSource = _mainViewModel.ListOfCompanies;
            foreach (var Company in _mainViewModel.ListOfCompanies)
            {
                dgv_companies.Rows.Add(Company.Name, Company.Code);
            }
        }

        private void dgv_companies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDivisionGrid(dgv_companies.SelectedRows[0].Index);
        }

        private void LoadDivisionGrid(int selectionID)
        {
            //_mainViewModel.LoadListOfDivisions(_mainViewModel.ListOfCompanies[selectionID].NodeID);
            //dgv_divisions.DataSource = _mainViewModel.ListOfDivisions;
            _mainViewModel.LoadListOfDivisions(_mainViewModel.ListOfCompanies[dgv_companies.SelectedRows[0].Index].NodeID);
            dgv_divisions.Rows.Clear();
            foreach (var division in _mainViewModel.ListOfDivisions)
            {
                dgv_divisions.Rows.Add(division.Name, division.Code);
            }
        }

        private void dgv_divisions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadProjectsGrid();
        }

        private void LoadProjectsGrid()
        {
            _mainViewModel.LoadListOfProjects(_mainViewModel.ListOfDivisions[dgv_divisions.SelectedRows[0].Index].NodeID);
            dgv_projects.Rows.Clear();
            foreach (var project in _mainViewModel.ListOfProjects)
            {
                dgv_projects.Rows.Add(project.Name, project.Code);
            }
        }

        private void dgv_projects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDepartmentsGrid();
        }

        private void LoadDepartmentsGrid()
        {
            _mainViewModel.LoadListOfDepartments(_mainViewModel.ListOfProjects[dgv_projects.SelectedRows[0].Index].NodeID);
            dgv_departments.Rows.Clear();
            foreach (var department in _mainViewModel.ListOfDepartments)
            {
                dgv_departments.Rows.Add(department.Name, department.Code);
            }
        }

        private void dgv_departments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadEmployeesGrid();
        }

        private void LoadEmployeesGrid()
        {
            _mainViewModel.LoadListOfEmployees(_mainViewModel.ListOfDepartments[dgv_departments.SelectedRows[0].Index].NodeID);
            dgv_employees.Rows.Clear();
            foreach (var employee in _mainViewModel.ListOfEmployees)
            {
                dgv_employees.Rows.Add(employee.FirstName, employee.LastName);
            }
        }
    }
}
