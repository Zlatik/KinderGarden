using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data.Common;

namespace KinderGArden.DBClasses
{
    public struct admin
    {
        public admin(int _id, string _name, string _password)
        {
            id = _id;
            name = _name;
            password = _password;
        }
        public int id;
        public string name;
        public string password;
    }
    class Admin
    {
       

        class DBAdmin
        {
            private Class1 connection;
            public List<admin> admList { get; }

            public DBAdmin()
            {
                connection = new Class1();
                admList = new List<admin>();
                getAdmins();

            }

            public bool checkUser(string _uname)
            {
                foreach (admin am in admList)
                    if (am.name == _uname)
                        return true;
                return false;


            }

            public bool addAdmin(string name, string password)
            {
                if (checkUser(name))
                {
                    connection.openConnection();
                    NpgsqlCommand command = new NpgsqlCommand(@"INSERT INTO admins VALUES (default,'" + name + @"','" + password + @"')", connection.dbConnection);
                    int c = command.ExecuteNonQuery();
                    connection.closeConnection();
                    if (c == 1)
                        return true;
                    else
                        return false;
                }
                else
                    throw new Exception("Username is already used");

            }

            private void getAdmins()
            {
                Class1 connection = new Class1();
                connection.openConnection();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM admins", connection.dbConnection);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    foreach (DbDataRecord rec in reader)
                    {
                        int it = int.Parse(rec["admin_id"].ToString());
                        string name = rec["admin_username"].ToString();
                        string pass = rec["admin_password"].ToString();
                        admList.Add(new admin(it, name, pass));


                    }
                }
                connection.closeConnection();

            }

        }
    }
}


