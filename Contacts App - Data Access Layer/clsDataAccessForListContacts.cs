using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Contacts_App___Data_Access_Layer
{
    public static class clsDataAccessForListContacts
    {
        static string Query()
        {
            return @"Select * From Contacts;";
        }

        public static DataTable GetAllContactsFromDbInDT()
        {
            DataTable dt = new DataTable();
            try
            {
                clsDbSettings.DbConnection.Open();
                SqlCommand cmd = new SqlCommand(Query(), clsDbSettings.DbConnection);

                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.HasRows) // returns T if the result has one or more row 
                {
                    dt.Load(reader); 
                }
                reader.Close();
            }
            catch (Exception ex) 
            { 
            }

            finally
            {
                clsDbSettings.DbConnection.Close();
            }

        }
        
    }
}
