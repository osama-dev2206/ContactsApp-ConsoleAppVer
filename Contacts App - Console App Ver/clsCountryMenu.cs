using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Console_App_Ver
{
    internal static class clsCountryMenu
    {
        enum enMenuOption { FindCountryByName = 1, IsCountryExistsByName=2 , FindCountryByID=3 , IsCountryExistsByID=4 , 
            AddCountry=5 , UpdateCountry=6 , GetAllCountries=7 ,DeleteCountry = 8 }

        private static void DisplayMainMenuOptions()
        {
            string padding = "".PadRight(37);

            Console.WriteLine($"{padding}=========================================");
            Console.WriteLine($"\t\t{padding}Countries Menu");
            Console.WriteLine($"{padding}=========================================");
            Console.WriteLine($"{padding}[1] Find Country By Name.");
            Console.WriteLine($"{padding}[2] Is Country Exist(By Name).");
            Console.WriteLine($"{padding}[3] Find Country By ID.");
            Console.WriteLine($"{padding}[4] Is Country Exists(By ID).");
            Console.WriteLine($"{padding}[5] Add Country.");
            Console.WriteLine($"{padding}[6] Update Country.");
            Console.WriteLine($"{padding}[7] Get All Countries.");
            Console.WriteLine($"{padding}[8] Delete Country.");
            Console.WriteLine($"{padding}[9] Back To Main Menu.");
            Console.WriteLine($"{padding}=========================================");
        }

        private static void ShowFindCountryByNameScreen()
        {
            clsCountryByNameScreen.ShowFindByName();
        }

        private static void ShowIsCountryExistsScreenByName()
        {
            clsCheckExistenceScreen.ShowIsCountryExistScreen();
        }

        private static void ShowIsCountryExisitsScreenByID()
        {
            clsIsCountryExistByIDScreen.ShowIsCountryExistScreen();
        }

        private static void ShowFindCountryByIDScreen()
        {
            clsFindCountryByIDScreen.ShowFindByIDScreen();
        }

        private static void AddCountry()
        {
            clsAddCountryScreen.ShowAddCountryScreen();
        }

        private static void UpdateCountry()
        {
            clsUpdateCountryScreen.ShowUpdateCountry();
        }

        private static void GetAllCountries()
        {

        }

        private static void DeleteCountry()
        {
            clsDeleteCountryScreen.DeleteCountry();
        }

        private static void ShowReturnMessage()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed; // set the warn to red 
            Console.WriteLine("\n\n\t\t\t\tPress Any Key To Return To Countries Menu");
            Console.ReadKey(); // pause the screen 
            Console.ForegroundColor = ConsoleColor.White; // rest colot 
        }

        private static void ImplementOption(enMenuOption Option )
        {
            Console.Clear();
            switch (Option)
            {
                case enMenuOption.FindCountryByName:
                    ShowFindCountryByNameScreen();
                    ShowReturnMessage();
                    break;

                case enMenuOption.IsCountryExistsByName:
                     ShowIsCountryExistsScreenByName();
                    ShowReturnMessage();
                    break;

                case enMenuOption.IsCountryExistsByID: 
                    ShowIsCountryExisitsScreenByID();
                    ShowReturnMessage();
                    break;

                case enMenuOption.FindCountryByID:
                    ShowFindCountryByIDScreen();
                    ShowReturnMessage();
                    break;

                case enMenuOption.AddCountry:
                    AddCountry();
                    ShowReturnMessage();
                    break;

                case enMenuOption.UpdateCountry:
                    UpdateCountry();
                    ShowReturnMessage();
                    break;

                case enMenuOption.GetAllCountries:
                    GetAllCountries();
                    ShowReturnMessage();
                    break;

                case enMenuOption.DeleteCountry:
                    DeleteCountry();
                    ShowReturnMessage();
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

                if (Option == 9)
                {
                    break;
                }

                ImplementOption((enMenuOption)Option);  // user choosed right option 

                // the menu will be shown again if the option isn't valid num of out of range 
            } while ( Option!=9 );



        }


    }
}
