using Contacts_App___Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Bussiness_Layer
{
    public class clsCountries
    {
        public int CountryID {  get; private set; }
        public string  CountryName { get; private set; }
        enum enMode { update = 1, add = 2 };
        enMode _mode = enMode.update;

        private clsCountries(int CountryId , string name )
        {
            this.CountryName = name;
            this.CountryID = CountryId;

            _mode = enMode.update;
        }


        public static clsCountries ? FindCountryByName(string CountryName )
        {
            CountryName = CountryName.Trim();

            int countryID = 0;

            bool res = clsDataAccessForFindCountryByName.FindCountryByName(CountryName, ref countryID);

            if (res)
            {
                return new clsCountries(countryID, CountryName);
            }
            else return null; 
        }



    }
}
