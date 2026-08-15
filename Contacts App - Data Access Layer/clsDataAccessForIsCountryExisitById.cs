using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Data_Access_Layer
{
    public  static class clsDataAccessForIsCountryExisitById
    {
        private static string Query()
        {
            return @"Select R='T'
             from Countries 
          Where Countries.CountryID = @CountryID ;  ";
        }

        public static bool IsCountryExistByID(int  CountryID)
          {            
            bool res = false;

            try
            {
                clsDbSettings.DbConnection.Open();
                SqlCommand cmd = new SqlCommand(Query(), clsDbSettings.DbConnection);

                if(int.TryParse(CountryID.ToString(), out _ ))
                 cmd.Parameters.AddWithValue("@CountryID", CountryID);
                else
                  cmd.Parameters.AddWithValue("@CountryID", DBNull.Value);

                object R = cmd.ExecuteScalar();
                if (R != null && R.ToString() == "T")
                {
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

            return res; ; 

            }


    }
}
