﻿
using System;
using System.Linq;
using ManagerApplication.Dialogs;
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


        private void Staff_Click(object sender, EventArgs e)
        {

        }

        private void OrgEditBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Org Edit Button");

            if (OrgEditDialog.Execute())
            {
                LoadData();
                return;
            }
        }

        private void OrgDelBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Org Delete Button");

            if (OrgDeleteDialog.Execute())
            {
                LoadData();
                return;
            }
        }

        private void OrgAddBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Org Add Button");
            
            if (OrgAddDialog.Execute())
            {
                LoadData();
                return;
            }
        }

        private void StaffAddBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Staff Add Button");

            if (StaffAddDialog.Execute())
            {
                LoadData();
                return;
            }
        }

        private void StaffEditBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Staff Edit Button");

            if (StaffEditDialog.Execute())
            {
                LoadData();
                return;
            }
        }

        private void StaffDelBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Staff Delete Button");

            if (StaffDeleteDialog.Execute())
            {
                LoadData();
                return;
            }
        }
    }
}
