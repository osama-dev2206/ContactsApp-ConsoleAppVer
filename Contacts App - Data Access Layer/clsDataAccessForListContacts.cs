using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Contacts_App___Data_Access_Layer
{
    public static class clsDataAccessForListContacts
    {
        static string Query()
        {

            return @" SELECT Contacts.ContactID,
           CONCAT(Contacts.FirstName , ' ' , Contacts.LastName) As FullName ,
          Contacts.Email,
         Contacts.Phone,
       Contacts.Address,
       Cast (Contacts.DateOfBirth AS DATE) AS DateOfBirth,
       Contacts.ImagePath,
       Countries.CountryName , 
       Countries.Code ,
       Countries.PhoneCode
       FROM   Contacts
       INNER JOIN
       Countries
       ON Countries.CountryID = Contacts.CountryID;
        ";

        }

        public static DataTable GetAllContactsFromDbInDT()
        {
            DataTable dt = new DataTable();
            try
            {
                clsDbSettings.DbConnection.Open();
                SqlCommand cmd = new SqlCommand(Query(), clsDbSettings.DbConnection);

                SqlDataReader reader = cmd.ExecuteReader();

                if( reader!=null &&reader.HasRows) // returns T if the result set  has one or more row 
                {
                    dt.Load(reader);  // load the result set to data table 
                }

                if(reader != null)  
                    reader.Close();

            }
            catch (Exception ex) 
            { 
            }

            finally
            {
                clsDbSettings.DbConnection.Close();
            }

            return dt;
        }
        
    }
}
