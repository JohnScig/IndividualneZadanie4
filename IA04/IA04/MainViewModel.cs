using DatabaseCommunication;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA04
{
    class MainViewModel
    {
        private Functions _functions = new Functions();

        public List<NodeModel> ListOfCompanies { get; set; } = new List<NodeModel>();
        public List<NodeModel> ListOfDivisions { get; set; } = new List<NodeModel>();
        public List<NodeModel> ListOfProjects { get; set; } = new List<NodeModel>();
        public List<NodeModel> ListOfDepartments { get; set; } = new List<NodeModel>();
        public List<EmployeeModel> ListOfEmployees { get; set; } = new List<EmployeeModel>();

        public MainViewModel()
        {
            LoadListOfCompanies();
        }

        private void LoadListOfCompanies()
        {
            ListOfCompanies = _functions.GetCompanies(); 
        }

        internal void LoadListOfDivisions(int parentNodeID)
        {
            ListOfDivisions = _functions.GetChildren(parentNodeID);
        }

        internal void LoadListOfProjects(int parentNodeID)
        {
            ListOfProjects = _functions.GetChildren(parentNodeID);
        }

        internal void LoadListOfDepartments(int parentNodeID)
        {
            ListOfDepartments = _functions.GetChildren(parentNodeID);
        }

        internal void LoadListOfEmployees(int nodeID)
        {
            ListOfEmployees = _functions.GetEmployeesByDept(nodeID);
        }
    }
}
