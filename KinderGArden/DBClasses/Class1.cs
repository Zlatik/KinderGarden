using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data.Common;
namespace KinderGArden.DBClasses
{
    class Class1
    {
        private const string connectionString = "Server=localhost;Port=5432;User=postgres;Password=admin;Database=advert;";
        public NpgsqlConnection dbConnection { get; }

        public Class1()
        {
            dbConnection = new NpgsqlConnection(connectionString);
        }



        public void openConnection()
        {
            dbConnection.Open();
        }

        public void closeConnection()
        {
            dbConnection.Close();
        }
    }
}