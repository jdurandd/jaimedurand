using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;


namespace SistemaKardexInventario.UI.DataAccess
{
    public class DALC
    {
        static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConecction"].ToString());

        public static bool UserIsValid(string username, string password)
        {
            bool authenticated = false;

            string query = string.Format("SELECT * FROM [User] WHERE Username = '{0}' AND Password = '{1}'", username, password);

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            authenticated = sdr.HasRows;
            conn.Close();
            return (authenticated);
        }
    }
}