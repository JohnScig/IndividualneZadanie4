using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Support.Enums;

namespace DatabaseCommunication
{
    public class NodeModel
    {
        public int NodeID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public HierarchyLevel HierarchyLevel { get; set; }
        public int? DirectorID { get; set; }
        public int? ParentNode { get; set; }
    }
}
