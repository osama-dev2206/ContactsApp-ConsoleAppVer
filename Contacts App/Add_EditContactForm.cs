using Contacts_App___Bussiness_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Contacts_App
{
    public partial class Add_EditContactForm : Form
    {
        clsContact ? contact = new clsContact(); // object to fill to add new contact or to get assign contact object  to update 
        enum enFormMode : byte { Add = 1, Edit = 2 }
        enFormMode _Mode = enFormMode.Add;

        int contactId = -1; // variable to hold the contact id for edit mode

        public Add_EditContactForm(int ContactID)
        {
            InitializeComponent();
            this.contactId = ContactID;

            if (ContactID == -1)
            {
                _Mode = enFormMode.Add; // contact isn't on db 
                this.linkLabelChangePhoto.Text = "Add New Contact";
            }
            else
            {
                _Mode = enFormMode.Edit; // contact is on db and we want to edit it
                this.linkLabelChangePhoto.Text = "Edit Contact";
            }

        }

        private void Add_EditContactForm_Load(object sender, EventArgs e)
        {
            FillCountriesInDropDownList();
        }

        private void FillCountriesInDropDownList()// to fill the combobox with all countries from the database
        {
            DataTable dt = clsCountries.GetAllCountries();
            foreach (DataRow Row in dt.Rows)
            {
                this.cbCountryName.Items.Add(Row["CountryName"]);
            }
        }


        // Edit Contact ///
        private void LoadContactData()
        {
            if( _Mode == enFormMode.Edit)
            {
                if ( clsContact.GetContactById(contact.ContactID) !=null)
                {
                    contact = clsContact.GetContactById(this.contactId); 
                    this.tbFirstName.Text = contact.FirstName;
                    this.tbLastName.Text = contact.LastName;
                    this.mtbEmail.Text = contact.Email;
                    this.mtbPhone.Text = contact.Phone;
                    this.tbAddress.Text = contact.Address;
                    this.dtDateOfBirth.Value = contact.DateOfBirth;
                    this.cbCountryName.SelectedItem = clsCountries.FindCountryByID(contact.CountryID);

                }

            }

        }


        // ADD NEW CONTACT /// 
        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbFirstName.Text))
                contact.FirstName = tbFirstName.Text;
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbLastName.Text))
                contact.LastName = tbLastName.Text;
        }

        private void mtbEmail_TextChanged(object sender, EventArgs e)
        {
            if (mtbEmail.MaskCompleted && !String.IsNullOrEmpty(mtbEmail.Text)) // if the use has completed the required input 
                contact.Email = mtbEmail.Text;
        }

        private void mtbPhone_TextChanged(object sender, EventArgs e)
        {
            if ((mtbPhone.MaskFull && !String.IsNullOrEmpty(mtbPhone.Text)))
                contact.Phone = mtbPhone.Text;
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            if ((!String.IsNullOrEmpty(tbAddress.Text)))
                contact.Address = tbAddress.Text;
        }

        private void dtDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            if (dtDateOfBirth.Value != null && !String.IsNullOrEmpty(dtDateOfBirth.Text))
                contact.DateOfBirth = dtDateOfBirth.Value;
        }

        private void cbCountryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbCountryName.SelectedIndex != -1 && cbCountryName != null)
            {
                if (clsCountries.FindCountryByName(cbCountryName.SelectedItem.ToString()).CountryID != null)
                    contact.CountryID = clsCountries.FindCountryByName(cbCountryName.SelectedItem.ToString()).CountryID;
            }

        }

        private bool CheckBeforeSave()
        {
            if (
           !String.IsNullOrEmpty(this.tbFirstName.Text) &&
            !String.IsNullOrEmpty(this.tbLastName.Text) && !String.IsNullOrEmpty(this.tbAddress.Text) && !String.IsNullOrEmpty(this.mtbEmail.Text)
            && !String.IsNullOrEmpty(this.mtbPhone.Text) && this.dtDateOfBirth.Value != null && this.cbCountryName.SelectedItem != null)
            {
                return true;
            }

            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to save these changes?", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                if (CheckBeforeSave() )
                    contact.Save();
                else
                    MessageBox.Show("Please fill in all required fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
