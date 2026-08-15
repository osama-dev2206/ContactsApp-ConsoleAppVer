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
        public string Code { get; set; }

        public string PhoneCode { get; set; }

        enum enMode { update = 1, add = 2 };

        enMode _mode = enMode.update;

        private clsCountries(int CountryId , string name , string Code , string PhoneCode)
        {
            this.CountryName = name;
            this.CountryID = CountryId;
            this.Code = Code;
            this.PhoneCode = PhoneCode;
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
            string Code = " ";   string PhoneCode =" ";

            bool res = clsDataAccessForFindCountryByName.FindCountryByName(CountryName, ref countryID, ref Code , ref PhoneCode);

            if (res)
            {
                return new clsCountries(countryID, CountryName,Code , PhoneCode);
            }
            else return null; 
        }


        public static bool IsCountryExist(string ?CountryName)
        {
            if(CountryName== null) return false;
            return clsDataAccessForCheckCountryByName.IsCountryExisitByName(CountryName);
        }

        public static clsCountries? FindCountryByID(int CountryID)
        {
            if (!int.TryParse(CountryID.ToString(), out _ )) return null;

            string ? Name = "";    string Code = "";  string PhoneCode = "";
            bool res = clsDataAccessForFindCountryByID.FindCountryByID(CountryID, ref Name, Code: ref Code , PhoneCode: ref PhoneCode );

            if (res) 
                return new clsCountries(CountryID, Name,Code , PhoneCode);
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
