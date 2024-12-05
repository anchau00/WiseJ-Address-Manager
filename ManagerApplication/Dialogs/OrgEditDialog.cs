using System;
using Wisej.Web;
using ManagerApplication.Properties;
namespace ManagerApplication
{
    public partial class OrgEditDialog : Form
    {

        OrgControl oc = new OrgControl();

        Organization org = new Organization
        {
            OrganizationId = -1,
            name = "",
            street = "",
            zip = "",
            city = "",
            country = "",
        };

        public OrgEditDialog()
        {
            InitializeComponent();
        }

        private void OrgEditDialog_Load(object sender, EventArgs e)
        {

        }

        private void OrgNameText_TextChanged(object sender, EventArgs e)
        {
            org.name = OrgNameText.Text;
        }

        private void OrgCityText_TextChanged(object sender, EventArgs e)
        {
            org.city = OrgCityText.Text;
        }

        private void OrgStreetText_TextChanged(object sender, EventArgs e)
        {
            org.street = OrgStreetText.Text;
        }

        private void OrgCountryText_TextChanged(object sender, EventArgs e)
        {
            org.country = OrgCountryText.Text;
        }

        private void OrgZipText_TextChanged(object sender, EventArgs e)
        {
            org.zip = OrgZipText.Text;
        }

        private void IDText_TextChanged(object sender, EventArgs e)
        {
           
            int parsedId;

            if (!int.TryParse(IDText.Text, out parsedId))
            {
                parsedId = 0;  
            }
            org.OrganizationId = parsedId;  

        }

        private void Preset()
        {

            Commands
                .Register(OkBtn, () =>
                {
                    oc.updateOrg(org);  
                    Close();
                })
                .Register(cancelBtn, () => Close());

        }



        public static bool Execute()
        {
            using (var dlg = new OrgEditDialog())
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
