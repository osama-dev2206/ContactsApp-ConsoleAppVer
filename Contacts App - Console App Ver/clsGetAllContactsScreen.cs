using Contacts_App___Bussiness_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Contacts_App___Console_App_Ver
{
    internal static class clsGetAllContactsScreen
    {
        private static void PrintHeader()
        {
            Console.WriteLine($"{"FirstName",-15} | {"LastName",-15} | {"Email",-25} | {"Phone",-15} | {"Address",-25} | {"DateOfBirth",-11} | {"CountryName",-15}");
            Console.WriteLine(new string('-', 125));
        }

        private static  string GetDateOnly(string datetime)
        {
            string[] str = datetime.Split(' ');
            return str[0];
        }

        public static void PrintAllContacts()
        {
            clsScreenUtils.PrintMenuOption("      Get All Contacts");

            DataTable dt = clsContact.GetAllContacts();
            Console.WriteLine();
            PrintHeader();

            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine(
              $"{row["FirstName"],-15} | {row["LastName"],-15} | {row["Email"],-25} | {row["Phone"],-15} | {row["Address"],-25} | {GetDateOnly(row["DateOfBirth"].ToString()),-11} | {row["CountryName"],-15}" 
               );
                   

            }
  

        }

    }
}
