using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Data_Access_Layer
{
    public static class clsDataAccessDeleteContact
    {
        private static string Query()
        {
            return @"delete From Contacts
              where ContactID = @ContactID;";
        }

        private static  SqlCommand cmd (int ContactID)
        {
            SqlCommand cmd = new SqlCommand (Query() , clsDbSettings.DbConnection);
            cmd.Parameters.AddWithValue("@ContactID", ContactID);
            return cmd; 
        }

        public static bool DeleteContactFromDb(int ContactID)
        {
            int NoOfAffectedRows = 0;
            try
            {
                clsDbSettings.DbConnection.Open();
                SqlCommand c = cmd(ContactID);
                NoOfAffectedRows = c.ExecuteNonQuery();

            }
            catch (Exception ex) { }
            finally
            {
                clsDbSettings.DbConnection.Close();
            }
            return (clsDbSettings.CheckNumOfAffectedRows(NoOfAffectedRows));

        }


    }
}
