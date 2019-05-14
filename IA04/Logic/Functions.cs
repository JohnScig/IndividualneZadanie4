using DatabaseCommunication;
using DatabaseCommunication.Repositories;
using Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Functions
    {
        private NodeRepository _nodeRepository = new NodeRepository();
        private EmployeeRepository _employeeRepository = new EmployeeRepository();

        public List<NodeModel> GetCompanies()
        {
            return _nodeRepository.GetCompanies();
        }

        public void AddEmployee(string title, string firstName, string lastName, string phone, string email)
        {
            EmployeeModel employee = new EmployeeModel()
            {
                Title = title,
                FirstName = firstName,
                LastName = lastName,
                Phone = phone,
                Email = email,
                DepartmentID = null
            };
            _employeeRepository.AddEmployee(employee);
        }

        public void DeleteEmployee(int employeeID)
        {
            _employeeRepository.RemoveEmployee(employeeID);
        }

        public void EditEmployee(int employeeID, string title, string firstName, string lastName, string phone, string email)
        {
            EmployeeModel employee = new EmployeeModel()
            {
                EmployeeID = employeeID,
                Title = title,
                FirstName = firstName,
                LastName = lastName,
                Phone = phone,
                Email = email
            };
            _employeeRepository.EditEmployee(employee);
        }

        public List<EmployeeModel> GetUnassigned()
        {
            return _employeeRepository.GetUnassigned();

        }

        public NodeModel GetNode(int nodeID)
        {
            return _nodeRepository.GetNode(nodeID);
        }

        public void RemoveDirectorFromNode(int nodeID)
        {
            _nodeRepository.RemoveDirectorFromNode(nodeID);
        }

        public void SetNewBoss(int nodeID, int employeeID)
        {
            _nodeRepository.SetNewBoss(nodeID, employeeID);
            _employeeRepository.EmployPerson(employeeID, nodeID);
        }

        public void EmployPerson(int employeeID, int nodeID)
        {
            _employeeRepository.EmployPerson(employeeID, nodeID);
        }

        public void EditNode(int nodeID, string companyName, string companyCode)
        {
            _nodeRepository.EditNode(nodeID, companyName, companyCode);
        }

        public List<NodeModel> GetChildren(int parentNodeID)
        {
            return _nodeRepository.GetChildNodes(parentNodeID);
        }

        public List<EmployeeModel> GetEmployeesByDept(int nodeID)
        {
            return _employeeRepository.GetEmployeesByDept(nodeID);
        }

        public void AddNode(int? parentNode, string companyName, string companyCode, HierarchyLevel hierarchyLevel)
        {
            NodeModel node = new NodeModel()
            {
                Name = companyName,
                Code = companyCode,
                HierarchyLevel = hierarchyLevel,
                ParentNode = parentNode
            };
            _nodeRepository.AddNode(node);
        }

        public EmployeeModel GetEmployeeByID(int employeeID)
        {
            return _employeeRepository.GetEmployeeByID(employeeID);
        }

        public void RemoveNode(int nodeID)
        {
            //_nodeRepository.RemoveDirectorFromNode(nodeID);
            _nodeRepository.RemoveNodeByID(nodeID);
        }

        public void RemoveEmployee(int employeeID)
        {
            _employeeRepository.RemoveEmployeeFromPosition(employeeID);
        }
    }
}
