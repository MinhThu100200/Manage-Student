using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class RESULT
    {
        COURSE course = new COURSE();
        STUDENT student = new STUDENT();
        SCORE score = new SCORE();
        MY_DB db = new MY_DB();

        public DataTable getScoreOfCourse()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT sc.Student_id, co.Label, sc.Score_student FROM Course as co, Score as sc "+
                "WHERE sc.Course_id = co.Id", db.getConnection);
            DataTable dt = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            return dt;
        }
        public DataTable getScoreOfCourseByStudent(int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT co.Label, sc.Score_student FROM Course as co, Score as sc " +
                "WHERE sc.Course_id = co.Id and sc.Student_id =" +id, db.getConnection);
            DataTable dt = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            return dt;
        }
        public DataTable searchStudentScore(int id, string fname)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT * FROM Student WHERE CONCAT(Firstname,' ',Lastname,' ',Address) LIKE '%" +  + "%'", db.getConnection);
            DataTable dt = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            return dt;
        }
    }

}
