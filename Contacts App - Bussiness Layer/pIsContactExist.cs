using Contacts_App___Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App___Bussiness_Layer
{
    public partial class clsContact
    {
        public static bool IsContactExist(int ContactID)
        {
            return clsDataAccessForIsContactExist.IsContactExist(ContactID);
        }


    }
}
