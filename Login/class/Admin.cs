using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Admin
    {
        MY_DB db = new MY_DB();

        public bool insertAdmin(int id, string username, string password, string email)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("INSERT INTO Login (Id, Username, Password, Email) VALUES (@id, @username, @password, @email)", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@username", SqlDbType.NChar).Value = username;
            command.Parameters.Add("@password", SqlDbType.Char).Value = password;
            command.Parameters.Add("@email", SqlDbType.Char).Value = email;

            adapter.InsertCommand = command;
            db.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }

        }
    }
    
}
