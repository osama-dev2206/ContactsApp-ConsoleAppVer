using Contacts_App___Bussiness_Layer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Console_App_Ver
{
    internal static class clsIsCountryExistByIDScreen
    {
        public static void ShowIsCountryExistScreen()
        {
            clsScreenUtils.PrintMenuOption("  Is Country Exist By ID");

            Console.Write("\nEnter Country ID: ");
            int.TryParse(Console.ReadLine(), out int Id);
            
            if ( clsCountries.IsCountryExistByID(Id) )
            {
                Console.WriteLine($"\n\t\t\t\t\tThe Country With ID {Id} Is Exist");
            }
            else
            {
                Console.WriteLine($"\a\n\t\t\t\t\tThe Country With ID {Id} Isn't Exist");

            }

        }
    }
}
