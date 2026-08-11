using Contacts_App___Bussiness_Layer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Console_App_Ver
{
    internal  static class clsScreenUtils
    {
         public static void PrintMenuOption(string Title, string SubTitle = "")
        {
            Console.Write( "\t\t\t\t\t______________________________________");
            Console.Write(  "\n\n\t\t\t\t\t" + Title );
            if (SubTitle != "")
            {
                Console.Write("\n\t\t\t\t\t  " + SubTitle);
            }
            Console.Write("\n\t\t\t\t\t______________________________________\n\n");
        }



        static public void DisplayContactInfo(ref clsContact Contact)
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("╔══════════════════════════════════════════╗");
            Console.WriteLine("║              CONTACT INFO                ║");
            Console.WriteLine("╠══════════════════════════════════════════╣");
            Console.WriteLine($"║ Contact ID   : {Contact.ContactID,-27} ║");
            Console.WriteLine($"║ First Name   : {Contact.FirstName,-27} ║");
            Console.WriteLine($"║ Last Name    : {Contact.LastName,-27} ║");
            Console.WriteLine($"║ Email        : {Contact.Email,-27} ║");
            Console.WriteLine($"║ Phone        : {Contact.Phone,-27} ║");
            Console.WriteLine($"║ Address      : {Contact.Address,-27} ║");
            Console.WriteLine($"║ Date of Birth: {Contact.DateOfBirth,-27:yyyy-MM-dd} ║");
            Console.WriteLine($"║ Country ID   : {Contact.CountryID,-27} ║");
            Console.WriteLine($"║ Image Path   : {Contact.ImagePath,-27} ║");
            Console.WriteLine("╚══════════════════════════════════════════╝");
        }

    }
}
