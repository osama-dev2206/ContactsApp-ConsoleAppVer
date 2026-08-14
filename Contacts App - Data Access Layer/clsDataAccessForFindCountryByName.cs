using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Data_Access_Layer
{
    public static class clsDataAccessForFindCountryByName
    {
        static private string Query() 
        {
            return @"Select Countries.CountryID 
              From Countries
                Where Lower(Countries.CountryName) = Lower(@CountryName ) ;";
        }


        public static bool  FindCountryByName(string CountryName , ref int CountryID )
        {
            bool res = false;
            try
            {
                clsDbSettings.DbConnection.Open();
                SqlCommand cmd = new SqlCommand(Query(), clsDbSettings.DbConnection);
                cmd.Parameters.AddWithValue("@CountryName", CountryName);

                object reader = cmd.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int Country_ID) )
                {
                    CountryID = Country_ID;
                    res=true;
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
