using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class CONTACT
    {
        MY_DB db = new MY_DB();
        
        //insert contact
        public bool insertContact(int id, string fname, string lname, int group_id, string email, string phone, string addr, MemoryStream img, int user_id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("INSERT INTO Contact (Id, Firstname, Lastname, Group_id, Email, Phone, Address, Picture, User_id ) VALUES (@id, @fname, @lname, @group_id, @email, " +
                "@phone, @addr, @img, @user_id)", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@group_id", SqlDbType.Int).Value = group_id;            
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@phone", SqlDbType.NChar).Value = phone;
            command.Parameters.Add("@addr", SqlDbType.Text).Value = addr;
            command.Parameters.Add("@img", SqlDbType.Image).Value = img.ToArray();
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

        //update contact
        public bool updateContact(int id, string fname, string lname, int group_id, string email, string phone, string addr, MemoryStream img)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("UPDATE Contact SET Firstname=@fname, Lastname=@lname, Group_id=@group_id, Email=@email, Phone=@phone, Address=@addr, Picture=@img" +
                " WHERE Id=@id", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@group_id", SqlDbType.Int).Value = group_id;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@phone", SqlDbType.NChar).Value = phone;
            command.Parameters.Add("@addr", SqlDbType.Text).Value = addr;
            command.Parameters.Add("@img", SqlDbType.Image).Value = img.ToArray();
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

        //delete contact
        public bool deleteContact(int id)
        {          
            SqlCommand command = new SqlCommand("DELETE FROM Contact WHERE Id=@id", db.getConnection);
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

        //get full list contact
        public DataTable selectContactList(SqlCommand command)
        {
            command.Connection = db.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            return tb;
        }

        //get contact by id
        public DataTable getContactById(int id)
        {
            
            SqlCommand command = new SqlCommand("SELECT * FROM Contact WHERE Id=" + id, db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tb = new DataTable();

            adapter.Fill(tb);
            return tb;
        }


    }
}
