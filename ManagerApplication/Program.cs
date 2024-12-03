using System;
using Wisej.Web;

namespace ManagerApplication
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            /**
            OrgControl oc = new OrgControl();
            StaffControl sc = new StaffControl();

            Organization org = new Organization
            {
                OrganizationId = 1,
                name = "Subway",
                street = "That Street",
                zip = "78218",
                city = "San Antonio",
                country = "U.S.",
            };


            Staff staff = new Staff
            {
                StaffId = 1,
                title = "Mr.",
                firstName = "An",
                lastName = "Chau",
                phone = "210",
                email = "anchau001",
                OrganizationId = 1  // Make sure this corresponds to an existing Organization ID in your database
            };

            oc.updateOrg(org);
            sc.addStaff(staff);
            **/

            Window1 window = new Window1();
            window.Show();

        }

        //
        // You can use the entry method below
        // to receive the parameters from the URL in the args collection.
        //
        //static void Main(NameValueCollection args)
        //{
        //}
    }
}