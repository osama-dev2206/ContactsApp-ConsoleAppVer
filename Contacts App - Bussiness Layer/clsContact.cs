using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;
using Contacts_App___Data_Access_Layer; // import the data access layer library 

namespace Contacts_App___Bussiness_Layer
{
    // partial class allows you to divide your logic into many classes files 
    public partial class clsContact
    {
        // Contact Properties // 
        public int ContactID { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CountryID { get; set; }
        public string ImagePath { get; set; }

        enum enMode { Update=1 , Add=2 , Remove=3 }

        private enMode _Mode = enMode.Update;

        // paramterized constructor -- private cuz i don't need anyone to add id manually i used it to get record from db only (find)
        private clsContact(
    int contactID,string firstName, string lastName, string email,string phone,
    string address, DateTime dateOfBirth,int countryID,string imagePath)
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

            _Mode = enMode.Update; // the object is ready to update  
        }

        /// -----------------------------------------------------------------------------///
        
        public static clsContact? GetContactById(int ContactId ) // #1 
        {
        

             string FirstName = ""; string LastName = ""; string Email = "";
            string Phone = ""; string Address = ""; string ImagePath = "";  DateTime DateOfBirth = DateTime.Now;
            int CountryID = 0;



            bool ReturnDataStatus = DataAccessForSearchContact.CheckContactOnDb
                (ContactID: ref ContactId, FirstName:  ref FirstName ,LastName : ref LastName,
                Email:ref Email, Phone: ref Phone, Address: ref Address,
                DateOfBirth: ref DateOfBirth, CountryID: ref CountryID, ImagePath : ref ImagePath);

            if (ReturnDataStatus) // if the record was founded then return the obj with info 
            {
                return new clsContact(ContactId, FirstName, LastName, Email, Phone, Address, DateOfBirth, CountryID, ImagePath);
            }


             return null; // the record isn't exisiting 

        }


        public static DataTable GetContactRecord(int ContactId) // #2
        {
            return DataAccessForSearchContact.ReturnContactRecordByID(ContactId);
        }

    }
}
