using DatabaseCommunication;
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
    public partial class SetLeaderView : Form
    {
        private SetLeaderViewModel _setLeaderViewModel;


        public SetLeaderView(int nodeID)
        {
            InitializeComponent();
            _setLeaderViewModel = new SetLeaderViewModel(nodeID);
            LoadLabels();
            LoadComboBox();
        }

        private void LoadLabels()
        {
            lbl_CompanyName.Text = _setLeaderViewModel.Node.Name;
            lbl_CurrentBoss.Text = _setLeaderViewModel.LoadDirector();
        }

        private void LoadComboBox()
        {
            _setLeaderViewModel.LoadUnemployed();
            cb_Leader.DataSource = _setLeaderViewModel.unemployedPeople;
            cb_Leader.DisplayMember = "LastName";
            cb_Leader.ValueMember = "EmployeeID";
        }

        private void cb_Leader_Format(object sender, ListControlConvertEventArgs e)
        {
            // Assuming your class called Employee , and Firstname & Lastname are the fields
            string lastname = ((EmployeeModel)e.ListItem).FirstName;
            string firstname = ((EmployeeModel)e.ListItem).LastName;
            e.Value = lastname + " " + firstname;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            _setLeaderViewModel.RemoveBoss();
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            _setLeaderViewModel.RemoveBoss();
            _setLeaderViewModel.SetNewBoss((int)cb_Leader.SelectedValue);
            this.Close();
        }
    }
}
