using Contacts_App___Bussiness_Layer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Console_App_Ver
{
    internal static  class clsUpdateCountryScreen
    {
        public static void ShowUpdateCountry()
        {
            clsScreenUtils.PrintMenuOption("   Update Country");

            Console.Write("\nEnter Country Name: ");
            string? name = Console.ReadLine();

            clsCountries ? country = clsCountries.FindCountryByName(name);

            if (country != null)
            {

                Console.Write("\n\t\t\t\t\tCountry Exists !\n");

                Console.Write("\nEnter New Country Name: ");
                country.CountryName = Console.ReadLine();

                country.Save(); // save the new update 

                Console.Write("\n\t\t\t\t The Update Has Done  !  \n");
            }
            else
            {
                Console.Write("\a\n\t\t\t\tFailed To Update !  \n");

            }

        }
    }
}
