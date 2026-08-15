using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Data_Access_Layer
{
    public static class clsDataAccessForFindCountryByID
    {
        private static string Query()
        {
            return @"Select Countries.CountryName 
                  from Countries
             where Countries.CountryID= @CountryID ; ";
        }

        public static bool FindCountryByID(int CountryID , ref string ? CountryName)
        {
            bool res = false;
            try
            {
                clsDbSettings.DbConnection.Open();
                SqlCommand cmd = new SqlCommand(Query(), clsDbSettings.DbConnection);
                cmd.Parameters.AddWithValue("@CountryID", CountryID);

                object r = cmd.ExecuteScalar();
                if (r != null)
                {
                    CountryName = r.ToString();
                    res = true;
                }

            }
            catch (Exception ex)
            {
                res = false;
            }

            finally
            {
                clsDbSettings.DbConnection.Close();
            }

            return res; 
        }

    }
}
