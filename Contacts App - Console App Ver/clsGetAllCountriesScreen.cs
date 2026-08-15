using Contacts_App___Bussiness_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Contacts_App___Console_App_Ver
{
    internal static  class clsGetAllCountriesScreen
    {
        static private void PrintHeader()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\t{0,-12}{1,-15}{2,-12}{3,-10}", "CountryID", "CountryName", "PhoneCode", "Code");
        }
        static public void  ShowAllCountries()
        {
            clsScreenUtils.PrintMenuOption("              Get All Countries ");

            PrintHeader();
            Console.WriteLine(); 

            DataTable dt = clsCountries.GetAllCountries();
            if( dt != null )
            {
                foreach (DataRow Row in dt.Rows )
                {
                    Console.WriteLine("\t\t\t\t\t\t{0,-12}{1,-15}{2,-12}{3,-10}", Row["CountryID"], Row["CountryName"], Row["PhoneCode"], Row["Code"]);
                }
            }
            else
            {
                Console.WriteLine("\n\t\t\t\tFailed To Get Data \a") ;
            }

        }

    }
}
