﻿
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

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
