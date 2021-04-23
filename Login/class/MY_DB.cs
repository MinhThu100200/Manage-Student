using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class MY_DB
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-62EBFHC;Initial Catalog=QLSV;Integrated Security=True");
        
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }

        public void openConnection()
        {
            if ((con.State == System.Data.ConnectionState.Closed))
            {
                con.Open();
            }    
        }

        public void closeConnection()
        {
            if ((con.State == System.Data.ConnectionState.Open))
            {
                con.Close();
            }    
        }
    }
}
