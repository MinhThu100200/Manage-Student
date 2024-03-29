﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class USER
    {
        MY_DB db = new MY_DB();

        //Add user
        public bool insertUser(string fname, string lname, string username, string password, string email, string phone, string addr, MemoryStream img)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            
            SqlCommand command = new SqlCommand("INSERT INTO Users (Firstname, Lastname, Username, Password, Email, Phone, Address, Picture ) VALUES (@fname, " +
                "@lname, @username, @password, @email, @phone, @addr, @img)", db.getConnection);
            
            command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@username", SqlDbType.NChar).Value = username;
            command.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@phone", SqlDbType.NChar).Value = phone;
            command.Parameters.Add("@addr", SqlDbType.NVarChar).Value = addr;
            command.Parameters.Add("@img", SqlDbType.Image).Value = img.ToArray();

         
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

        //get user by id
        public DataTable getUserById(Int32 id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable tb = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE Id =" + id, db.getConnection);

            adapter.SelectCommand = command;
            adapter.Fill(tb);
            return tb;
        }

        //check exist user 

        public bool checkUser(string username, string operation, int id = 0)
        {
            
            SqlCommand command = new SqlCommand();
            if (operation == "signup")
            {
                command = new SqlCommand("SELECT * FROM Users WHERE Username = @username OR Id = @id", db.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            }
            else if (operation == "edit")
            {
                command = new SqlCommand("SELECT * FROM Users WHERE Id = @id", db.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            }
            //command.Connection = db.getConnection;
            //db.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable tb = new DataTable();
            
            adapter.SelectCommand = command;

            adapter.Fill(tb);

            if(tb.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //Update user
        public bool updateUser(int id, string fname, string lname, string username, string password, string email, string phone, string addr, MemoryStream img)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("UPDATE Users SET Firstname=@fname, Lastname=@lname, Username=@username, Password=@password," +
                " Email=@email, Phone=@phone, Address=@addr, Picture=@img WHERE Id = @id", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@username", SqlDbType.NChar).Value = username;
            command.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
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
    }
    
}
