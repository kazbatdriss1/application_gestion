using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace application_gestion
{
    class conixon
    {
        public static SqlConnection cx = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=application_gestion_Y;Integrated Security=True");

        public static void opencx()
        {
            if (cx.State != ConnectionState.Open)
            {
                cx.Open();
            }
        }
        public static void closncx()
        {
            if (cx.State != ConnectionState.Closed)
            {
                cx.Close();
            }
        }
    }
}
