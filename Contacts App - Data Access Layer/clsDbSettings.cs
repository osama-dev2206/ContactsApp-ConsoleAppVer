using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Contacts_App___Data_Access_Layer
{
    internal static class clsDbSettings
    {
        private static string ConnectionString =
      @"Server=OSAMA-PC;Database=ContactsDB;Integrated Security=True;TrustServerCertificate=True;";

        static public SqlConnection DbConnection = new SqlConnection(clsDbSettings.ConnectionString);

        public static bool CheckNumOfAffectedRows(int NumOfAffectedRows)
        {
            return (NumOfAffectedRows > 0);
        }


        public static SqlCommand Command(string Query,string FirstName, string LastName,
     string Email, string Phone, string Address,
     DateTime DateOfBirth, int CountryID, string ImagePath)
        {

            SqlCommand cmd = new SqlCommand(Query, clsDbSettings.DbConnection);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("CountryID", CountryID);
            if (ImagePath != null || ImagePath != string.Empty)
            {
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value); // pass the image path as null in db if there isn't value 

            }

            return cmd;
        }



        public static SqlCommand Command(string Query, int ContactID,string FirstName, string LastName,
string Email, string Phone, string Address,
DateTime DateOfBirth, int CountryID, string ImagePath)
        {

            SqlCommand cmd = new SqlCommand(Query, clsDbSettings.DbConnection);
            if(FirstName != null && FirstName!="") 
             cmd.Parameters.AddWithValue("@FirstName", FirstName);
            else
                cmd.Parameters.AddWithValue("@FirstName", DBNull.Value); // pass the first name as null in db if there isn't value 
            
            if(LastName != null && LastName != "")
                cmd.Parameters.AddWithValue("@LastName", LastName);
            else
                cmd.Parameters.AddWithValue("@LastName", DBNull.Value); // pass the last name as null in db if there isn't value

            if(Email != null && Email != "")
                cmd.Parameters.AddWithValue("@Email", Email);
            else
                cmd.Parameters.AddWithValue("@Email", DBNull.Value); // pass the email as null in db if there isn't value

            if (Phone != null && Phone != "")
                cmd.Parameters.AddWithValue("@Phone", Phone);
            else
                cmd.Parameters.AddWithValue("@Phone", DBNull.Value); // pass the phone as null in db if there isn't value

            if(!String.IsNullOrEmpty(Address))
                cmd.Parameters.AddWithValue("@Address", Address);
            else
                cmd.Parameters.AddWithValue("@Address", DBNull.Value); // pass the address as null in db if there isn't value
          
            if(DateOfBirth != null)
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            else
                cmd.Parameters.AddWithValue("@DateOfBirth", DBNull.Value); // pass the date of birth as null in db if there isn't value

            if ( int.TryParse(CountryID.ToString() , out _ ) )
                cmd.Parameters.AddWithValue("CountryID", CountryID);
            else
                cmd.Parameters.AddWithValue("CountryID", DBNull.Value); // pass the country id as null in db if there isn't value


            if(ImagePath != null && ImagePath != string.Empty)
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value); // pass the image path as null in db if there isn't value 
       

            if(int.TryParse(ContactID.ToString(), out _) )
             cmd.Parameters.AddWithValue("@ContactID", ContactID);
            else
                cmd.Parameters.AddWithValue("@ContactID", DBNull.Value); // pass the contact id as null in db if there isn't value


            return cmd;
        }






    }
}
