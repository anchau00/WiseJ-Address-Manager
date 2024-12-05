using System;
using System.ComponentModel.Design;
using ManagerApplication.Properties;
using Wisej.Web;


namespace ManagerApplication.Dialogs
{
    public partial class OrgAddDialog : Form
    {

        OrgControl oc = new OrgControl();

        Organization org = new Organization
        {
            name = "",
            street = "",
            zip = "",
            city = "",
            country = "",
        };

        public OrgAddDialog()
        {
            InitializeComponent();
        }

        private void OrgAddDialog_Load(object sender, EventArgs e)
        {

        }

        private void OrgNameText_TextChanged(object sender, EventArgs e)
        {
            org.name = OrgNameText.Text;


        }

        private void OrgStreetText_TextChanged(object sender, EventArgs e)
        {
            org.street = OrgStreetText.Text;
        }

        private void OrgZipText_TextChanged(object sender, EventArgs e)
        {
            org.zip = OrgZipText.Text;
        }

        private void OrgCityText_TextChanged(object sender, EventArgs e)
        {
            org.city = OrgCityText.Text;
        }

        private void OrgCountryText_TextChanged(object sender, EventArgs e)
        {
            org.country = OrgCountryText.Text;
        }



        private void Preset()
        {
            
            Commands
                .Register(OkBtn, () =>
                {
                    oc.addOrg(org);  // Use the current text when OkBtn is clicked
                    Close();
                })
                .Register(cancelBtn, () => Close());
     
        }

      

        public static bool Execute()
        {
            using (var dlg = new OrgAddDialog())
            {
                dlg.Preset();
                if (dlg.ShowDialog() != DialogResult.OK)
                    return false;
            }
            return true;

        }

        protected CommandHandler Commands
        {
            get
            {
                if (_Commands == null)
                    _Commands = new CommandHandler();
                return _Commands;
            }
        }

        private CommandHandler _Commands;

      
    }
}
