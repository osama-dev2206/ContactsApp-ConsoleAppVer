using Contacts_App___Bussiness_Layer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Console_App_Ver
{
    internal class clsCheckExistenceScreen
    {
        public static  void ShowIsCountryExistScreen()
        {
            clsScreenUtils.PrintMenuOption("  Is Country Exisit? ");

            Console.Write("\nEnter Country Name: ");
            string ? Name  = Console.ReadLine();

            if (clsCountries.IsCountryExist(Name))
                Console.WriteLine($"\n\t\t\t\tThe Country {Name} Exisits! ");
            else
                Console.WriteLine($"\n\a\t\t\t\tThe Country {Name} Isn't Exisiting! ");

        }


    }
}
