using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Bussiness_Layer
{
    public partial class clsContact // part of clsContact , Bussiness Logic 
    {

        // Constructor for Adding New Contact - these paramters are the mandotrory not null , these attributes must be provided by user 
        public clsContact(string firstName, string LastName, string Email, string Phone, string Address, DateTime DateOfBirth, int countryID)
        {
            ContactID = -1;
            this.FirstName = firstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            this.DateOfBirth = DateOfBirth;
            this.CountryID = CountryID;
            ImagePath = string.Empty; // it isn't mandatory 

            Mode = enMode.Add; // change the state to add 

        }



    }
}
