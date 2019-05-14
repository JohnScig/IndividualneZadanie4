using DatabaseCommunication;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA04
{
    public class EmployeesViewModel
    {
        private Functions _functions = new Functions();

        public List<EmployeeModel> Unassigned { get; set; }
        public int NodeID { get; set; }

        public EmployeesViewModel()
        {
            LoadUnassigned();
        }

        internal void LoadUnassigned()
        {
            Unassigned = _functions.GetUnassigned();
        }

        internal void AssignEmployee(int employeeID)
        {
            _functions.EmployPerson(employeeID, NodeID);
        }

        internal void DeleteEmployee(int employeeID)
        {
            _functions.DeleteEmployee(employeeID);
        }
    }
}
