using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Data_Access_Layer
{
    public static  class clsDataAccessForIsContactExist
    {

        private static string Query()
        {
            return @"select x='T'
             from Contacts 
             where Contacts.ContactID =@ContactID ;";
        }

        public static bool IsContactExist(int ContactID )
         {
            bool result = false;
            try
            {
                clsDbSettings.DbConnection.Open();
                SqlCommand cmd = new SqlCommand(Query(), clsDbSettings.DbConnection);

                object Ereader = cmd.ExecuteScalar();
                if (Ereader != null && Ereader.ToString() == "T" )
                {
                    result=true; 
                }

            }
            catch (Exception ex)
            {
                result=false;
            }
            finally
            {
                clsDbSettings.DbConnection.Close();
            }

            return result;
        }

    }
}
