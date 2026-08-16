using Contacts_App___Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Bussiness_Layer
{
    public partial class clsContact // part of clsContact , Bussiness Logic 
    {

        // Constructor for Adding New Contact 
        public clsContact(string firstName, string LastName, string Email, string Phone, string Address, DateTime DateOfBirth, int countryID, string imagePath)
        {

            this.FirstName = firstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            this.DateOfBirth = DateOfBirth;
            this.CountryID = countryID;
            this.ImagePath = imagePath;

            _Mode = enMode.Add; // change the state to add 

        }


        public clsContact()
        {
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



    }
}
