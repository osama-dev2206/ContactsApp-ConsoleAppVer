using Contacts_App___Bussiness_Layer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Console_App_Ver
{
    internal static class clsFindCountryByIDScreen
    {
        public static void ShowFindByIDScreen()
        {
            clsScreenUtils.PrintMenuOption("  Find Country By ID");

            Console.Write("\nEnter Country ID: ");
            int.TryParse(Console.ReadLine(), out int ID);

            clsCountries?c =clsCountries.FindCountryByID(ID) ;
            if (c != null )
            {
                Console.WriteLine($"\n\t\t\t\t\tthe Country Id Is {c.CountryID} ");
                Console.WriteLine($"\t\t\t\t\tThe Country Name Is: {c.CountryName}");
            }
            else
            {
                Console.WriteLine("\n\t\t\t\t\tFailed To Get Data!\a");
            }

        }
    }
}
