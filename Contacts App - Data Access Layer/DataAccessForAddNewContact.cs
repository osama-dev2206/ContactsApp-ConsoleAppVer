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
           values( @FirstName , @LastName ,  @Email , @Phone , @Address ,  @DateOfBirth  , @CountryID  ,   @ImagePath  );
            Select SCOPE_IDENTITY();";
        }

        private static SqlCommand Command (  string FirstName,  string LastName,
             string Email,  string Phone,  string Address,
             DateTime DateOfBirth,  int CountryID,  string ImagePath) 
        {

            SqlCommand cmd = new SqlCommand (Query() , clsDbSettings.DbConnection);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("CountryID", CountryID);
            if (ImagePath !=null || ImagePath!=string.Empty )
            {
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else 
            {
                cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value); // pass the image path as null in db if there isn't value 

            }

            return cmd;
        }


        public static  int AddNewContactToDB(  string FirstName,  string LastName,
             string Email,  string Phone,  string Address,
             DateTime DateOfBirth,  int CountryID,  string ImagePath)
        {
           
           int  ID = -1; 
            try
            {
                clsDbSettings.DbConnection.Open ();
                SqlCommand c = Command(FirstName , LastName , Email , Phone , Address , DateOfBirth , CountryID , ImagePath);

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
