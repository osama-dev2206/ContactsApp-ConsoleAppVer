using Contacts_App___Bussiness_Layer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Console_App_Ver
{
    internal static  class clsIsContactExitsScreen
    {
        public static void ShowIsContactExistsScreen()
        {
            clsScreenUtils.PrintMenuOption("       Is Contact Exist? ");

            Console.Write("\nEnter Contact ID: ");
            int.TryParse(Console.ReadLine(), out int ID);

            if (clsContact.IsContactExist(ID))
                Console.WriteLine($"\n\t\t\t\t\tThe Contact With ID {ID} Exists ! ");
            else
                Console.WriteLine($"\a\n\t\t\t\tThe Contact With ID {ID} Isn't Existing");


        }
    }
}
