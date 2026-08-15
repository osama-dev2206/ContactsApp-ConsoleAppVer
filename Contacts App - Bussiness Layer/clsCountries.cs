using Contacts_App___Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Contacts_App___Bussiness_Layer
{
    public class clsCountries
    {
        public int  CountryID {  get; private set; }
        public string  CountryName { get;  set; }
        enum enMode { update = 1, add = 2 };

        enMode _mode = enMode.update;

        private clsCountries(int CountryId , string name )
        {
            this.CountryName = name;
            this.CountryID = CountryId;

            _mode = enMode.update;
        }


        public  clsCountries( string name)
        {
            this.CountryName = name;

            _mode = enMode.add;
        }

        public static clsCountries ? FindCountryByName(string CountryName )
        {
            if (CountryName == null) return null;

            CountryName = CountryName.Trim();

            int countryID = 0;

            bool res = clsDataAccessForFindCountryByName.FindCountryByName(CountryName, ref countryID);

            if (res)
            {
                return new clsCountries(countryID, CountryName);
            }
            else return null; 
        }


        public static bool IsCountryExist(string ?CountryName)
        {
            if(CountryName== null) return false;
            return clsDataAccessForCheckCountryByName.CheckCountryByName(CountryName);
        }

        public static clsCountries? FindCountryByID(int CountryID)
        {
            if (!int.TryParse(CountryID.ToString(), out _ )) return null;

            string ? Name = "";
            bool res = clsDataAccessForFindCountryByID.FindCountryByID(CountryID, ref Name);

            if (res) 
                return new clsCountries(CountryID, Name);
            else 
                return null; 

        }

        public static bool IsCountryExistByID(int CountryID)
        {
            if(! int.TryParse (CountryID.ToString() , out _ )) return false;
            return clsDataAccessForIsCountryExisitById.IsCountryExistByID(CountryID);
        }

        private bool AddNewCountry()
        {
            int id = clsDataAccessForAddCountry.AddNewCountryToDb(this.CountryName);
            return (id != -1); // if the id !=-1 then the record has inserted successfully 
        }

        private bool UpdateCountry()
        {
            return clsDataAccessForUpdateCountry.UpdateCountryOnDb(this.CountryName ,this.CountryID); 
        }

        public bool Save()
        {
            switch( this. _mode )
            {
                case enMode.add:
                    if (AddNewCountry())
                    {
                        _mode = enMode.update; // rest mode to default 
                        return true;
                    }
                    break; 

                    case enMode.update:
                    if (UpdateCountry())
                    {
                        return true; 
                    }
                    break;
            }

            return false;
        }


        public  static bool DeleteCountry(int CountryID)
        {
            if (!int.TryParse(CountryID.ToString(), out _)) return false;
           else  return clsDataAccessForDeleteCountry.DeleteCountryFromDb(CountryID);
        }

        public static DataTable GetAllCountries()
        {
            return clsDataAccessForGetAllCountries.GetAllCountries(); 
        }

    }
}
