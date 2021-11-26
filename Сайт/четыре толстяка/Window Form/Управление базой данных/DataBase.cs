using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Управление_базой_данных
{
    class DataBase
    {
        private SqlConnection sqlConnection = null;

        public DataBase()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["BakeryDB"].ConnectionString);
        }

        public void OpenConnection()
        {
            if(sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
