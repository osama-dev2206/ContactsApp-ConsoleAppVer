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
            return @"Insert Into Countries (CountryName,Code,PhoneCode)
            values ( @CountryName , UPPER(@Code)   , @PhoneCode   )
              Select SCOPE_IDENTITY();";
        }

        private static bool IsCountryAlreadyExist(string CountryName)
        {
            return clsDataAccessForCheckCountryByName.IsCountryExisitByName(CountryName) ; // check if the country already in db or not :)
        }

        public static int AddNewCountryToDb(string CountryName , string Code , string PhoneCode)
        {
            int TheLastIdentityFromDb = -1;

            // as country already exist then don't add it 
            if(IsCountryAlreadyExist(CountryName)) return TheLastIdentityFromDb;
             
            try
            {
                clsDbSettings.DbConnection.Open();
                SqlCommand cmd = new SqlCommand(Query(), clsDbSettings.DbConnection);
                
                if(CountryName != "")
                cmd.Parameters.AddWithValue("@CountryName", CountryName);
                else 
                 cmd.Parameters.AddWithValue("@CountryName", DBNull.Value);

                if(Code != "")
                cmd.Parameters.AddWithValue("@Code", Code);
                else
                 cmd.Parameters.AddWithValue("@Code", DBNull.Value);

                if(PhoneCode != "")
                cmd.Parameters.AddWithValue("@PhoneCode", PhoneCode); 
                else
                 cmd.Parameters.AddWithValue("@PhoneCode", DBNull.Value);


                var R = cmd.ExecuteScalar(); // execute the query and get the last identity from db

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
