using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Console_App_Ver
{
    internal static class clsCountryMenu
    {
        enum enMenuOption { FindCountryByName = 1, IsCountryExistsByName=2  }

        private static void DisplayMainMenuOptions()
        {
            string padding = "".PadRight(37);

            Console.WriteLine($"{padding}=========================================");
            Console.WriteLine($"\t\t{padding}Main Menu");
            Console.WriteLine($"{padding}=========================================");
            Console.WriteLine($"{padding}[1] Find Country By Name.");
            Console.WriteLine($"{padding}[2] Is Country Exists(By Name).");
            Console.WriteLine($"{padding}[3] Back To Main Menu.");
            Console.WriteLine($"{padding}=========================================");
        }

        private static void ShowFindCountryByNameScreen()
        {

        }

        private static void ShowIsCountryExistsScreen()
        {

        }

        private static void ShowReturnMessage()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed; // set the warn to red 
            Console.WriteLine("\n\n\t\t\t\tPress Any Key To Return To Main Menu");
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
                     ShowIsCountryExistsScreen();
                    ShowReturnMessage();
                    break;
            }
        }


        private static bool CheckOption(int option)
        {
            return (option >= 1 && option <= 3);
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

                if (Option == 3)
                {
                    break;
                }

                ImplementOption((enMenuOption)Option);  // user choosed right option 

                // the menu will be shown again if the option isn't valid num of out of range 
            } while (!CheckOption(Option) || Option != 3);



        }


    }
}
