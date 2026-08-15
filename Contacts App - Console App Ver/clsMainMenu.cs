using System;
using System.Collections.Generic;
using System.Text;
using Contacts_App___Bussiness_Layer;

namespace Contacts_App___Console_App_Ver
{
    internal static class clsMainMenu 
    {
        enum enMenuOption { SearchContact=1,AddContact=2 ,UpdateContact=3,DeleteContact=4 ,ListContact =5 , IsContactExisits=6 , CountryMenu=7 }
   
        private static void DisplayMainMenuOptions()
        {
            string padding = "".PadRight(37);

            Console.WriteLine($"{padding}=========================================");
            Console.WriteLine($"\t\t{padding}Main Menu");
            Console.WriteLine($"{padding}=========================================");
            Console.WriteLine($"{padding}[1] Search Contact By ID.");
            Console.WriteLine($"{padding}[2] Add New Contact.");
            Console.WriteLine($"{padding}[3] Update Contact.");
            Console.WriteLine($"{padding}[4] Delete Contact.");
            Console.WriteLine($"{padding}[5] List Contacts.");
            Console.WriteLine($"{padding}[6] Is Contact Exist?");
            Console.WriteLine($"{padding}[7] Countries Main Menu");
            Console.WriteLine($"{padding}[8] End Program.");
            Console.WriteLine($"{padding}=========================================");
        }

        private static void ShowFindContactScreen()//1 
        {
            clsSearchContactScreen.ShowSearchContactScreen();
        }
        private static void ShowAddContactScreen()//2 
        {
            clsAddNewContactScreen.ShowAddContactScreen();
        }

        private static void ShowUpdateContactScreen()//3 
        {
            clsUpdateContactScreen.ShowUpdateScreen();
        }

        private static void ShowDeleteContactScreen()//4 
        {
            clsDeleteScreen.ShowDeleteScreen();
        }

        private static void ShowListContactScreen()//5 
        {
            clsGetAllContactsScreen.PrintAllContacts(); 
        }

        private static void ShowIsExistContactScreen()//6 
        {
            clsIsContactExitsScreen.ShowIsContactExistsScreen();
        }

        private static void ShowCountryMenu()//7 
        {
            clsCountryMenu.ShowMainScreen();
        }

        private static void ShowReturnMessage()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed; // set the warn to red 
            Console.WriteLine("\n\n\t\t\t\tPress Any Key To Return");
            Console.ReadKey(); // pause the screen 
            Console.ForegroundColor = ConsoleColor.White; // rest colot 
        }

        private static void ShowScreenAccordingToOption(enMenuOption option)// show screen 
        {
            Console.Clear();
            switch (option)
            {
                case enMenuOption.SearchContact:
                    ShowFindContactScreen();
                    ShowReturnMessage();
                    break;

                case enMenuOption.AddContact:
                    ShowAddContactScreen();
                    ShowReturnMessage();
                    break;
                case enMenuOption.UpdateContact:
                    ShowUpdateContactScreen();
                    ShowReturnMessage();
                    break;

                case enMenuOption.DeleteContact:
                    ShowDeleteContactScreen();
                    ShowReturnMessage();
                    break;

                case enMenuOption.ListContact:
                    ShowListContactScreen();
                    ShowReturnMessage();
                    break;

                    case enMenuOption.IsContactExisits:
                    ShowIsExistContactScreen();
                    ShowReturnMessage();
                    break;

                case enMenuOption.CountryMenu:
                    ShowCountryMenu();
                    break;
            }
        }


        public static void ShowMainScreen()
        {
            int Option = 0;
            do
            {
              
                Console.Clear(); // clear screen content 
                DisplayMainMenuOptions();
                Console.Write(@"                                    Enter Option: ");


                try { Option = Convert.ToInt32(Console.ReadLine()); }
                catch { Option = -2; }

                if(Option==8)
                {
                    Console.Clear();
                    Console.WriteLine("\n END :)");
                    Environment.Exit(0); // end program 
                }

                ShowScreenAccordingToOption((enMenuOption)Option);  // user choosed right option 

                // the menu will be shown again if the option isn't valid num of out of range 
            } while( Option != 8);

           
            
        }



    }
}
