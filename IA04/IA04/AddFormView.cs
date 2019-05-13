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
        private Enums.HierarchyLevel _hierarchyLevel;
        private int? _parentNode;
        private AddFormViewModel _addFormView = new AddFormViewModel();

        public AddFormView(Enums.HierarchyLevel hierarchyLevel, int? parentNode)
        {
            InitializeComponent();
            _hierarchyLevel = hierarchyLevel;
            _parentNode = parentNode;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            _addFormView.AddNode(_parentNode,tb_name.Text,tb_code.Text, _hierarchyLevel);
            this.Close();
        }
    }
}
