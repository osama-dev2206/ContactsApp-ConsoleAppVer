using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Contacts_App___Data_Access_Layer
{
    internal static class clsDbSettings
    {
        public static string ConnectionString =
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
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("CountryID", CountryID);
            cmd.Parameters.AddWithValue("@ContactID", ContactID);
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






    }
}
