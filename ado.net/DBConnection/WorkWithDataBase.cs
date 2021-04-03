using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DBConnection
{
    class WorkWithDataBase
    {
        public static int ExecuteScalarMetod(string cs, string qv)
        {
            using (SqlConnection connection = new SqlConnection(cs))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                connection.Open();
                command.CommandText = qv;
                int number = (int)command.ExecuteScalar();
            return number;
            }
        }
    }
}
