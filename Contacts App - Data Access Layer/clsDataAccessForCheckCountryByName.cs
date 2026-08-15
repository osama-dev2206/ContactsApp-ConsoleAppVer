using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Data_Access_Layer
{
    public  static class clsDataAccessForCheckCountryByName
    {
        static private string Query()
        {
            return @"select R = 'T' 
          From Countries
            where LOWER(Countries.CountryName)= Lower(@CountryName); ";
        }

        public static bool IsCountryExisitByName(string ?CountryName)
        {
            bool result = false;
            try
            {
                clsDbSettings.DbConnection.Open();
                SqlCommand cmd = new SqlCommand(Query(), clsDbSettings.DbConnection);
                cmd.Parameters.AddWithValue("@CountryName", CountryName);

                object res = cmd.ExecuteScalar(); // (query) will return one column only which indicates that the record is exist or null 
                if (res != null && res.ToString() == "T")
                {
                    result = true;
                }

            }
            catch (Exception ex)
            {
                result=false;
            }
            finally
            {
                clsDbSettings.DbConnection.Close();
            }
            return result;
            
        }


    }
}
