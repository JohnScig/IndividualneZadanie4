using Support;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCommunication.Repositories
{
    public class NodeRepository
    {
        private static string connString = Properties.Settings1.Default.ConnString;

        #region Basic Function
        public void AddNode(NodeModel node)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                }
                catch (SqlException e)
                {
                    Debug.WriteLine("Exception throw when opening connection to database! Exception description follows");
                    Debug.WriteLine(e.ToString());
                    return;
                }


                using (SqlCommand command = connection.CreateCommand())
                {

                    command.CommandText = @"INSERT INTO Nodes(Name, Code, HierarchyLevel, ParentNodeID)
                                                VALUES(@Name, @Code, @HierarchyLevel, @ParentNodeID)";

                    command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = node.Name;
                    command.Parameters.Add("@Code", SqlDbType.NVarChar).Value = node.Code;
                    command.Parameters.Add("@HierarchyLevel", SqlDbType.Int).Value = (int)node.HierarchyLevel;
                    command.Parameters.Add("@ParentNodeID", SqlDbType.Int).Value = (object)node.ParentNode ?? DBNull.Value;



                    try
                    {
                        command.ExecuteNonQuery();
                    }

                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                        return;
                    }
                }
            }
        }

        public void EditNode(int nodeID, string companyName, string companyCode)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                }
                catch (SqlException e)
                {
                    Debug.WriteLine("Exception throw when opening connection to database! Exception description follows");
                    Debug.WriteLine(e.ToString());
                }


                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"UPDATE Nodes SET Name = @CompanyName, Code = @CompanyCode WHERE NodeID = @NodeID ";
                    command.Parameters.Add("@CompanyName", SqlDbType.NVarChar).Value = companyName;
                    command.Parameters.Add("@CompanyCode", SqlDbType.NVarChar).Value = companyCode;
                    command.Parameters.Add("@NodeID", SqlDbType.Int).Value = nodeID;

                    try
                    {
                        command.ExecuteNonQuery();
                    }

                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                    }
                }
            }
        }

        public void RemoveNodeByID(int nodeID)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                }
                catch (SqlException e)
                {
                    Debug.WriteLine("Exception throw when opening connection to database! Exception description follows");
                    Debug.WriteLine(e.ToString());
                }


                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"Delete from Nodes where NodeID = @NodeID";
                    command.Parameters.Add("@NodeID", SqlDbType.Int).Value = nodeID;

                    try
                    {
                        command.ExecuteNonQuery();
                    }

                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                    }
                }
            }
        }

        #endregion

        #region Changing employment
        public void SetNewBoss(int nodeID, int employeeID)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                }
                catch (SqlException e)
                {
                    Debug.WriteLine("Exception throw when opening connection to database! Exception description follows");
                    Debug.WriteLine(e.ToString());
                }


                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"UPDATE Nodes SET DirectorID = @EmployeeID WHERE NodeID = @NodeID ";
                    command.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = employeeID;
                    command.Parameters.Add("@NodeID", SqlDbType.Int).Value = nodeID;

                    try
                    {
                        command.ExecuteNonQuery();
                    }

                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                    }
                }
            }
        }

        public void RemoveDirectorFromNode(int nodeID)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                }
                catch (SqlException e)
                {
                    Debug.WriteLine("Exception throw when opening connection to database! Exception description follows");
                    Debug.WriteLine(e.ToString());
                }


                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"UPDATE Nodes SET DirectorID = Null where NodeID = @NodeID";
                    command.Parameters.Add("@NodeID", SqlDbType.Int).Value = nodeID;

                    try
                    {
                        command.ExecuteNonQuery();
                    }

                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                    }
                }
            }
        }

        #endregion

        #region Getting Functions
        public List<NodeModel> GetChildNodes(int parentNodeID)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                List<NodeModel> nodes = new List<NodeModel>();
                try
                {
                    connection.Open();
                }
                catch (SqlException e)
                {
                    Debug.WriteLine("Exception throw when opening connection to database! Exception description follows");
                    Debug.WriteLine(e.ToString());
                    return nodes;
                }


                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"SELECT * FROM Nodes
                                            WHERE ParentNodeID = @ParentNodeID";
                    command.Parameters.Add("@ParentNodeID", SqlDbType.Int).Value = parentNodeID;

                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                NodeModel node = new NodeModel();
                                node.NodeID = reader.GetInt32(0);
                                node.Name = reader.GetString(1);
                                node.Code = reader.GetString(2);
                                node.HierarchyLevel = (Support.HierarchyLevel) reader.GetInt32(3);
                                node.DirectorID = reader.IsDBNull(4) ? (int?)null : reader.GetInt32(4);
                                node.ParentNode = reader.IsDBNull(5) ? (int?)null : reader.GetInt32(5);
                                
                                nodes.Add(node);
                            }
                            return nodes;
                        }
                    }

                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                        return nodes;
                    }

                }
            }
        }

        public NodeModel GetNode(int nodeID)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                NodeModel node = new NodeModel();
                try
                {
                    connection.Open();
                }
                catch (SqlException e)
                {
                    Debug.WriteLine("Exception throw when opening connection to database! Exception description follows");
                    Debug.WriteLine(e.ToString());
                    return node;
                }


                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"SELECT * FROM Nodes
                                            WHERE NodeID = @NodeID";
                    command.Parameters.Add("@NodeID", SqlDbType.Int).Value = nodeID;

                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                node.NodeID = reader.GetInt32(0);
                                node.Name = reader.GetString(1);
                                node.Code = reader.GetString(2);
                                node.HierarchyLevel = (Support.HierarchyLevel)reader.GetInt32(3);
                                node.DirectorID = reader.IsDBNull(4) ? (int?)null : reader.GetInt32(4);
                                node.ParentNode = reader.IsDBNull(5) ? (int?)null : reader.GetInt32(5);
                            }
                            return node;
                        }
                    }

                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                        return node;
                    }

                }
            }
        }

        public List<NodeModel> GetCompanies()
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                List<NodeModel> nodes = new List<NodeModel>();
                try
                {
                    connection.Open();
                }
                catch (SqlException e)
                {
                    Debug.WriteLine("Exception throw when opening connection to database! Exception description follows");
                    Debug.WriteLine(e.ToString());
                    return nodes;
                }


                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"SELECT * FROM Nodes
                                            WHERE ParentNodeID IS NULL";

                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                NodeModel node = new NodeModel();
                                node.NodeID = reader.GetInt32(0);
                                node.Name = reader.GetString(1);
                                node.Code = reader.GetString(2);
                                node.HierarchyLevel = (HierarchyLevel)reader.GetInt32(3);
                                node.DirectorID = reader.IsDBNull(4) ? (int?)null : reader.GetInt32(4);
                                node.ParentNode = null;

                                nodes.Add(node);
                            }
                            return nodes;
                        }
                    }

                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                        return nodes;
                    }
                }
            }
        }

        #endregion

    }
}
