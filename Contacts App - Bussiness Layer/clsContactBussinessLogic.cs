using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Contacts_App___Data_Access_Layer; // import the data access layer library 

namespace Contacts_App___Bussiness_Layer
{
    // partial class allows you to divide your logic into many class files 
    public partial class clsContactBussinessLogic
    {
        public int ContactID { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CountryID { get; set; }
        public string ImagePath { get; set; }

        // paramterized constructor 
        public clsContactBussinessLogic(
    int contactID,
    string firstName,
    string lastName,
    string email,
    string phone,
    string address,
    DateTime dateOfBirth,
    int countryID,
    string imagePath)
        {
            ContactID = contactID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Address = address;
            DateOfBirth = dateOfBirth;
            CountryID = countryID;
            ImagePath = imagePath;
        }

        // Constructor for intilization only 
        private clsContactBussinessLogic()
        {
            ContactID = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            Phone = string.Empty;
            Address = string.Empty;
            DateOfBirth = DateTime.MinValue;
            CountryID = 0;
            ImagePath = string.Empty;
        }

        public  enum enDbReturnRecordsStatus { none =0 ,success=1 , failure=2 , paramtersError =3 }

        public static clsContactBussinessLogic GetContactById(int ContactId , out enDbReturnRecordsStatus DbStatus)
        {
            DbStatus = enDbReturnRecordsStatus.none;
            if (!int.TryParse(ContactId.ToString(), out _))
            {
                DbStatus = enDbReturnRecordsStatus.paramtersError;
                return new clsContactBussinessLogic(); // if the contact id isn't valid num
            }

             string FirstName = ""; string LastName = ""; string Email = "";
            string Phone = ""; string Address = ""; string? ImagePath = "";  DateTime DateOfBirth = DateTime.Now;
            int CountryID = 0;



            bool ReturnDataStatus = DataAccessForSearchContact.CheckContactOnDb
                (ContactID: ref ContactId, FirstName:  ref FirstName ,LastName : ref LastName,
                Email:ref Email, Phone: ref Phone, Address: ref Address,
                DateOfBirth: ref DateOfBirth, CountryID: ref CountryID, ImagePath : ref ImagePath);

            if (ReturnDataStatus)
            {
                DbStatus = enDbReturnRecordsStatus.success;
            }
            else
            {
                DbStatus = enDbReturnRecordsStatus.failure;
            }

          return new clsContactBussinessLogic(ContactId, FirstName, LastName, Email, Phone, Address, DateOfBirth, CountryID, ImagePath);

        }



    }
}
