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

        public void AddNode(int? parentNode, string companyName, string companyCode, Enums.HierarchyLevel hierarchyLevel)
        {
            _functions.AddNode(parentNode, companyName, companyCode, hierarchyLevel);
        }
    }
}
