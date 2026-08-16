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
        private int selectedContactID = -1; // Variable to hold the selected contact ID

        public frmMain()
        {
            InitializeComponent();
            this.ContextMenuStrip = this.contextMenuStrip1; // Assign the context menu to the form

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
            if (DGV.CurrentRow != null && int.TryParse(DGV.CurrentRow.Cells[0].Value.ToString(), out int ID))
            {
                this.selectedContactID = ID;
            }

        }


        // Add New Contact //
        private void AddContact_Click(object sender, EventArgs e)
        {

            /*
             *  id = -1 ==> add new contact
             */
            this.selectedContactID = -1; // Reset selected contact ID for adding new contact
            Add_EditContactForm AddNewContactForm = new Add_EditContactForm(this.selectedContactID);
            AddNewContactForm.ShowDialog();

            LoadAllContacts(); // Refresh the DataGridView after adding a new contact
        }


        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem != null)
            {

                if (e.ClickedItem.Text == "Edit" && this.selectedContactID != -1)
                {
                    Add_EditContactForm EditContact = new Add_EditContactForm(this.selectedContactID);
                    EditContact.ShowDialog();

                    LoadAllContacts(); // Refresh the DataGridView after editing a contact
                }

                else if (e.ClickedItem.Text == "Delete" && this.selectedContactID != -1)
                {

                    var Res = MessageBox.Show("Are you sure you want to delete this contact?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (Res == DialogResult.Yes)
                    {

                        if (clsContact.DeleteContact(this.selectedContactID))
                        {
                            selectedContactID = -1; // rest selected contact ID after deletion

                            MessageBox.Show("Contact deleted successfully.", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                }

            }

        }




    }
}
