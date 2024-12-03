
using System;
using System.Linq;
using Wisej.Web;

namespace ManagerApplication
{
    public partial class Window1 : Form
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window1_Load(object sender, EventArgs e)
        {
            LoadOrg();

        }

        private void LoadOrg()
        {
            OrgControl orgControl = new OrgControl();
            var organizations = orgControl.GetAllOrganizations();
            //Organization.DataSource = organizations;
        }

        private void Organization_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }
    }
}
