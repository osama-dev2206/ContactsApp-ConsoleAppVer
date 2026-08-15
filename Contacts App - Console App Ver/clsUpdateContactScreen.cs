using Contacts_App___Bussiness_Layer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Console_App_Ver
{
    internal static class clsUpdateContactScreen
    {

        private static void FillToUpdateContactInfo(ref clsContact contact)
        {
            Console.Write("Enter FirstName : ");
            contact.FirstName = Console.ReadLine();

            Console.Write("\nEnter LastName : ");
            contact.LastName = Console.ReadLine();


            Console.Write("\nEnter Email : ");
            contact.Email = Console.ReadLine();

            Console.Write("\nEnter Phone : ");
            contact.Phone = Console.ReadLine();

            Console.Write("\nEnter Address :  ");
            contact.Address = Console.ReadLine();


            Console.Write("\nEnter Date Of Birth (y-m-d):  ");
            string dateString = Console.ReadLine() + " 02:30:00";

            try { contact.DateOfBirth = DateTime.Parse(dateString); }
            catch { contact.DateOfBirth = DateTime.Parse("2026-08-13 14:30:00"); } // to skip data time handling error 

            Console.Write("\nEnter Country ID:  ");

            contact.CountryID = Convert.ToInt32(Console.ReadLine());


            Console.Write("\nEnter Image Path:  ");
            contact.ImagePath = Console.ReadLine();


        }

        public static void  ShowUpdateScreen()
        {
            clsScreenUtils.PrintMenuOption("     Update Screen");

            Console.Write("\n\t\t\t\t\tEnter Contact ID : ");
           int ContactId = Convert.ToInt32( Console.ReadLine() );

            clsContact ?contact = clsContact.GetContactById(ContactId); // mode: update 

            if (contact != null) // if the contact is exising on db 
            {
                Console.WriteLine("\n\n\t\t\t\tContact Exists :) "); 

                FillToUpdateContactInfo(ref contact); // update contact by user input 

                if (contact.Save())
                   Console.WriteLine("\n\n\t\t\t\tUpdated Successfully!");

                else
                    Console.WriteLine("\n\n\a\t\t\t\t\tFailed To Update");
            }

            else // the contact isn't existing to update 
            {
                Console.WriteLine("\n\n\a\t\t\t\t\tFailed To Update");
            }


        }



    }
}
