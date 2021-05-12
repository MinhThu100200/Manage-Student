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
        public bool insertCourse(int id, string label, int period, string description, string semes)
        {
            
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("INSERT INTO Course (Id, Label, Period, Description, Semester)" +
                " VALUES (@id, @label, @period, @description, @semes)", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
            command.Parameters.Add("@period", SqlDbType.Int).Value = period;
            command.Parameters.Add("@description", SqlDbType.NVarChar).Value = description;
            command.Parameters.Add("@semes", SqlDbType.NVarChar).Value = semes;

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
        //get course by semester
        public DataTable getCoursesAvailible(int id, string semester)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("select co.Id, co.Label from Course as co Where Semester = @semes except select co.Id, co.Label " +
                "from Course as co, Course_Student as cs Where cs.Course_id = co.Id and co.Semester = @semes and cs.Student_id = @id", db.getConnection);
            command.Parameters.Add("@semes", SqlDbType.NVarChar).Value = semester;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            DataTable dt = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            return dt;
        }
        //add course_student
        public bool insertCourseStudent(int courseid, int studentid )
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("INSERT INTO Course_Student (Course_id, Student_id)" +
                " VALUES (@courseid, @studentid)", db.getConnection);
            command.Parameters.Add("@courseid", SqlDbType.Int).Value = courseid;
           
            command.Parameters.Add("@studentid", SqlDbType.Int).Value = studentid;
           

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

        //get course by semester and id student
        public DataTable getCoursesSelected(int id, string semester)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("select co.Id, co.Label from Course as co, Course_Student as cs " +
                "Where co.Semester = @semes and cs.Student_id = @id and cs.Course_id = co.Id", db.getConnection);
            command.Parameters.Add("@semes", SqlDbType.NVarChar).Value = semester;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
        //get student with lable and semester

        public DataTable getIdStudentByLable(string lable, string semester)
        {

            DataTable dt = new DataTable();
            
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("select st.Id, st.Firstname, st.Lastname, st.Birthdate, st.Gender from Student as st, Course as co, Course_Student as cs " +
                "where co.Label = @name and co.Semester = @semes and co.Id = cs.Course_id and st.Id = cs.Student_id", db.getConnection);
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = lable;
            command.Parameters.Add("@semes", SqlDbType.NVarChar).Value = semester;
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            return dt;
           
        }


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
