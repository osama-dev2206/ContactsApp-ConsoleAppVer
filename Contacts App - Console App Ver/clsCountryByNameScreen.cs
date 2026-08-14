using Contacts_App___Bussiness_Layer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Console_App_Ver
{
    internal  static class clsCountryByNameScreen
    {
        static public void ShowFindByName ()
        {
            clsScreenUtils.PrintMenuOption("   Find Country By Name ");

            Console.Write("\nEnter Country Name: ");
            string CountryName = Console.ReadLine();
            Console.WriteLine();

            clsCountries  ? Country =  clsCountries.FindCountryByName(CountryName);

            if(Country!=null)
            {
                Console.WriteLine($"The Country Name Is : {Country.CountryName}");
                Console.WriteLine($"The Country Id Is : {Country.CountryID}");
            }
            else
            {
                Console.WriteLine("\n\t\t\t\t\tFailed To Get Data!");
            }

        }

    }
}
