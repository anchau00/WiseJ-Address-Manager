using System;
using System.ComponentModel.Design;
using ManagerApplication.Properties;
using Wisej.Web;


namespace ManagerApplication.Dialogs
{
    public partial class OrgAddDialog : Form
    {
        private string currentText = "";
        public OrgAddDialog()
        {
            InitializeComponent();
        }

        private void OrgAddDialog_Load(object sender, EventArgs e)
        {

        }

        private void OrgNameText_TextChanged(object sender, EventArgs e)
        {
            currentText = OrgNameText.Text;


        }

        private void Preset()
        {
            
            Commands
                .Register(OkBtn, () =>
                {
                    Console.WriteLine(currentText);  // Use the current text when OkBtn is clicked
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
