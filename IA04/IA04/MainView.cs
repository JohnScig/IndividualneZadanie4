﻿using DatabaseCommunication;
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

        public MainView()
        {
            InitializeComponent();
            _mainViewModel = new MainViewModel();
            LoadGrid(dgv_companies, _mainViewModel.ListOfCompanies);
        }

        private void dgv_companies_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_companies.SelectedRows.Count != 0)
            {
                _mainViewModel.LoadListOfDivisions(Convert.ToInt32(dgv_companies.SelectedRows[0].Cells[0].Value));
                LoadGrid(dgv_divisions, _mainViewModel.ListOfDivisions);
            }
            else
            {
                dgv_divisions.Rows.Clear();
            }
        }

        private void dgv_divisions_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_divisions.SelectedRows.Count != 0)
            {
                _mainViewModel.LoadListOfProjects(Convert.ToInt32(dgv_divisions.SelectedRows[0].Cells[0].Value));
                LoadGrid(dgv_projects, _mainViewModel.ListOfProjects);
            }
            else
            {
                dgv_projects.Rows.Clear();
            }
        }

        private void dgv_projects_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_projects.SelectedRows.Count != 0)
            {
                _mainViewModel.LoadListOfDepartments(Convert.ToInt32(dgv_projects.SelectedRows[0].Cells[0].Value));
                LoadGrid(dgv_departments, _mainViewModel.ListOfDepartments);
            }
            else
            {
                dgv_departments.Rows.Clear();
            }
        }

        private void dgv_departments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_departments.SelectedRows.Count != 0)
            {
                _mainViewModel.LoadListOfEmployees(Convert.ToInt32(dgv_departments.SelectedRows[0].Cells[0].Value));
                LoadGrid(dgv_employees, _mainViewModel.ListOfEmployees);
            }
            else
            {
                dgv_employees.Rows.Clear();
            }
        }

        private void LoadGrid(DataGridView dataGridView, List<NodeModel> listOfNodes)
        {
            dataGridView.Rows.Clear();
            foreach (var node in listOfNodes)
            {
                dataGridView.Rows.Add(node.NodeID, node.Name, node.Code);
            }

            //dataGridView.DataSource = listOfNodes;
            //dataGridView.Columns[0].Visible = false;
            //dataGridView.Columns[3].Visible = false;
            //dataGridView.Columns[4].Visible = false;
            //dataGridView.Columns[5].Visible = false;
            //dataGridView.Columns[2].FillWeight = 60;
        }

        private void LoadGrid(DataGridView dataGridView, List<EmployeeModel> listOfEmployees)
        {
            dataGridView.Rows.Clear();
            foreach (var employee in listOfEmployees)
            {
                dataGridView.Rows.Add(employee.EmployeeID, employee.FirstName, employee.LastName);
            }
        }

        private void btn_company_add_Click(object sender, EventArgs e)
        {
            using (AddFormView addCompany = new AddFormView(Enums.HierarchyLevel.Company, null))
            {
                addCompany.ShowDialog();
                _mainViewModel.LoadListOfCompanies();
                LoadGrid(dgv_companies, _mainViewModel.ListOfCompanies);
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