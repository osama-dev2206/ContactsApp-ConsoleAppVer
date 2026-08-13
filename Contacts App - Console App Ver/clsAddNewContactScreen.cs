using Contacts_App___Bussiness_Layer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Console_App_Ver
{
    internal static class clsAddNewContactScreen
    {
        private static clsContact FillContactInfo()
        {
            Console.Write("Enter FirstName : ");
            string? FirstName = Console.ReadLine();

            Console.Write("\nEnter LastName : ");
            string? LastName = Console.ReadLine();


            Console.Write("\nEnter Email : ");
            string? Email = Console.ReadLine();

            Console.Write("\nEnter Phone : ");
            string? Phone = Console.ReadLine();

            Console.Write("\nEnter Address :  ");
            string? Address = Console.ReadLine();


            Console.Write("\nEnter Date Of Birth (y-m-d):  ");
            string dateString = Console.ReadLine() + " 02:30:00";

            DateTime DateOfBirth;
            try { DateOfBirth = DateTime.Parse(dateString); }
            catch { DateOfBirth = DateTime.Parse("2026-08-13 14:30:00"); } // to skip data time handling error 

            Console.Write("\nEnter Country ID:  ");
            int CountryID;
            CountryID =Convert.ToInt32(Console.ReadLine());


            Console.Write("\nEnter Image Path:  ");
            string? ImagePath = Console.ReadLine();

            return new clsContact(FirstName, LastName, Email, Phone, Address, DateOfBirth, CountryID, ImagePath);

        }


        public static void ShowAddContactScreen()
        {

            clsScreenUtils.PrintMenuOption(@"      Add New Contact");
            clsContact Contact = FillContactInfo();
            if (Contact.Save())
            {
                Console.WriteLine($"\n\t\t\t\t\tContact With ID {Contact.ContactID} Has Been Inserted!");
            }
            else
            {
                Console.WriteLine("\n\t\t\t\t\tFailed To Insert !\a");
            }

        }




    }

}




