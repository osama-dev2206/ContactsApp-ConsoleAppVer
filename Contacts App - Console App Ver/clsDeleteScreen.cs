using Contacts_App___Bussiness_Layer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Console_App_Ver
{
    internal static class clsDeleteScreen
    {
        public static void ShowDeleteScreen()
        {
            clsScreenUtils.PrintMenuOption("     Delete Screen");

            Console.Write("\nEnter Contact ID : ");
            int.TryParse(Console.ReadLine(), out int ContactID);

            if (clsContact.DeleteContact(ContactID))
                Console.WriteLine($"\n\n\t\t\t\tContact ID {ContactID} Has Been Deleted Successfully! ");
            else 
                Console.WriteLine($"\a\n\n\t\t\t\tContact ID {ContactID} Has Been Failed To Delete! ");

        }
    }
}
