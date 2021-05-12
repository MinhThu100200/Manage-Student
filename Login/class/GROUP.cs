using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class GROUP
    {
        MY_DB db = new MY_DB();

        //insert group
        public bool insertGroup(int id, string name, int user_id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("INSERT INTO Groups (Id, name, User_id ) VALUES (@id, @name, @user_id)", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@user_id", SqlDbType.Int).Value = user_id;      
            
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

        //update group
        public bool updateGroup(int id, string name)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("UPDATE Groups SET name=@name WHERE Id=@id", db.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = name;

            adapter.UpdateCommand = command;

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

        //delete group
        public bool deleteGroup(int id)
        {         
            SqlCommand command = new SqlCommand("DELETE FROM Groups WHERE Id=@id", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

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

        //get group of userid
        public DataTable getGroupByUserId(int user_id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Groups WHERE User_id=" + user_id, db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tb = new DataTable();

            adapter.Fill(tb);
            return tb;
        }

        //get group
        
        public DataTable getGroups()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Groups WHERE", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tb = new DataTable();

            adapter.Fill(tb);
            return tb;
        }

        //check exist group
        public bool checkGroup(string name, string operation, int id = 0,  int user_id = 0)
        {
           
            string query = "";
            SqlCommand command = new SqlCommand();
            if(operation == "add")
            {
                query = "SELECT * FROM Groups WHERE Id=@id AND Name=@name";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                
            }
            else if(operation == "edit")
            {
                query = "SELECT * FROM Groups WHERE Id != @id AND User_id=@user_id AND Name=@name";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@user_id", SqlDbType.Int).Value = user_id;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            }

            command.Connection = db.getConnection;
            command.CommandText = query;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
