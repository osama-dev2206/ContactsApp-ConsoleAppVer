using Contacts_App___Bussiness_Layer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Console_App_Ver
{
    internal static class clsDeleteCountryScreen
    {
        public static void DeleteCountry()
        {
            clsScreenUtils.PrintMenuOption("  Delete Country")
               ;

            Console.Write("\nEnter Country ID: ");
            int.TryParse(Console.ReadLine(), out int id);

            if ( clsCountries.DeleteCountry(id))
            {
                Console.WriteLine($"\n\t\t\t\tCountry With ID {id} Has Been Deleted!");
            }
            else
            {
                Console.WriteLine($"\a\n\t\t\t\tCountry With ID {id} Failed To Delete!");
            }

        }
    }
}
