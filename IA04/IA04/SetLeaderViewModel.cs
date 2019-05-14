using DatabaseCommunication;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA04
{
    class SetLeaderViewModel
    {

        #region Fields
        private Functions _functions = new Functions();
        #endregion

        #region Properties
        public NodeModel Node { get; set; }
        public List<EmployeeModel> unemployedPeople;
        #endregion

        #region Constructor
        public SetLeaderViewModel(int nodeID)
        {
            Node = _functions.GetNode(nodeID);
        }
        #endregion

        #region Loading Functions
        internal string LoadDirector()
        {
            if (Node.DirectorID == null)
            {
                return "none";
            }
            else
            {
                EmployeeModel director = _functions.GetEmployeeByID((int)Node.DirectorID);
                return ($"{director.FirstName} {director.LastName}");   
            }

        }

        internal void LoadUnemployed()
        {
            unemployedPeople = new List<EmployeeModel>();
            unemployedPeople = _functions.GetUnassigned();
        }
        #endregion

        #region Button Handling Functions
        internal void RemoveBoss()
        {
            if (Node.DirectorID != null)
            {
                _functions.RemoveEmployee((int)Node.DirectorID);
                _functions.RemoveDirectorFromNode(Node.NodeID);
            }
        }

        internal void SetNewBoss(int employeeID)
        {
            _functions.SetNewBoss(Node.NodeID, employeeID);
            _functions.EmployPerson(employeeID, Node.NodeID);

        }
        #endregion
    }
}
