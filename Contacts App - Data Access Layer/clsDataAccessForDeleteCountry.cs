using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Data_Access_Layer
{
    public static class clsDataAccessForDeleteCountry
    {
        private static string Query()
        {
            return @"Delete Countries 
            Where Countries.CountryID =  @CountryID ;";
        }

        public static bool DeleteCountryFromDb(int CountryID)
        {
            bool res = false;
            try
            {
                clsDbSettings.DbConnection.Open();
                SqlCommand cmd = new SqlCommand(Query(), clsDbSettings.DbConnection);
                cmd.Parameters.AddWithValue("@CountryID", CountryID);

                int NoOfAffectedRows = cmd.ExecuteNonQuery();

                if (clsDbSettings.CheckNumOfAffectedRows(NoOfAffectedRows))
                    res = true;

            }
            catch (Exception ex)
            {
                res= false;
            }
            finally
            {
                clsDbSettings.DbConnection.Close();
            }

            return res;

        }

    }
}
