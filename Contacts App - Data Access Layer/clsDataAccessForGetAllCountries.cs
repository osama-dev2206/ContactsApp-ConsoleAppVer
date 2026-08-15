using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Contacts_App___Data_Access_Layer
{
    public  static  class clsDataAccessForGetAllCountries
    {
        private static string Query()
        {
            return @"Select * From Countries
              order by CountryID ASC; "; 
        }

        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();
            try
            {
                clsDbSettings.DbConnection.Open();
                SqlCommand cmd = new SqlCommand(Query(), clsDbSettings.DbConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader != null && reader.HasRows)
                {
                    dt.Load(reader);
                }

            }
            catch (Exception ex)
            {
            }
            finally
            {
                clsDbSettings.DbConnection.Close();
            }

            return dt; 
        }


    }

}
