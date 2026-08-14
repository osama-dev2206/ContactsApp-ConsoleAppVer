using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Data_Access_Layer
{
    public static class clsDataAccessForFindCountryByName
    {
        static private string Query() 
        {
            return @"Select  * 
              From Countries
                Where Countries.CountryName like Lower('% @CountryName %');;
              ;";
        }


        public static bool  FindCountryByName(string CountryName , ref int CountryID )
        {
            bool res = false;
            try
            {
                
            }
        }


    }
}
