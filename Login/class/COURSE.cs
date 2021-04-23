using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class COURSE
    {
        MY_DB db = new MY_DB();

        //insert course
        public bool insertCourse(int id, string label, int period, string description)
        {
            
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("INSERT INTO Course (Id, Label, Period, Description)" +
                " VALUES (@id, @label, @period, @description)", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
            command.Parameters.Add("@period", SqlDbType.Int).Value = period;
            command.Parameters.Add("@description", SqlDbType.NVarChar).Value = description;

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
        //get course
        public DataTable getCourses()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT * FROM Course", db.getConnection);
            DataTable dt = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            return dt;
        }
        //get course by id

        public DataTable getCourseById(int id)
        {
            
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE ID = " + id, db.getConnection);

                adapter.SelectCommand = command;
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            dt = getCourses();
            return dt;
        }
        //
        
        //check exist
        public bool checkId(int id)
        {
            DataTable dt = getCourseById(id);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        //Delete course
        public bool deleteCourse(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Course WHERE Id = @id", db.getConnection);
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
        //Edit course
        public bool editCourse(int id, string label, int period, string description)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("UPDATE Course SET Id=@id, Label=@label, Period=@period, Description=@description WHERE Id=@id", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
            command.Parameters.Add("@period", SqlDbType.Int).Value = period;
            command.Parameters.Add("@description", SqlDbType.NVarChar).Value = description;

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
