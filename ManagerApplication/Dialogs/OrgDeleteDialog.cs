using System;
using Wisej.Web;
using ManagerApplication.Properties;

namespace ManagerApplication.Dialogs
{
    public partial class OrgDeleteDialog : Form
    {
        OrgControl oc = new OrgControl();

        int id = -1;
        public OrgDeleteDialog()
        {
            InitializeComponent();
        }

        private void IDText_TextChanged(object sender, EventArgs e)
        {

            int parsedId;

            if (!int.TryParse(IDText.Text, out parsedId))
            {
                parsedId = 0;
            }
            id = parsedId;

        }

        private void Preset()
        {

            Commands
                .Register(OkBtn, () =>
                {
                    oc.deleteOrg(id);
                    Close();
                })
                .Register(cancelBtn, () => Close());

        }

        public static bool Execute()
        {
            using (var dlg = new OrgDeleteDialog())
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
