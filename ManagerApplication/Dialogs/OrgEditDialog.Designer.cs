namespace ManagerApplication
{
    partial class OrgEditDialog
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
            this.OkBtn = new Wisej.Web.Button();
            this.cancelBtn = new Wisej.Web.Button();
            this.panel1 = new Wisej.Web.Panel();
            this.OrgCountryText = new Wisej.Web.TextBox();
            this.OrgCityText = new Wisej.Web.TextBox();
            this.OrgZipText = new Wisej.Web.TextBox();
            this.OrgStreetText = new Wisej.Web.TextBox();
            this.OrgNameText = new Wisej.Web.TextBox();
            this.ZipLabel = new Wisej.Web.Label();
            this.StreetLabel = new Wisej.Web.Label();
            this.CountryLabel = new Wisej.Web.Label();
            this.CityLabel = new Wisej.Web.Label();
            this.OrgNameLabel = new Wisej.Web.Label();
            this.label1 = new Wisej.Web.Label();
            this.IDText = new Wisej.Web.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = Wisej.Web.AnchorStyles.Bottom;
            this.OkBtn.DialogResult = Wisej.Web.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(202, 7);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(164, 37);
            this.OkBtn.TabIndex = 0;
            this.OkBtn.Text = "OK";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = Wisej.Web.AnchorStyles.Bottom;
            this.cancelBtn.DialogResult = Wisej.Web.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(462, 7);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(164, 37);
            this.cancelBtn.TabIndex = 0;
            this.cancelBtn.Text = "CANCEL";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OkBtn);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Location = new System.Drawing.Point(-1, 384);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 47);
            this.panel1.TabIndex = 1;
            // 
            // OrgCountryText
            // 
            this.OrgCountryText.Location = new System.Drawing.Point(486, 140);
            this.OrgCountryText.Name = "OrgCountryText";
            this.OrgCountryText.Size = new System.Drawing.Size(100, 30);
            this.OrgCountryText.TabIndex = 18;
            this.OrgCountryText.TextChanged += new System.EventHandler(this.OrgCountryText_TextChanged);
            // 
            // OrgCityText
            // 
            this.OrgCityText.Location = new System.Drawing.Point(486, 66);
            this.OrgCityText.Name = "OrgCityText";
            this.OrgCityText.Size = new System.Drawing.Size(100, 30);
            this.OrgCityText.TabIndex = 17;
            this.OrgCityText.TextChanged += new System.EventHandler(this.OrgCityText_TextChanged);
            // 
            // OrgZipText
            // 
            this.OrgZipText.Location = new System.Drawing.Point(266, 210);
            this.OrgZipText.Name = "OrgZipText";
            this.OrgZipText.Size = new System.Drawing.Size(100, 30);
            this.OrgZipText.TabIndex = 16;
            this.OrgZipText.TextChanged += new System.EventHandler(this.OrgZipText_TextChanged);
            // 
            // OrgStreetText
            // 
            this.OrgStreetText.Location = new System.Drawing.Point(266, 141);
            this.OrgStreetText.Name = "OrgStreetText";
            this.OrgStreetText.Size = new System.Drawing.Size(100, 30);
            this.OrgStreetText.TabIndex = 15;
            this.OrgStreetText.TextChanged += new System.EventHandler(this.OrgStreetText_TextChanged);
            // 
            // OrgNameText
            // 
            this.OrgNameText.Location = new System.Drawing.Point(265, 67);
            this.OrgNameText.Name = "OrgNameText";
            this.OrgNameText.Size = new System.Drawing.Size(100, 30);
            this.OrgNameText.TabIndex = 14;
            this.OrgNameText.TextChanged += new System.EventHandler(this.OrgNameText_TextChanged);
            // 
            // ZipLabel
            // 
            this.ZipLabel.AutoSize = true;
            this.ZipLabel.Location = new System.Drawing.Point(232, 213);
            this.ZipLabel.Name = "ZipLabel";
            this.ZipLabel.Size = new System.Drawing.Size(26, 18);
            this.ZipLabel.TabIndex = 9;
            this.ZipLabel.Text = "Zip:";
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Location = new System.Drawing.Point(217, 141);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(41, 18);
            this.StreetLabel.TabIndex = 10;
            this.StreetLabel.Text = "Street:";
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(427, 140);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(53, 18);
            this.CountryLabel.TabIndex = 11;
            this.CountryLabel.Text = "Country:";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(451, 66);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(29, 18);
            this.CityLabel.TabIndex = 12;
            this.CityLabel.Text = "City:";
            // 
            // OrgNameLabel
            // 
            this.OrgNameLabel.AutoSize = true;
            this.OrgNameLabel.Location = new System.Drawing.Point(217, 67);
            this.OrgNameLabel.Name = "OrgNameLabel";
            this.OrgNameLabel.Size = new System.Drawing.Size(42, 18);
            this.OrgNameLabel.TabIndex = 13;
            this.OrgNameLabel.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID:";
            // 
            // IDText
            // 
            this.IDText.Location = new System.Drawing.Point(486, 210);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(100, 30);
            this.IDText.TabIndex = 20;
            this.IDText.TextChanged += new System.EventHandler(this.IDText_TextChanged);
            // 
            // OrgEditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromName("@gray-100");
            this.ClientSize = new System.Drawing.Size(798, 430);
            this.Controls.Add(this.IDText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrgCountryText);
            this.Controls.Add(this.OrgCityText);
            this.Controls.Add(this.OrgZipText);
            this.Controls.Add(this.OrgStreetText);
            this.Controls.Add(this.OrgNameText);
            this.Controls.Add(this.ZipLabel);
            this.Controls.Add(this.StreetLabel);
            this.Controls.Add(this.CountryLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.OrgNameLabel);
            this.Controls.Add(this.panel1);
            this.HeaderBackColor = System.Drawing.Color.FromName("@dark");
            this.Name = "OrgEditDialog";
            this.Text = "Organization Edit";
            this.Load += new System.EventHandler(this.OrgEditDialog_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Button OkBtn;
        private Wisej.Web.Button cancelBtn;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.TextBox OrgCountryText;
        private Wisej.Web.TextBox OrgCityText;
        private Wisej.Web.TextBox OrgZipText;
        private Wisej.Web.TextBox OrgStreetText;
        private Wisej.Web.TextBox OrgNameText;
        private Wisej.Web.Label ZipLabel;
        private Wisej.Web.Label StreetLabel;
        private Wisej.Web.Label CountryLabel;
        private Wisej.Web.Label CityLabel;
        private Wisej.Web.Label OrgNameLabel;
        private Wisej.Web.Label label1;
        private Wisej.Web.TextBox IDText;
    }
}