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
    class CONTACT
    {
        MY_DB db = new MY_DB();
        
        //insert contact
        public bool insertContact(int id, string fname, string lname, int group_id, string email, string phone, string addr, MemoryStream img, int user_id, int courseid)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("INSERT INTO Contact (Id, Firstname, Lastname, Group_id, Email, Phone, Address, Picture, User_id, Course_id ) VALUES (@id, @fname, @lname, @group_id, @email, " +
                "@phone, @addr, @img, @user_id, @courseid)", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@group_id", SqlDbType.Int).Value = group_id;            
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@phone", SqlDbType.NChar).Value = phone;
            command.Parameters.Add("@courseid", SqlDbType.Int).Value = courseid;
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
        public bool updateContact(int id, string fname, string lname, int group_id, string email, string phone, string addr, MemoryStream img, int courseid)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("UPDATE Contact SET Firstname=@fname, Lastname=@lname, Group_id=@group_id, Email=@email, Phone=@phone, Address=@addr, Picture=@img" +
                " Course_id = @courseid WHERE Id=@id", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@group_id", SqlDbType.Int).Value = group_id;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@phone", SqlDbType.NChar).Value = phone;
            command.Parameters.Add("@courseid", SqlDbType.Int).Value = courseid;
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

        //check exist contact
        public bool checkContact(int id, string operation)
        {
            string query = "";
            if(operation == "add")
            {
                query = "SELECT * FROM Contact WHERE Id=@id";

            }
            else if(operation == "edit")
            {
                query = "SELECT * FROM Contact WHERE Id != @id";
            }

            SqlCommand command = new SqlCommand(query, db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            DataTable dt = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);
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
        //get course avai contact can teach
        public DataTable getCourseByContact()
        {

            SqlCommand command = new SqlCommand("select co.Id, co.Label from Course as co except select ct.Course_id, co.Label from Course as co, Contact as ct " +
                "where co.Id = ct.Course_id", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tb = new DataTable();

            adapter.Fill(tb);
            return tb;
        }
        //get student of one contact

        public DataTable getStudentByContact(int courseid)
        {

            SqlCommand command = new SqlCommand("select st. Id, st.Firstname, st.Lastname, st.Birthdate, st.Gender, st.Phone, st.Address, st.Picture from Student as st, Course_Student as cs, Contact as ct where " +
                "ct.Id = @id and ct.Course_id = cs.Course_id and st.Id = cs.Student_id", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = courseid;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tb = new DataTable();

            adapter.Fill(tb);
            return tb;
        }

    }
}
