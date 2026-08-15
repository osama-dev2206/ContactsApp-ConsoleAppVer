using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Data_Access_Layer
{
    public static class clsDataAccessForAddCountry
    {
        private static string Query()
        {
            return @"
             Insert Into Countries (CountryName)
             values (@CountryName);
              Select SCOPE_IDENTITY()";
        }

        private static bool IsCountryAlreadyExist(string CountryName)
        {
            bool Exisit = false;
            string query =  @"Select R='T'
              from Countries
             where Lower(CountryName) = lower(@CountryName)";

            try
            {
                clsDbSettings.DbConnection.Open();
                SqlCommand cmd = new SqlCommand(query, clsDbSettings.DbConnection);
                cmd.Parameters.AddWithValue("@CountryName", CountryName);

                object R = cmd.ExecuteScalar();
                if (R != null && R.ToString() == "T")
                {
                    Exisit = true; // as the country already exists so we don't need to insert it again 
                }
                else
                {
                    Exisit = false; // as this country isn't exisit 
                }

            }
            catch (Exception ex) // as this country isn't exisit 
            {
                Exisit = false ;
            }
            finally
            {
                clsDbSettings.DbConnection.Close();
            }
            return Exisit;

        }

        public static int AddNewCountryToDb(string CountryName)
        {
            int TheLastIdentityFromDb = -1;

            // as country already exist then don't add it 
            if(IsCountryAlreadyExist(CountryName)) return TheLastIdentityFromDb;
             
            try
            {
                clsDbSettings.DbConnection.Open();
                SqlCommand cmd = new SqlCommand(Query(), clsDbSettings.DbConnection);
                cmd.Parameters.AddWithValue("@CountryName", CountryName);

                var R = cmd.ExecuteScalar();

                if (R != null && int.TryParse(R.ToString(), out int Id))
                {
                    TheLastIdentityFromDb = Id;
                }

            }
            catch (Exception ex)
            {
                TheLastIdentityFromDb = -1;
            }
            finally
            {
                clsDbSettings.DbConnection.Close();
            }
            return TheLastIdentityFromDb; 

        }


    }
}
