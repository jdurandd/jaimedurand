using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using SistemaKardexInventario.UI.Models;
using System.Data;


namespace SistemaKardexInventario.UI.DataAccess
{
    public class DALC
    {   
        string conStr = ConfigurationManager.ConnectionStrings["SqlConecction"].ConnectionString;

        public int CheckUserLogin(User user)
        {
            using (SqlConnection conObj = new SqlConnection(conStr))
            {
                SqlCommand comObj = new SqlCommand("uspLogin", conObj);
                comObj.CommandType = CommandType.StoredProcedure;
                comObj.Parameters.Add(new SqlParameter("@UserName", user.UserID));
                comObj.Parameters.Add(new SqlParameter("@Password", user.Password));
                conObj.Open();
                return Convert.ToInt32(comObj.ExecuteScalar());
            }


        }
    }
}