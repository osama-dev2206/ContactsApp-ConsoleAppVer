using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using static Contacts_App___Data_Access_Layer.clsDbSettings;

namespace Contacts_App___Data_Access_Layer
{
    public static class DataAccessForSearchContact
    {

        private static string Query()
        {
            return @"Select * from Contacts 
         where Contacts.ContactID= @ContactID;";
        }

        private static SqlCommand Cmd(int ContactID)
        {
            SqlCommand c = new SqlCommand(Query(), clsDbSettings.DbConnection);

            if(int.TryParse(ContactID.ToString(), out _))
             c.Parameters.AddWithValue("@ContactID", ContactID);

            else
                c.Parameters.AddWithValue("@ContactID", DBNull.Value);
           
            return c;
        }


        // return true if the command excuted successfully && there is record
        public static bool CheckContactOnDb(ref int ContactID, ref string FirstName, ref string LastName
            , ref string Email, ref string Phone, ref string Address, ref DateTime DateOfBirth,
            ref int CountryID,
            ref string? ImagePath)
        {
            bool IsExist = false;

#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                clsDbSettings.DbConnection.Open();
                SqlCommand Command = Cmd(ContactID);

                SqlDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    // change parametrs values by ref according to founded object 
                    ContactID = (int)Reader["ContactID"];
                    FirstName = (string)Reader["FirstName"];
                    LastName = (string)Reader["LastName"];
                    Email = (string)Reader["Email"];
                    Phone = (string)Reader["Phone"];
                    Address = (string)Reader["address"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    CountryID = (int)Reader["CountryID"];

                    if(Reader["ImagePath"] != DBNull.Value) // if the image path isn't null then add the value 
                    {
                        ImagePath = (string)Reader["ImagePath"]; // if it is null it will make an execption 
                    }
                    else
                    {
                        ImagePath = "";
                    }

                    IsExist = true;
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                IsExist = false;
            }
            finally
            {
                DbConnection.Close();
            }
#pragma warning restore CS0168 // Variable is declared but never used

            return IsExist;

        }

    }


}
