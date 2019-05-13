using Support;
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
    public partial class AddFormView : Form
    {

        private AddFormViewModel _addFormViewModel = new AddFormViewModel();

        public AddFormView(HierarchyLevel hierarchyLevel, int? parentNode)
        {
            InitializeComponent();
            _addFormViewModel.HierarchyLevel = hierarchyLevel;
            _addFormViewModel.ParentNode = parentNode;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            _addFormViewModel.AddNode(tb_name.Text, tb_code.Text);
            this.Close();
        }
    }
}
