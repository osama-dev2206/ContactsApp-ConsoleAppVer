using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contacts_App___Bussiness_Layer; 

namespace Contacts_App
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            LoadAllContacts();
            DGV.Focus();
        }

        private void LoadAllContacts()
        {
            DGV.DataSource = clsContact.GetAllContacts();
        }

        // Search 


        private void AddContact_Click(object sender, EventArgs e)
        {

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(tbSearch.ToString(), out int ContactID);
            DGV.DataSource = clsContact.GetContactById(ContactID);

        }


    }
}
