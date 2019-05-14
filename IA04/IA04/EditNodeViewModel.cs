using DatabaseCommunication;
using Logic;
using Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA04
{
    public class EditNodeViewModel
    {
        #region Fields
        private Functions _functions = new Functions();
        private bool _editing = false;
        #endregion

        #region Properties
        public NodeModel Node { get; set; }
        public HierarchyLevel HierarchyLevel { get; set; }
        public int? ParentNode { get; set; }
        #endregion

        #region Constructors
        public EditNodeViewModel(int nodeID)
        {
            LoadNode(nodeID);
            _editing = true;
        }

        public EditNodeViewModel(HierarchyLevel hierarchyLevel, int? parentNode)
        {
            HierarchyLevel = hierarchyLevel;
            ParentNode = parentNode;
        }
        #endregion

        #region Loading Functions
        private void LoadNode(int nodeID)
        {
            Node = _functions.GetNode(nodeID);
        }
        #endregion

        #region Button Handling Functions
        internal void HandleClick(string companyName, string companyCode)
        {
            if (_editing)
            {
                _functions.EditNode(Node.NodeID, companyName, companyCode);
            }
            else
            {
                _functions.AddNode(ParentNode, companyName, companyCode, HierarchyLevel);
            }
        }
        #endregion

    }
}
