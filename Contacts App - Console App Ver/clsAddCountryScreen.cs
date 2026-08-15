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

            Console.Write("\nEnter Country Code: ");
            string? Code = Console.ReadLine();


            Console.Write("\nEnter Country Phone Code: ");
            string?PhoneCode = Console.ReadLine();


            clsCountries country = new clsCountries(Name,Code , PhoneCode);

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
