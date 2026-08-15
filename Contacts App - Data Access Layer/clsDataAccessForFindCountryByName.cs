using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Data_Access_Layer
{
    public static class clsDataAccessForFindCountryByName
    {
        static private string Query() 
        {
            return @"Select *
              From Countries
                Where Lower(Countries.CountryName) = Lower(@CountryName ) ;";
        }


        public static bool  FindCountryByName(string CountryName , ref int CountryID , ref string Code, ref string PhoneCode)
        {
            bool res = false;
            try
            {
                clsDbSettings.DbConnection.Open();
                SqlCommand cmd = new SqlCommand(Query(), clsDbSettings.DbConnection);
                cmd.Parameters.AddWithValue("@CountryName", CountryName);

                SqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    CountryID = (int)Reader["CountryID"];
                    if (Reader["Code"] != DBNull.Value)
                    {
                        Code = (string)Reader["Code"];
                    }
                    else
                    {
                        Code = "";
                    }

                    if (Reader["PhoneCode"] != DBNull.Value)
                    {
                        PhoneCode = (string)Reader["PhoneCode"];
                    }
                    else
                    {
                        PhoneCode = "";
                    }

                    res = true;
                }




            }
            catch (Exception ex)
            {
                res = false;
            }

            finally
            {
                clsDbSettings.DbConnection.Close();
            }

            return res; 

        }


    }
}
