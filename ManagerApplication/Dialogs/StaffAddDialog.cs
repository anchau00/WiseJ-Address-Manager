using System;
using Wisej.Web;
using ManagerApplication.Properties;

namespace ManagerApplication.Dialogs
{
    public partial class StaffAddDialog : Form
    {

        StaffControl sc = new StaffControl();

        Staff staff = new Staff
        {
            title = "",
            firstName = "",
            lastName = "",
            phone = "",
            email = "",
            OrganizationId = -1  
        };
        public StaffAddDialog()
        {
            InitializeComponent();
        }

        private void TitleText_TextChanged(object sender, EventArgs e)
        {
            staff.title = TitleText.Text;
        }

        private void FirstNameText_TextChanged(object sender, EventArgs e)
        {
            staff.firstName = FirstNameText.Text;
        }

        private void LastNameText_TextChanged(object sender, EventArgs e)
        {
            staff.lastName = LastNameText.Text;
        }

        private void OrgIdText_TextChanged(object sender, EventArgs e)
        {
            int parsedId;

            if (!int.TryParse(OrgIdText.Text, out parsedId))
            {
                parsedId = 0;
            }
            staff.OrganizationId = parsedId;
        }

        private void EmailText_TextChanged(object sender, EventArgs e)
        {
            staff.email = EmailText.Text;
        }

        private void PhoneText_TextChanged(object sender, EventArgs e)
        {
            staff.phone = PhoneText.Text;
        }

        private void Preset()
        {

            Commands
                .Register(OkBtn, () =>
                {
                    sc.addStaff(staff);  
                    Close();
                })
                .Register(cancelBtn, () => Close());

        }



        public static bool Execute()
        {
            using (var dlg = new StaffAddDialog())
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
