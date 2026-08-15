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
            string ?CountryName = Console.ReadLine();
            Console.WriteLine();

            clsCountries  ? Country =  clsCountries.FindCountryByName(CountryName);

            if(Country!=null)
            {
                Console.WriteLine($"\n\t\t\t\t\tThe Country Name Is : {Country.CountryName}");
                Console.WriteLine($"\t\t\t\t\tThe Country Id Is : {Country.CountryID}");
                Console.WriteLine($"\t\t\t\t\tThe Country Code Is : {Country.Code}");
                Console.WriteLine($"\t\t\t\t\tThe Country Phone Code Is : {Country.PhoneCode}");
            }
            else
            {
                Console.WriteLine($"\n\t\t\t\t\tThe Country {CountryName} Isn't Exitst !");
            }

        }

    }
}
