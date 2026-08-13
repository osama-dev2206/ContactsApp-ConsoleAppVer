using Contacts_App___Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Bussiness_Layer
{
    public partial class clsContact
    {
        private bool UpdateContact()
        {
            return clsDataAccessUpdateContact.UpdateContactInDb(ContactID, FirstName, LastName, Email, Phone, Address, DateOfBirth, CountryID, ImagePath);
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

                case enMode.Update:
                    if (UpdateContact() )  return true;
                    else return false;
            }

            return false;
        }


    }



}
