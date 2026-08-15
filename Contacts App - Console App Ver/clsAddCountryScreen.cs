using Contacts_App___Bussiness_Layer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Console_App_Ver
{
    internal class clsAddCountryScreen
    {
        public static void ShowAddCountryScreen()
        {
            clsScreenUtils.PrintMenuOption("   Add New Country ");

            Console.Write("\nEnter Country Name: ");
            string? Name = Console.ReadLine();

            clsCountries country = new clsCountries(Name);

            if (country.Save())
            {
                Console.WriteLine("\n\t\t\t\tThe New Country Has Been Inserted Successfully !");
            }
            else
            {
                Console.WriteLine("\a\n\t\t\t\tFailed To Insert  !");
            }
        }
    }
}
