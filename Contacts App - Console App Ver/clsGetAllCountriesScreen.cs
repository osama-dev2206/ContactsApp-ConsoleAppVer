using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Console_App_Ver
{
    internal static  class clsGetAllCountriesScreen
    {
        static private void PrintHeader()
        {
            Console.WriteLine("{0,-12}{1,-15}", "CountryID", "CountryName");
        }

        static public void  ShowAllCountries()
        {
            clsScreenUtils.PrintMenuOption()
        }

    }
}
