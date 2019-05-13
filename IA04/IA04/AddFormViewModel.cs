using Logic;
using Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA04
{
    class AddFormViewModel
    {
        private Functions _functions = new Functions();

        public HierarchyLevel HierarchyLevel { get; set; }
        public int? ParentNode { get; set; }

        public void AddNode( string companyName, string companyCode)
        {
            _functions.AddNode(ParentNode, companyName, companyCode, HierarchyLevel);
        }
    }
}
