using DatabaseCommunication;
using DatabaseCommunication.Repositories;
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

        public List<NodeModel> GetChildren(int parentNodeID)
        {
            return _nodeRepository.GetChildNodes(parentNodeID);
        }

        public List<EmployeeModel> GetEmployeesByDept(int nodeID)
        {
            return _employeeRepository.GetEmployeesByDept(nodeID);
        }
    }
}
