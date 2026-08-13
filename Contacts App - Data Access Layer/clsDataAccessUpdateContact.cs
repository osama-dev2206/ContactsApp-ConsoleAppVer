using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Contacts_App___Data_Access_Layer
{
    public static class clsDataAccessUpdateContact
    {
        private static string Query()
        {
            return @"
          Update Contacts 
           set Email= @Email  , FirstName = @FirstName , LastName = @LastName ,
           Phone = @Phone  , Address = @Address , DateOfBirth = @DateOfBirth , CountryID =  @CountryID , ImagePath = @ImagePath
           where ContactID = @ContactID;";
        }

        public static bool UpdateContactInDb(int ContactID, string FirstName, string LastName,
             string Email, string Phone, string Address, DateTime DateOfBirth, int CountryID, string ImagePath)
        {
            int NoAffectedRows = 0;
            try
            {
                clsDbSettings.DbConnection.Open();
                SqlCommand cmd = clsDbSettings.Command(Query(),ContactID, FirstName, LastName, Email, Phone, Address, DateOfBirth, CountryID, ImagePath);
                NoAffectedRows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
            }
            finally
            {
                clsDbSettings.DbConnection.Close(); 
            }

            return clsDbSettings.CheckNumOfAffectedRows(NoAffectedRows);

        }

    }
}
