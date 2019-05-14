using DatabaseCommunication;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IA04
{
    class EditEmployeeViewModel
    {
        #region Field
        private Functions _functions = new Functions();

        #endregion

        #region Properties
        public EmployeeModel employee { get; set; }

        #endregion

        #region Constructor
        public EditEmployeeViewModel(int? employeeID)
        {
            if (employeeID != null)
            {
                employee = _functions.GetEmployeeByID((int)employeeID);
            }
        }
        #endregion

        #region Button Handling Functions
        internal void HandleOK(string title, string firstName, string lastName, string phone, string email)
        {
            if (employee == null)
            {
                AddEmployee(title, firstName, lastName, phone, email);
            }
            else
            {
                EditEmployee(title, firstName, lastName, phone, email);
            }
        }
        #endregion

        #region Private Functions
        private void AddEmployee(string title, string firstName, string lastName, string phone, string email)
        {
            _functions.AddEmployee(title, firstName, lastName, phone, email);
        }

        private void EditEmployee(string title, string firstName, string lastName, string phone, string email)
        {
            _functions.EditEmployee(employee.EmployeeID, title, firstName, lastName, phone, email);
        }

        #endregion
    }
}
