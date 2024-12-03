
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
            LoadData();

        }

        private void LoadData()
        {
            OrgControl orgControl = new OrgControl();
            var organizations = orgControl.GetAllOrganizations();
            Organization.DataSource = organizations;

            StaffControl staffControl = new StaffControl(); 
            var staffs = staffControl.GetAllStaff();
            Staff.DataSource = staffs;
        }

        
        private void Organization_Click(object sender, EventArgs e)
        {
            Console.WriteLine("clicked!");
        } 

        private void Staff_DoubleClick(object sender, EventArgs e)
        {

        }

        private void Organization_DoubleClick(object sender, EventArgs e)
        {
            Console.WriteLine("double clicked!");
        }

        private void Staff_Click(object sender, EventArgs e)
        {

        }
    }
}
