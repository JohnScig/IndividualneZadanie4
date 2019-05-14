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
        #region Fields
        private Functions _functions = new Functions();
        #endregion

        #region Properties
        public List<EmployeeModel> Unassigned { get; set; }
        public int NodeID { get; set; }
        #endregion

        #region Constructor
        public EmployeesViewModel()
        {
            LoadUnassigned();
        }
        #endregion

        #region Loading Functions
        internal void LoadUnassigned()
        {
            Unassigned = _functions.GetUnassigned();
        }
        #endregion

        #region Button Handling Functions
        internal void AssignEmployee(int employeeID)
        {
            _functions.EmployPerson(employeeID, NodeID);
        }
        internal void DeleteEmployee(int employeeID)
        {
            _functions.DeleteEmployee(employeeID);
        }
        #endregion
    }
}
