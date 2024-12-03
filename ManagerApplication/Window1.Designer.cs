namespace ManagerApplication
{
    partial class Window1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Wisej.NET Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Tabs = new Wisej.Web.TabControl();
            this.OrganizationTab = new Wisej.Web.TabPage();
            this.StaffTab = new Wisej.Web.TabPage();
            this.Organization = new Wisej.Web.DataGridView();
            this.colOrganizationid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colName = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colStreet = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colZip = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colCity = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colCountry = new Wisej.Web.DataGridViewTextBoxColumn();
            this.Staff = new Wisej.Web.DataGridView();
            this.dataGridViewTextBoxColumn1 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colStaffid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colTitle = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colFirstname = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colLastname = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colPhone = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colEmail = new Wisej.Web.DataGridViewTextBoxColumn();
            this.organizationBindingSource = new Wisej.Web.BindingSource(this.components);
            this.staffBindingSource = new Wisej.Web.BindingSource(this.components);
            this.organizationBindingSource2 = new Wisej.Web.BindingSource(this.components);
            this.organizationBindingSource1 = new Wisej.Web.BindingSource(this.components);
            this.orgControlBindingSource = new Wisej.Web.BindingSource(this.components);
            this.Tabs.SuspendLayout();
            this.OrganizationTab.SuspendLayout();
            this.StaffTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Organization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Staff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgControlBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.Tabs.Controls.Add(this.OrganizationTab);
            this.Tabs.Controls.Add(this.StaffTab);
            this.Tabs.Location = new System.Drawing.Point(3, 3);
            this.Tabs.Name = "Tabs";
            this.Tabs.PageInsets = new Wisej.Web.Padding(1, 40, 1, 1);
            this.Tabs.Size = new System.Drawing.Size(1538, 597);
            this.Tabs.TabIndex = 0;
            this.Tabs.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // OrganizationTab
            // 
            this.OrganizationTab.Controls.Add(this.Organization);
            this.OrganizationTab.Location = new System.Drawing.Point(1, 40);
            this.OrganizationTab.Name = "OrganizationTab";
            this.OrganizationTab.Size = new System.Drawing.Size(1536, 556);
            this.OrganizationTab.Text = "Organizations";
            // 
            // StaffTab
            // 
            this.StaffTab.Controls.Add(this.Staff);
            this.StaffTab.Location = new System.Drawing.Point(1, 40);
            this.StaffTab.Name = "StaffTab";
            this.StaffTab.Size = new System.Drawing.Size(1536, 556);
            this.StaffTab.Text = "Staff";
            // 
            // Organization
            // 
            this.Organization.AllowUserToAddRows = true;
            this.Organization.AllowUserToDeleteRows = true;
            this.Organization.AutoGenerateColumns = false;
            this.Organization.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colOrganizationid,
            this.colName,
            this.colStreet,
            this.colZip,
            this.colCity,
            this.colCountry});
            this.Organization.DataSource = this.organizationBindingSource;
            this.Organization.Dock = Wisej.Web.DockStyle.Fill;
            this.Organization.Location = new System.Drawing.Point(0, 0);
            this.Organization.Name = "Organization";
            this.Organization.Size = new System.Drawing.Size(1536, 556);
            this.Organization.TabIndex = 0;
            this.Organization.Click += new System.EventHandler(this.dataGridView1_Click_1);
            // 
            // colOrganizationid
            // 
            this.colOrganizationid.DataPropertyName = "OrganizationId";
            this.colOrganizationid.HeaderText = "OrganizationId";
            this.colOrganizationid.Name = "colOrganizationid";
            this.colOrganizationid.ValueType = typeof(int);
            this.colOrganizationid.Width = 150;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "name";
            this.colName.HeaderText = "name";
            this.colName.Name = "colName";
            this.colName.ValueType = typeof(string);
            // 
            // colStreet
            // 
            this.colStreet.DataPropertyName = "street";
            this.colStreet.HeaderText = "street";
            this.colStreet.Name = "colStreet";
            this.colStreet.ValueType = typeof(string);
            // 
            // colZip
            // 
            this.colZip.DataPropertyName = "zip";
            this.colZip.HeaderText = "zip";
            this.colZip.Name = "colZip";
            this.colZip.ValueType = typeof(string);
            // 
            // colCity
            // 
            this.colCity.DataPropertyName = "city";
            this.colCity.HeaderText = "city";
            this.colCity.Name = "colCity";
            this.colCity.ValueType = typeof(string);
            // 
            // colCountry
            // 
            this.colCountry.DataPropertyName = "country";
            this.colCountry.HeaderText = "country";
            this.colCountry.Name = "colCountry";
            this.colCountry.ValueType = typeof(string);
            // 
            // Staff
            // 
            this.Staff.AllowUserToAddRows = true;
            this.Staff.AllowUserToDeleteRows = true;
            this.Staff.AutoGenerateColumns = false;
            this.Staff.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colStaffid,
            this.colTitle,
            this.colFirstname,
            this.colLastname,
            this.colPhone,
            this.colEmail,
            this.dataGridViewTextBoxColumn1});
            this.Staff.DataSource = this.staffBindingSource;
            this.Staff.Dock = Wisej.Web.DockStyle.Fill;
            this.Staff.Location = new System.Drawing.Point(0, 0);
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(1536, 556);
            this.Staff.TabIndex = 1;
            this.Staff.Click += new System.EventHandler(this.dataGridView2_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OrganizationId";
            this.dataGridViewTextBoxColumn1.HeaderText = "OrganizationId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ValueType = typeof(int);
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // colStaffid
            // 
            this.colStaffid.DataPropertyName = "StaffId";
            this.colStaffid.HeaderText = "StaffId";
            this.colStaffid.Name = "colStaffid";
            this.colStaffid.ValueType = typeof(int);
            // 
            // colTitle
            // 
            this.colTitle.DataPropertyName = "title";
            this.colTitle.HeaderText = "title";
            this.colTitle.Name = "colTitle";
            this.colTitle.ValueType = typeof(string);
            // 
            // colFirstname
            // 
            this.colFirstname.DataPropertyName = "firstName";
            this.colFirstname.HeaderText = "firstName";
            this.colFirstname.Name = "colFirstname";
            this.colFirstname.ValueType = typeof(string);
            // 
            // colLastname
            // 
            this.colLastname.DataPropertyName = "lastName";
            this.colLastname.HeaderText = "lastName";
            this.colLastname.Name = "colLastname";
            this.colLastname.ValueType = typeof(string);
            // 
            // colPhone
            // 
            this.colPhone.DataPropertyName = "phone";
            this.colPhone.HeaderText = "phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.ValueType = typeof(string);
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "email";
            this.colEmail.HeaderText = "email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ValueType = typeof(string);
            // 
            // organizationBindingSource
            // 
            this.organizationBindingSource.DataSource = typeof(Organization);
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataSource = typeof(Staff);
            // 
            // organizationBindingSource2
            // 
            this.organizationBindingSource2.DataSource = typeof(Organization);
            // 
            // organizationBindingSource1
            // 
            this.organizationBindingSource1.DataSource = typeof(Organization);
            // 
            // orgControlBindingSource
            // 
            this.orgControlBindingSource.DataSource = typeof(OrgControl);
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromName("@table-row-selected");
            this.ClientSize = new System.Drawing.Size(9814, 4522);
            this.Controls.Add(this.Tabs);
            this.Font = new System.Drawing.Font("@default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromName("@activeBorder");
            this.HeaderBackColor = System.Drawing.Color.FromName("@dark");
            this.HeaderForeColor = System.Drawing.Color.White;
            this.Margin = new Wisej.Web.Padding(21, 19, 21, 19);
            this.Name = "Window1";
            this.Text = "Window1";
            this.Load += new System.EventHandler(this.Window1_Load);
            this.Tabs.ResumeLayout(false);
            this.OrganizationTab.ResumeLayout(false);
            this.StaffTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Organization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Staff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgControlBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Wisej.Web.BindingSource organizationBindingSource;
        private Wisej.Web.BindingSource organizationBindingSource1;
        private Wisej.Web.BindingSource organizationBindingSource2;
        private Wisej.Web.BindingSource orgControlBindingSource;
        private Wisej.Web.BindingSource staffBindingSource;
        private Wisej.Web.TabControl Tabs;
        private Wisej.Web.TabPage OrganizationTab;
        private Wisej.Web.TabPage StaffTab;
        private Wisej.Web.DataGridView Organization;
        private Wisej.Web.DataGridViewTextBoxColumn colOrganizationid;
        private Wisej.Web.DataGridViewTextBoxColumn colName;
        private Wisej.Web.DataGridViewTextBoxColumn colStreet;
        private Wisej.Web.DataGridViewTextBoxColumn colZip;
        private Wisej.Web.DataGridViewTextBoxColumn colCity;
        private Wisej.Web.DataGridViewTextBoxColumn colCountry;
        private Wisej.Web.DataGridView Staff;
        private Wisej.Web.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Wisej.Web.DataGridViewTextBoxColumn colStaffid;
        private Wisej.Web.DataGridViewTextBoxColumn colTitle;
        private Wisej.Web.DataGridViewTextBoxColumn colFirstname;
        private Wisej.Web.DataGridViewTextBoxColumn colLastname;
        private Wisej.Web.DataGridViewTextBoxColumn colPhone;
        private Wisej.Web.DataGridViewTextBoxColumn colEmail;
    }
}

