namespace ManagerApplication.Dialogs
{
    partial class OrgAddDialog
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
            this.OkBtn = new Wisej.Web.Button();
            this.cancelBtn = new Wisej.Web.Button();
            this.panel1 = new Wisej.Web.Panel();
            this.OrgNameLabel = new Wisej.Web.Label();
            this.OrgNameText = new Wisej.Web.TextBox();
            this.OrgStreetText = new Wisej.Web.TextBox();
            this.StreetLabel = new Wisej.Web.Label();
            this.OrgZipText = new Wisej.Web.TextBox();
            this.contextMenu1 = new Wisej.Web.ContextMenu(this.components);
            this.OrgCityText = new Wisej.Web.TextBox();
            this.OrgCountryText = new Wisej.Web.TextBox();
            this.contextMenu2 = new Wisej.Web.ContextMenu(this.components);
            this.contextMenu3 = new Wisej.Web.ContextMenu(this.components);
            this.ZipLabel = new Wisej.Web.Label();
            this.CityLabel = new Wisej.Web.Label();
            this.CountryLabel = new Wisej.Web.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = Wisej.Web.AnchorStyles.Bottom;
            this.OkBtn.DialogResult = Wisej.Web.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(250, 7);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(164, 37);
            this.OkBtn.TabIndex = 0;
            this.OkBtn.Text = "OK";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = Wisej.Web.AnchorStyles.Bottom;
            this.cancelBtn.DialogResult = Wisej.Web.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(510, 7);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(164, 37);
            this.cancelBtn.TabIndex = 0;
            this.cancelBtn.Text = "CANCEL";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.OkBtn);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Location = new System.Drawing.Point(3, 380);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 47);
            this.panel1.TabIndex = 2;
            // 
            // OrgNameLabel
            // 
            this.OrgNameLabel.AutoSize = true;
            this.OrgNameLabel.Location = new System.Drawing.Point(238, 53);
            this.OrgNameLabel.Name = "OrgNameLabel";
            this.OrgNameLabel.Size = new System.Drawing.Size(42, 18);
            this.OrgNameLabel.TabIndex = 3;
            this.OrgNameLabel.Text = "Name:";
            // 
            // OrgNameText
            // 
            this.OrgNameText.Location = new System.Drawing.Point(287, 53);
            this.OrgNameText.Name = "OrgNameText";
            this.OrgNameText.Size = new System.Drawing.Size(100, 30);
            this.OrgNameText.TabIndex = 4;
            this.OrgNameText.TextChanged += new System.EventHandler(this.OrgNameText_TextChanged);
            // 
            // OrgStreetText
            // 
            this.OrgStreetText.Location = new System.Drawing.Point(287, 127);
            this.OrgStreetText.Name = "OrgStreetText";
            this.OrgStreetText.Size = new System.Drawing.Size(100, 30);
            this.OrgStreetText.TabIndex = 5;
            this.OrgStreetText.TextChanged += new System.EventHandler(this.OrgStreetText_TextChanged);
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Location = new System.Drawing.Point(238, 127);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(41, 18);
            this.StreetLabel.TabIndex = 3;
            this.StreetLabel.Text = "Street:";
            // 
            // OrgZipText
            // 
            this.OrgZipText.Location = new System.Drawing.Point(287, 196);
            this.OrgZipText.Name = "OrgZipText";
            this.OrgZipText.Size = new System.Drawing.Size(100, 30);
            this.OrgZipText.TabIndex = 6;
            this.OrgZipText.TextChanged += new System.EventHandler(this.OrgZipText_TextChanged);
            // 
            // contextMenu1
            // 
            this.contextMenu1.Name = "contextMenu1";
            // 
            // OrgCityText
            // 
            this.OrgCityText.Location = new System.Drawing.Point(507, 52);
            this.OrgCityText.Name = "OrgCityText";
            this.OrgCityText.Size = new System.Drawing.Size(100, 30);
            this.OrgCityText.TabIndex = 7;
            this.OrgCityText.TextChanged += new System.EventHandler(this.OrgCityText_TextChanged);
            // 
            // OrgCountryText
            // 
            this.OrgCountryText.Location = new System.Drawing.Point(507, 126);
            this.OrgCountryText.Name = "OrgCountryText";
            this.OrgCountryText.Size = new System.Drawing.Size(100, 30);
            this.OrgCountryText.TabIndex = 8;
            this.OrgCountryText.TextChanged += new System.EventHandler(this.OrgCountryText_TextChanged);
            // 
            // contextMenu2
            // 
            this.contextMenu2.Name = "contextMenu2";
            // 
            // contextMenu3
            // 
            this.contextMenu3.Name = "contextMenu3";
            // 
            // ZipLabel
            // 
            this.ZipLabel.AutoSize = true;
            this.ZipLabel.Location = new System.Drawing.Point(253, 199);
            this.ZipLabel.Name = "ZipLabel";
            this.ZipLabel.Size = new System.Drawing.Size(26, 18);
            this.ZipLabel.TabIndex = 3;
            this.ZipLabel.Text = "Zip:";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(472, 52);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(29, 18);
            this.CityLabel.TabIndex = 3;
            this.CityLabel.Text = "City:";
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(448, 126);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(53, 18);
            this.CountryLabel.TabIndex = 3;
            this.CountryLabel.Text = "Country:";
            // 
            // OrgAddDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromName("@gray-100");
            this.ClientSize = new System.Drawing.Size(798, 430);
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
            this.Name = "OrgAddDialog";
            this.Text = "OrgAddDialog";
            this.Load += new System.EventHandler(this.OrgAddDialog_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Button OkBtn;
        private Wisej.Web.Button cancelBtn;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.Label OrgNameLabel;
        private Wisej.Web.TextBox OrgNameText;
        private Wisej.Web.TextBox OrgStreetText;
        private Wisej.Web.Label StreetLabel;
        private Wisej.Web.TextBox OrgZipText;
        private Wisej.Web.ContextMenu contextMenu1;
        private Wisej.Web.TextBox OrgCityText;
        private Wisej.Web.TextBox OrgCountryText;
        private Wisej.Web.ContextMenu contextMenu2;
        private Wisej.Web.ContextMenu contextMenu3;
        private Wisej.Web.Label ZipLabel;
        private Wisej.Web.Label CityLabel;
        private Wisej.Web.Label CountryLabel;
    }
}