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

        public int ParentNodeID { get; set; }

        public void AddEmployee(string title, string firstName, string lastName, string phone, string email)
        {
            _functions.AddEmployee(title, firstName, lastName, phone, email, ParentNodeID);
        }
    }
}
