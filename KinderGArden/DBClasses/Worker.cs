using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data.Common;
namespace KinderGArden.DBClasses
{
    class WorkerTable
    {
      
            public struct Worker
            {
                public Worker(int _id, string _name)
                {
                    id = _id;
                    name = _name;

                }
                public int id;
                public string name;

            }

            class DBWorker
            {
                private Class1 connection;
                public List<Worker> WrkList { get; }

                public DBWorker()
                {
                    connection = new Class1();
                    WrkList = new List<Worker>();
                    getWorker();

                }



                public void addWorker(string name)


                {
                    connection.openConnection();
                    NpgsqlCommand command = new NpgsqlCommand(@"INSERT INTO Worker_Table VALUES (default,'" + name + @")", connection.dbConnection);
                    int c = command.ExecuteNonQuery();
                    connection.closeConnection();

                }

                private void getWorker()
                {
                    Class1 connection = new Class1();
                    connection.openConnection();
                    NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM Worker_Table", connection.dbConnection);
                    NpgsqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        foreach (DbDataRecord rec in reader)
                        {
                            int it = int.Parse(rec["Worker_id"].ToString());
                            string name = rec["worker_name"].ToString();

                            WrkList.Add(new Worker(it, name));


                        }
                    }
                    connection.closeConnection();

                }

            }
        }
    }


