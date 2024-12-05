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
            this.Organization = new Wisej.Web.DataGridView();
            this.colOrganizationid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colName = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colStreet = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colZip = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colCity = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colCountry = new Wisej.Web.DataGridViewTextBoxColumn();
            this.OrgAddBtn = new Wisej.Web.Button();
            this.OrgEditBtn = new Wisej.Web.Button();
            this.OrgDelBtn = new Wisej.Web.Button();
            this.aspNetPanel1 = new Wisej.Web.AspNetPanel();
            this.organizationBindingSource = new Wisej.Web.BindingSource(this.components);
            this.StaffTab = new Wisej.Web.TabPage();
            this.Staff = new Wisej.Web.DataGridView();
            this.colStaffid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colTitle = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colFirstname = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colLastname = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colPhone = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colEmail = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.StaffAddBtn = new Wisej.Web.Button();
            this.StaffEditBtn = new Wisej.Web.Button();
            this.StaffDelBtn = new Wisej.Web.Button();
            this.aspNetPanel2 = new Wisej.Web.AspNetPanel();
            this.staffBindingSource = new Wisej.Web.BindingSource(this.components);
            this.organizationBindingSource2 = new Wisej.Web.BindingSource(this.components);
            this.organizationBindingSource1 = new Wisej.Web.BindingSource(this.components);
            this.orgControlBindingSource = new Wisej.Web.BindingSource(this.components);
            this.Tabs.SuspendLayout();
            this.OrganizationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Organization)).BeginInit();
            this.Organization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).BeginInit();
            this.StaffTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Staff)).BeginInit();
            this.Staff.SuspendLayout();
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
            // 
            // OrganizationTab
            // 
            this.OrganizationTab.Controls.Add(this.Organization);
            this.OrganizationTab.Location = new System.Drawing.Point(1, 40);
            this.OrganizationTab.Name = "OrganizationTab";
            this.OrganizationTab.Size = new System.Drawing.Size(1536, 556);
            this.OrganizationTab.Text = "Organizations";
            // 
            // Organization
            // 
            this.Organization.AutoGenerateColumns = false;
            this.Organization.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colOrganizationid,
            this.colName,
            this.colStreet,
            this.colZip,
            this.colCity,
            this.colCountry});
            this.Organization.Controls.Add(this.OrgAddBtn);
            this.Organization.Controls.Add(this.OrgEditBtn);
            this.Organization.Controls.Add(this.OrgDelBtn);
            this.Organization.Controls.Add(this.aspNetPanel1);
            this.Organization.DataSource = this.organizationBindingSource;
            this.Organization.Dock = Wisej.Web.DockStyle.Fill;
            this.Organization.EditMode = Wisej.Web.DataGridViewEditMode.EditOnKeystroke;
            this.Organization.Location = new System.Drawing.Point(0, 0);
            this.Organization.Name = "Organization";
            this.Organization.ReadOnly = true;
            this.Organization.Size = new System.Drawing.Size(1536, 556);
            this.Organization.TabIndex = 0;
            // 
            // colOrganizationid
            // 
            this.colOrganizationid.DataPropertyName = "OrganizationId";
            this.colOrganizationid.HeaderText = "OrganizationId";
            this.colOrganizationid.Name = "colOrganizationid";
            this.colOrganizationid.ShowInVisibilityMenu = false;
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
            // OrgAddBtn
            // 
            this.OrgAddBtn.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.OrgAddBtn.Location = new System.Drawing.Point(536, 446);
            this.OrgAddBtn.Name = "OrgAddBtn";
            this.OrgAddBtn.Size = new System.Drawing.Size(115, 72);
            this.OrgAddBtn.TabIndex = 3;
            this.OrgAddBtn.Text = "Add";
            this.OrgAddBtn.Click += new System.EventHandler(this.OrgAddBtn_Click);
            // 
            // OrgEditBtn
            // 
            this.OrgEditBtn.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.OrgEditBtn.Location = new System.Drawing.Point(709, 446);
            this.OrgEditBtn.Name = "OrgEditBtn";
            this.OrgEditBtn.Size = new System.Drawing.Size(115, 72);
            this.OrgEditBtn.TabIndex = 2;
            this.OrgEditBtn.Text = "Edit";
            this.OrgEditBtn.Click += new System.EventHandler(this.OrgEditBtn_Click);
            // 
            // OrgDelBtn
            // 
            this.OrgDelBtn.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.OrgDelBtn.Location = new System.Drawing.Point(878, 446);
            this.OrgDelBtn.Name = "OrgDelBtn";
            this.OrgDelBtn.Size = new System.Drawing.Size(115, 72);
            this.OrgDelBtn.TabIndex = 1;
            this.OrgDelBtn.Text = "Delete";
            this.OrgDelBtn.Click += new System.EventHandler(this.OrgDelBtn_Click);
            // 
            // aspNetPanel1
            // 
            this.aspNetPanel1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.aspNetPanel1.Location = new System.Drawing.Point(-2, 397);
            this.aspNetPanel1.Name = "aspNetPanel1";
            this.aspNetPanel1.ScrollBars = false;
            this.aspNetPanel1.Size = new System.Drawing.Size(1537, 170);
            this.aspNetPanel1.TabIndex = 0;
            this.aspNetPanel1.Text = "aspNetPanel1";
            // 
            // organizationBindingSource
            // 
            this.organizationBindingSource.DataSource = typeof(Organization);
            // 
            // StaffTab
            // 
            this.StaffTab.Controls.Add(this.Staff);
            this.StaffTab.Location = new System.Drawing.Point(1, 40);
            this.StaffTab.Name = "StaffTab";
            this.StaffTab.Size = new System.Drawing.Size(1536, 556);
            this.StaffTab.Text = "Staff";
            // 
            // Staff
            // 
            this.Staff.AutoGenerateColumns = false;
            this.Staff.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colStaffid,
            this.colTitle,
            this.colFirstname,
            this.colLastname,
            this.colPhone,
            this.colEmail,
            this.dataGridViewTextBoxColumn1});
            this.Staff.Controls.Add(this.StaffAddBtn);
            this.Staff.Controls.Add(this.StaffEditBtn);
            this.Staff.Controls.Add(this.StaffDelBtn);
            this.Staff.Controls.Add(this.aspNetPanel2);
            this.Staff.DataSource = this.staffBindingSource;
            this.Staff.Dock = Wisej.Web.DockStyle.Fill;
            this.Staff.Location = new System.Drawing.Point(0, 0);
            this.Staff.Name = "Staff";
            this.Staff.ReadOnly = true;
            this.Staff.Size = new System.Drawing.Size(1536, 556);
            this.Staff.TabIndex = 1;
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
            this.colEmail.Width = 250;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OrganizationId";
            this.dataGridViewTextBoxColumn1.HeaderText = "OrganizationId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ValueType = typeof(int);
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // StaffAddBtn
            // 
            this.StaffAddBtn.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.StaffAddBtn.Location = new System.Drawing.Point(536, 446);
            this.StaffAddBtn.Name = "StaffAddBtn";
            this.StaffAddBtn.Size = new System.Drawing.Size(115, 72);
            this.StaffAddBtn.TabIndex = 7;
            this.StaffAddBtn.Text = "Add";
            this.StaffAddBtn.Click += new System.EventHandler(this.StaffAddBtn_Click);
            // 
            // StaffEditBtn
            // 
            this.StaffEditBtn.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.StaffEditBtn.Location = new System.Drawing.Point(709, 446);
            this.StaffEditBtn.Name = "StaffEditBtn";
            this.StaffEditBtn.Size = new System.Drawing.Size(115, 72);
            this.StaffEditBtn.TabIndex = 6;
            this.StaffEditBtn.Text = "Edit";
            this.StaffEditBtn.Click += new System.EventHandler(this.StaffEditBtn_Click);
            // 
            // StaffDelBtn
            // 
            this.StaffDelBtn.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.StaffDelBtn.Location = new System.Drawing.Point(878, 446);
            this.StaffDelBtn.Name = "StaffDelBtn";
            this.StaffDelBtn.Size = new System.Drawing.Size(115, 72);
            this.StaffDelBtn.TabIndex = 5;
            this.StaffDelBtn.Text = "Delete";
            this.StaffDelBtn.Click += new System.EventHandler(this.StaffDelBtn_Click);
            // 
            // aspNetPanel2
            // 
            this.aspNetPanel2.Location = new System.Drawing.Point(-2, 397);
            this.aspNetPanel2.Name = "aspNetPanel2";
            this.aspNetPanel2.ScrollBars = false;
            this.aspNetPanel2.Size = new System.Drawing.Size(1537, 154);
            this.aspNetPanel2.TabIndex = 4;
            this.aspNetPanel2.Text = "aspNetPanel2";
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
            this.Text = "Manager Application";
            this.Load += new System.EventHandler(this.Window1_Load);
            this.Tabs.ResumeLayout(false);
            this.OrganizationTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Organization)).EndInit();
            this.Organization.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).EndInit();
            this.StaffTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Staff)).EndInit();
            this.Staff.ResumeLayout(false);
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
        private Wisej.Web.AspNetPanel aspNetPanel1;
        private Wisej.Web.Button OrgDelBtn;
        private Wisej.Web.Button OrgAddBtn;
        private Wisej.Web.Button OrgEditBtn;
        private Wisej.Web.Button StaffAddBtn;
        private Wisej.Web.Button StaffEditBtn;
        private Wisej.Web.Button StaffDelBtn;
        private Wisej.Web.AspNetPanel aspNetPanel2;
    }
}

