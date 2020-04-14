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
            // Not implemented yet
          
        }

        private void butt_add_Click(object sender, EventArgs e)
        {

        }

        private void listBoxContacts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    } // class
} // namespace 
