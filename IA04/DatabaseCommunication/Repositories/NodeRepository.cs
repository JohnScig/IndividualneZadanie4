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
        public List<NodeModel> GetChildNodes(int parentNodeID)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings1.Default.ConnString))
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
                                node.HierarchyLevel = (Support.Enums.HierarchyLevel) reader.GetInt32(3);
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

        public List<NodeModel> GetCompanies()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings1.Default.ConnString))
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
                                node.HierarchyLevel = (Support.Enums.HierarchyLevel)reader.GetInt32(3);
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

        public void AddNode(NodeModel node)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings1.Default.ConnString))
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
                    command.Parameters.Add("@HierarchyLevel", SqlDbType.Int).Value = (int) node.HierarchyLevel;
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
    }
}
