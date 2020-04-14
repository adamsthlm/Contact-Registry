using System;
/*
Denna fil har skapats som en del av kursen [C# I] på Malmö Universitet 2020
Namn: Carl-Adam Berglund
e-mail: ak7764@mau.se
*/

using System.Windows.Forms;

namespace Contact_Registry
{
    public partial class MainForm : Form
    {
        private ContactManager contactManager; 
        
        public MainForm()
        {
            InitializeComponent();
            contactManager = new ContactManager();
            InitializeGUI();

        }

        private void InitializeGUI()
        {
            
            // Have to work on the Countries class 2020-04-14
            // 
            //
            

            contactManager.TestValues();
            updateGUI();
        }

        private void updateGUI()
        {
            string[] strContracts = contactManager.GetContactsInfo();
            listBoxContacts.Items.Clear();
            listBoxContacts.Items.AddRange(strContracts);
            lab_nrOfRecords.Text = listBoxContacts.Items.Count.ToString();
          
        }

        private void butt_add_Click(object sender, EventArgs e)
        {

        }

        private void listBoxContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateContactInfoFromRegistry();
        }

        private void UpdateContactInfoFromRegistry()
        {
            int index = listBoxContacts.SelectedIndex;
            if (index < 0)
            {
                return;
            }

            Contact contact = contactManager.GetContact(index);

            cmbCountry.Items.AddRange(Enum.GetNames(typeof(Countries)));
            cmbCountry.SelectedIndex = (int)Countries.Sverige;

            contactManager.TestValues();
            updateGUI();
        }
    } // class
} // namespace 
