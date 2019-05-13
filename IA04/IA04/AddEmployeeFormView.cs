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
    public partial class AddEmployeeFormView : Form
    {
        private AddEmployeeFormViewModel _addEmployeeFormViewModel = new AddEmployeeFormViewModel();

        public AddEmployeeFormView(int parentNodeID)
        {
            InitializeComponent();
            _addEmployeeFormViewModel.ParentNodeID = parentNodeID;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            _addEmployeeFormViewModel.AddEmployee(tb_Title.Text, tb_FirstName.Text, tb_LastName.Text, tb_Phone.Text, tb_Email.Text);
        }
    }
}
