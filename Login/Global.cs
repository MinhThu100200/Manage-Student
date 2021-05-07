using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Global
    {
        public static int GlobalUserID { get; private set; }

        public static void SetGlobalUserID(int userID)
        {
            GlobalUserID = userID;
        }
    }
}
