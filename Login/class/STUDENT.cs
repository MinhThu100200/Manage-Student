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
    class STUDENT
    {
        MY_DB db = new MY_DB();
        //insert student
        public bool insertStudent(int Id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("INSERT INTO Student (ID, FirstName, LastName, BirthDate, Gender, Phone, Address, Picture)" +
                " VALUES (@id, @fname, @lname, @bdate, @gender, @phone, @address, @picture)", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate.Date;
            command.Parameters.Add("@gender", SqlDbType.NChar).Value = gender;
            command.Parameters.Add("@phone", SqlDbType.Char).Value = phone;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@picture", SqlDbType.Image).Value = picture.ToArray();

            adapter.InsertCommand = command;
            db.openConnection();

            if  ((command.ExecuteNonQuery() == 1))
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
        //Get Student by gender and birthdate
        public DataTable getStudentGenderBirthdate(DateTime date1, DateTime date2, string gender)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT * FROM Student WHERE Gender = @gender and Birthdate between @date1 and @date2", db.getConnection);
            command.Parameters.Add("@date1", SqlDbType.DateTime).Value = date1.Date;
            command.Parameters.Add("@date2", SqlDbType.DateTime).Value = date2.Date;
            command.Parameters.Add("@gender", SqlDbType.NChar).Value = gender;
            DataTable dt = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            return dt;

        }
        //Get All of students 
        public DataTable getStudent()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT * FROM Student", db.getConnection);
            DataTable dt = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            return dt;
        }
        //get students with some atribute
        public DataTable getStudentWithSomeAtribute()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT ID, Firstname, Lastname FROM Student", db.getConnection);
            DataTable dt = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            return dt;
        }
        //Get student by ID
        public DataTable getStudentId(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand("SELECT * FROM Student WHERE ID = " + id, db.getConnection);
               
                adapter.SelectCommand = command;
                adapter.Fill(dt);
                return dt;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            dt = getStudent();
            return dt;
        }
        //Get student by gender
        public DataTable getStudentGender(string gender)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT * FROM Student WHERE Gender = @gender", db.getConnection);
            command.Parameters.Add("@gender", SqlDbType.NChar).Value = gender;
            DataTable dt = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            return dt;
        }

        //Get student by BirthDate
        public DataTable getStudentBirthDate(DateTime date1, DateTime date2)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT * FROM Student WHERE Birthdate between @date1 and @date2", db.getConnection);
            command.Parameters.Add("@date1", SqlDbType.DateTime).Value = date1.Date;
            command.Parameters.Add("@date2", SqlDbType.DateTime).Value = date2.Date;
            DataTable dt = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            return dt;
        }
        public DataTable getStudentSearch(string search)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT * FROM Student WHERE CONCAT(Firstname,' ',Lastname,' ',Address) LIKE '%" + search +"%'", db.getConnection);           
            DataTable dt = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            return dt;
        }
        //Delete student by ID
        public bool deleteStudent(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Student WHERE ID = @id", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            db.openConnection();
            if((command.ExecuteNonQuery() == 1))
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
        //Update Student
        public bool updateStudent(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("UPDATE Student SET FirstName=@fn,LastName=@ln,BirthDate=@bdate,Gender=@gender,Phone=@phone,Address=@address,Picture=@pic WHERE ID=@id", db.getConnection);
            
            command.Parameters.Add("id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender;
            command.Parameters.Add("@phone", SqlDbType.Char).Value = phone;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            adapter.UpdateCommand= command;
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
        //Total student
        public int totalStudent()
        {
            try
            {
                DataTable dt = getStudent();
                return dt.Rows.Count;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return 0;
            
        }
        //Total student female
        public int totalStudentFemale()
        {
            try
            {
                DataTable dt = getStudentGender("Female");
                return dt.Rows.Count;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return 0;
            
        }
        //Total student male
        public int totalStudentMale()
        {
            try
            {
                DataTable dt = getStudentGender("Male");
                return dt.Rows.Count;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return 0;
            
        }

    }
}
