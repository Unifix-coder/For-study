using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusSchedule
{
    class DBconnect
    {
        OleDbConnection connection = new OleDbConnection("Data Source=STUDENT3-18_6;Initial Catalog=BusSchedule;Integrated Security=SSPI;Provider=SQLOLEDB");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
           
        public OleDbConnection GetConnection()
        {
            return connection;
        }
    }
}
