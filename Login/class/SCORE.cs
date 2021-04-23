using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class SCORE
    {
        MY_DB db = new MY_DB();
        
        //insert score
        public bool insertScore(int studentId, int courseId, float score_student, string descriptions)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("INSERT INTO Score (Student_id, Course_id, Score_student, Descriptions)" +
                " VALUES (@student_id, @course_id, @score_student, @descriptions)", db.getConnection);
            command.Parameters.Add("@student_id", SqlDbType.Int).Value = studentId;
            command.Parameters.Add("@course_id", SqlDbType.Int).Value = courseId;
            command.Parameters.Add("@score_student", SqlDbType.Float).Value = score_student;
            command.Parameters.Add("@descriptions", SqlDbType.NVarChar).Value = descriptions;

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
        //get score
        public DataTable getScore()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT * FROM Score", db.getConnection);
            DataTable dt = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            return dt;
        }
        //check exsit
        public bool studentScoreExist(int studentId, int courseId)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Score WHERE Student_id = @sid AND Course_id = @cid", db.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentId;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseId;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tb = new DataTable();
            adapter.Fill(tb);

            if(tb.Rows.Count == 0)
            {
                return false;
            }    
            else
            {
                return true;
            }    
        }
        //Average
        public DataTable getAvgScoreByCourse()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = db.getConnection;
            command.CommandText = "SELECT Course.Label, AVG(Score.Score_student) as AverageGrade FROM Course, Score WHERE Course.Id =" + 
                "Score.Course_id GROUP BY Course.Label";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            return tb;         
        }
        //delete score by student id and course id
        public bool deleteScore(int studentId, int courseId)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Score WHERE Student_id = @sid and Course_id = @cid", db.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentId;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseId;
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
        //student and score
        public DataTable getStudentAndScore()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT st.ID, st.Firstname, st.Lastname, co.Id, co.Label, sc.Score_student FROM Score as sc, Student as st, Course as co "+
                "WHERE sc.Student_id = st.ID and sc.Course_id = co.Id", db.getConnection);
            DataTable dt = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            return dt;
        }
        
    }
}
