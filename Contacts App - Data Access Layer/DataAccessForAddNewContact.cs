using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Contacts_App___Data_Access_Layer
{
    public static class DataAccessForAddNewContact // Data Access Logic 
    {
        private static string Query()
        {
            return @"Insert Into Contacts(FirstName, LastName, Email, Phone, Address, DateOfBirth, CountryID, ImagePath)
           values( Lower(@FirstName) , Lower(@LastName) ,  @Email , @Phone , @Address ,  @DateOfBirth  , @CountryID  ,   @ImagePath  );
            Select SCOPE_IDENTITY();";
        }


        public static  int AddNewContactToDB(  string FirstName,  string LastName,
             string Email,  string Phone,  string Address, DateTime DateOfBirth,  int CountryID,  string ImagePath)
        {
           
           int  ID = -1; 
            try
            {
                clsDbSettings.DbConnection.Open ();
                SqlCommand c = clsDbSettings.Command(Query(),FirstName , LastName , Email , Phone , Address , DateOfBirth , CountryID , ImagePath);

               object Result = c.ExecuteScalar(); // execute the query and returns the scope identity 

                // check if the excution was done 
                if ( Result !=null && int.TryParse(Result.ToString() , out int ContactID) ) 
                {
                    ID = ContactID;
                }

            }
            catch (Exception ex) 
            {
                ID = -1; 
            }

            finally
            {
                clsDbSettings.DbConnection.Close(); 
            }

            return ID; 
        }


    }



}
