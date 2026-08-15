using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Data_Access_Layer
{
    public static  class clsDataAccessForUpdateCountry
    {
        private static string Query()
        {
            return @"Update Countries
                Set 
             CountryName = @CountryName  ,  
             Code = @Code   , PhoneCode = @PhoneCode
              WHERE CountryID = @CountryID ";
        }

        public static bool UpdateCountryOnDb(string CountryName , int CountryID , string PhoneCode , string Code  )
        {
            bool res = false;
            try
            {
                clsDbSettings.DbConnection.Open();
                SqlCommand cmd = new SqlCommand( Query() , clsDbSettings.DbConnection);
                cmd.Parameters.AddWithValue("@CountryName",CountryName);
                cmd.Parameters.AddWithValue("@CountryID", CountryID);
                cmd.Parameters.AddWithValue("@PhoneCode", PhoneCode);
                cmd.Parameters.AddWithValue("@Code", Code);

                int  NumOfAffectedRows = cmd.ExecuteNonQuery();
                if (clsDbSettings.CheckNumOfAffectedRows(NumOfAffectedRows ) )
                {
                    res = true;
                }

            }
            catch (Exception e)
            {
                res = false;
            }
            finally
            {
                clsDbSettings.DbConnection.Close();
            }

          return  res ;

        }


    }
}
