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
        clsContact contact = new clsContact(); // object to fill to add new contact or to get assign contact object  to update 
        enum enFormMode : byte { Add = 1, Edit = 2 }
        enFormMode _Mode = enFormMode.Add;

        public Add_EditContactForm(int ContactID )
        {
            InitializeComponent();
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



    }
}
