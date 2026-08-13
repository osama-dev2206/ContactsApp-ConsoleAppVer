using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Contacts_App___Data_Access_Layer
{
    internal static class clsDbSettings
    {
        public static string ConnectionString =
      @"Server=OSAMA-PC;Database=ContactsDB;Integrated Security=True;TrustServerCertificate=True;";

        static public SqlConnection DbConnection = new SqlConnection(clsDbSettings.ConnectionString);

        public static bool CheckNumOfAffectedRows(int NumOfAffectedRows)
        {
            return (NumOfAffectedRows > 0);
        }


    }
}
