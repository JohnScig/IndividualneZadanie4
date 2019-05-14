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
    public partial class EmployeesView : Form
    {
        private EmployeesViewModel _employeesViewModel;

        public EmployeesView(int? nodeID)
        {
            InitializeComponent();
            _employeesViewModel = new EmployeesViewModel();
            if (nodeID != null)
            {
                btn_OK.Visible = true;
                _employeesViewModel.NodeID = (int)nodeID;
            }
            LoadGrid();
        }

        private void LoadGrid()
        {
            dgv_unassigned.Rows.Clear();
            _employeesViewModel.LoadUnassigned();
            foreach (var item in _employeesViewModel.Unassigned)
            {
                dgv_unassigned.Rows.Add(item.EmployeeID, item.Title, item.FirstName, item.LastName);
            }
            LockButtons(dgv_unassigned.Rows.Count);
        }

        private void LockButtons(int count)
        {
            btn_Edit.Enabled = (count != 0);
            btn_remove.Enabled = (count != 0);
            btn_OK.Enabled = (count != 0);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            _employeesViewModel.AssignEmployee(Convert.ToInt32(dgv_unassigned.SelectedCells[0].Value));
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            using (EditEmployeeView addEmployee = new EditEmployeeView(null))
            {
                addEmployee.ShowDialog();
            }
            LoadGrid();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            using (EditEmployeeView editEmployee = new EditEmployeeView(Convert.ToInt32(dgv_unassigned.SelectedCells[0].Value)))
            {
                editEmployee.ShowDialog();
            }
            LoadGrid();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            _employeesViewModel.DeleteEmployee(Convert.ToInt32(dgv_unassigned.SelectedCells[0].Value));
            LoadGrid();
        }
    }
}
