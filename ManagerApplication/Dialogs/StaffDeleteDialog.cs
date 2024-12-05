using System;
using Wisej.Web;
using ManagerApplication.Properties;
namespace ManagerApplication.Dialogs
{
    public partial class StaffDeleteDialog : Form
    {

        StaffControl sc = new StaffControl();

        int id = -1;
        public StaffDeleteDialog()
        {
            InitializeComponent();
        }

        private void StaffIDText_TextChanged(object sender, EventArgs e)
        {
            int parsedId;

            if (!int.TryParse(StaffIDText.Text, out parsedId))
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
                    sc.deleteStaff(id);
                    Close();
                })
                .Register(cancelBtn, () => Close());

        }



        public static bool Execute()
        {
            using (var dlg = new StaffDeleteDialog())
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
