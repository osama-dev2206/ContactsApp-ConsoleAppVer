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
            return clsDataAccessForCheckCountryByName.CheckCountryByName(CountryName) ; // check if the country already in db or not :)
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
