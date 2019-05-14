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
        private Functions _functions = new Functions();

        public EmployeeModel employee { get; set; }

        public EditEmployeeViewModel(int? employeeID)
        {
            if (employeeID != null)
            {
                employee = _functions.GetEmployeeByID((int)employeeID);
            }
        }

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

        public void AddEmployee(string title, string firstName, string lastName, string phone, string email)
        {
            _functions.AddEmployee(title, firstName, lastName, phone, email);
        }

        public void EditEmployee(string title, string firstName, string lastName, string phone, string email)
        {
            _functions.EditEmployee(employee.EmployeeID, title, firstName, lastName, phone, email);
        }
    }
}
