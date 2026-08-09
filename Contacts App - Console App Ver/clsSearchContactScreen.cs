using Contacts_App___Bussiness_Layer;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Contacts_App___Console_App_Ver
{
    internal static class clsSearchContactScreen 
    {


        private static void ImplementTheSearch(int contactID)
        {
            clsContactBussinessLogic.enDbReturnRecordsStatus Status = clsContactBussinessLogic.enDbReturnRecordsStatus.none;

            clsContactBussinessLogic Contact = clsContactBussinessLogic.GetContactById(ContactId: contactID, out Status);

            if(Status == clsContactBussinessLogic.enDbReturnRecordsStatus.success)
            {
                clsScreenUtils.DisplayContactInfo(ref Contact);
            }
            else if (Status == clsContactBussinessLogic.enDbReturnRecordsStatus.paramtersError)
            {
                Console.WriteLine("\a\t\t\t\tParamter Error");
            }
            else if(Status == clsContactBussinessLogic.enDbReturnRecordsStatus.failure)
            {
                Console.WriteLine("\t\t\t\tFailed To Get Data From Database!");
            }
        }


        public static void ShowSearchContactScreen()
        {
            Console.Clear();  // clear the screen 
            clsScreenUtils.PrintMenuOption("Search Contact By Id"); // show header

            Console.Write("\nEnter The Contact ID: ");
            int ID  ;

            while ( ! int.TryParse(Console.ReadLine(), out ID) ) // is the input isn't correct 
            {
                Console.WriteLine($"\t\t\t\t\aThe Id Isn't Valid!\n\t\t\t\tEnter A Vaild Id!");
            }

            ImplementTheSearch(ID);
        }

    }
}
