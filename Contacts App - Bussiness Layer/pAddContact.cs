using Contacts_App___Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Bussiness_Layer
{
    public partial class clsContact // part of clsContact , Bussiness Logic 
    {

        // Constructor for Adding New Contact - these paramters must to fill (not null) , these attributes must be provided by user 
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

            _Mode = enMode.Add; // change the state to add 

        }

        private bool AddContact()
        {
            // will check if the id !=-1 which means the record has inserted 
          this.ContactID =   ( DataAccessForAddNewContact.AddNewContactToDB
                (FirstName: this.FirstName, LastName: this.LastName, Email: this.Email, Phone: this.Phone,
                Address: this.Address, DateOfBirth: this.DateOfBirth, CountryID: this.CountryID, ImagePath: this.ImagePath));

            return (this.ContactID != -1);
        }

        public bool Save()
        {
            switch (this._Mode)
            {

                case enMode.Add:
                    if (AddContact())
                    {
                        _Mode = enMode.Update; // add was finished 
                        return true;
                    }
                    else
                    {
                        return false;
                    }

            }
            return false;
        }

    }
}
