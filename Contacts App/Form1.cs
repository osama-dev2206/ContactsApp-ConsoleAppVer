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
 
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DGV.AutoGenerateColumns = true;
            LoadAllContacts();
        }

        private void LoadAllContacts()
        {
            DGV.DataSource = clsContact.GetAllContacts();
        }




        private void AddContact_Click(object sender, EventArgs e)
        {

        }

        // Search //
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbSearch.Text.ToString()))
            {
                int.TryParse(tbSearch.Text.ToString(), out int ContactID);

                DataTable dt = clsContact.GetContactRecord(ContactID);

                if (dt != null)
                    DGV.DataSource = dt;
                else
                    MessageBox.Show("No contact found with the given ID.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                LoadAllContacts(); // load all contacts if search box is empty
            }

        }

        private void DGV_SelectionChanged(object sender, EventArgs e)
        {

            MessageBox.Show("Selected Contact ID: " + DGV.SelectedColumns.ToString());

        }


    }
}
