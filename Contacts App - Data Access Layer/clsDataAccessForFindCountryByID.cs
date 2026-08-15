using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Data_Access_Layer
{
    public static class clsDataAccessForFindCountryByID
    {
        private static string Query()
        {
            return @"Select *
                  from Countries
             where Countries.CountryID= @CountryID ; ";
        }

        public static bool FindCountryByID(int CountryID , ref string CountryName, ref string Code, ref string PhoneCode)
        {
            bool res = false;
            try
            {
                clsDbSettings.DbConnection.Open();
                SqlCommand cmd = new SqlCommand(Query(), clsDbSettings.DbConnection);

                if(int.TryParse(CountryID.ToString(), out _ ))
                 cmd.Parameters.AddWithValue("@CountryID", CountryID);
                else
                    cmd.Parameters.AddWithValue("@CountryID", DBNull.Value);

                SqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    if (DBNull.Value != Reader["CountryID"])
                    {
                        CountryID = (int)Reader["CountryID"];
                    }
                    else
                    {
                        CountryID = 0;
                    }

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

                    if (Reader["CountryName"] != DBNull.Value)
                    {
                        CountryName = (string)Reader["CountryName"];
                    }
                    else
                    {
                        CountryName = "";
                    }

                    res = true;
                }

                Reader.Close();
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
