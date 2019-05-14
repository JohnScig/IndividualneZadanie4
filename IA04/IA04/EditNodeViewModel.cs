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
        private Functions _functions = new Functions();
        private bool editing = false;

        public NodeModel Node { get; set; }
        public HierarchyLevel HierarchyLevel { get; set; }
        public int? ParentNode { get; set; }

        public EditNodeViewModel(int nodeID)
        {
            LoadNode(nodeID);
            editing = true;
        }

        public EditNodeViewModel(HierarchyLevel hierarchyLevel, int? parentNode)
        {
            HierarchyLevel = hierarchyLevel;
            ParentNode = parentNode;
        }

        private void LoadNode(int nodeID)
        {
            Node = _functions.GetNode(nodeID);
        }

        internal void HandleClick(string companyName, string companyCode)
        {
            if (editing)
            {
                _functions.EditNode(Node.NodeID, companyName, companyCode);
            }
            else
            {
                _functions.AddNode(ParentNode, companyName, companyCode, HierarchyLevel);
            }
        }


    }
}
