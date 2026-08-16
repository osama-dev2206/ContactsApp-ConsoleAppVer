using Contacts_App.Properties;
using Contacts_App___Bussiness_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Contacts_App
{
    public partial class Add_EditContactForm : Form
    {
        clsContact? contact = new clsContact(); // object to fill to add new contact or to get assign contact object  to update 
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
                this.labNewFormState.Text = "Add New Contact";
                this.linkLabelChangePhoto.Visible = true;
                FillCountriesInDropDownList();
            }
            else
            {
                _Mode = enFormMode.Edit; // contact is on db and we want to edit it
                this.labNewFormState.Text = "Edit Contact";
                FillCountriesInDropDownList();
                LoadContactData();
                LoadPicture();

            }

        }

        // Load Form 
        private void Add_EditContactForm_Load(object sender, EventArgs e)
        {
            
            this.dtDateOfBirth.Value = DateTime.Now; //set default value 
        }

        private void FillCountriesInDropDownList()// to fill the combobox with all countries from the database
        {
            DataTable dt = clsCountries.GetAllCountries();
            foreach (DataRow Row in dt.Rows)
            {
                this.cbCountryName.Items.Add(Row["CountryName"]);
            }
        }

        void LoadPicture()
        {
            if (!String.IsNullOrEmpty(this.contact.ImagePath) && Path.Exists(this.contact.ImagePath)) // there is image 
            {
                this.pictureBox1.Image = Image.FromFile(this.contact.ImagePath);
                this.LinkLabelDeletePhoto.Visible = true;
                this.linkLabelChangePhoto.Visible = true;
            }
            else // no image 
            {
                this.linkLabelChangePhoto.Visible = true;
                this.LinkLabelDeletePhoto.Visible = false;
            }
        }



        // Edit Contact ///
        private void LoadContactData()
        {
            if (_Mode == enFormMode.Edit)
            {

                if (clsContact.GetContactById(this.contactId) != null) // check contact existence at first 
                {
                    contact = clsContact.GetContactById(this.contactId);
                    this.tbFirstName.Text = contact.FirstName;
                    this.tbLastName.Text = contact.LastName;
                    this.mtbEmail.Text = contact.Email;
                    this.mtbPhone.Text = contact.Phone;
                    this.tbAddress.Text = contact.Address;
                    this.dtDateOfBirth.Value = contact.DateOfBirth;
                    cbCountryName.Text = clsCountries.FindCountryByID(contact.CountryID).CountryName.Trim();
                }
                else
                {
                    MessageBox.Show("The contact does not exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    contact = null;
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
            if (this.cbCountryName.SelectedIndex != -1 && cbCountryName != null && cbCountryName.SelectedItem != null)
            {
                clsCountries c =  clsCountries.FindCountryByName(cbCountryName.SelectedItem.ToString()); // find the country object by name to get the country id 
                if (c != null)
                {
                    this.contact.CountryID = c.CountryID;
                }

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

                if (CheckBeforeSave())
                {

                    if (contact.Save()) MessageBox.Show("Contact saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("An error occurred while saving the contact.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Please fill in all required fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabelChangePhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Title = "Select a photo";

            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            openFileDialog1.Multiselect = false;

            openFileDialog1.FileName = "Photo.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.contact.ImagePath = openFileDialog1.FileName;

                this.pictureBox1.Image = Image.FromFile(this.contact.ImagePath);
                contact.ImagePath = openFileDialog1.FileName; // update the contact's image path    
            }

        }

        private void LinkLabelDeletePhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.contact.ImagePath = "";
            pictureBox1.Image = null;
        }


        // Check Before Leaving the TextBox && Mask Text Box && Combo Box if it is empty or not
        private void TextBoxes_Validating(object sender, CancelEventArgs e)
        {
            var Tb = sender as TextBox;

            if (String.IsNullOrEmpty(Tb.Text))
            {
                e.Cancel = true; // you cann't leve the textbox empty
                errorProvider1.SetError(Tb, "This Field Is Required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Tb, ""); // to disable error provider if the user has filled the textbox
            }

        }

        private void cbCountryName_Validating(object sender, CancelEventArgs e)
        {
            var cb = sender as ComboBox;
            if (cb == null || cb.SelectedItem == null) return;

            if (String.IsNullOrEmpty(cb.SelectedItem.ToString()))
            {
                e.Cancel = true;
                errorProvider1.SetError(cb, "Please select a country.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cb, "");
            }


        }

        private void mtbPhone_Validating(object sender, CancelEventArgs e)
        {
            var mtb = sender as MaskedTextBox;
            if (mtb.MaskCompleted == false)
            {
                e.Cancel = true;
                errorProvider1.SetError(mtb, "Please enter a valid Data!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(mtb, "");
            }


        }

        private void Add_EditContactForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false; // allow the form to close
        }


    }
}
