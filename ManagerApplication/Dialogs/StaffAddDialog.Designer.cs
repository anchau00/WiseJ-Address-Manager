﻿namespace ManagerApplication.Dialogs
{
    partial class StaffAddDialog
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
            this.label1 = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.label3 = new Wisej.Web.Label();
            this.label4 = new Wisej.Web.Label();
            this.label5 = new Wisej.Web.Label();
            this.label6 = new Wisej.Web.Label();
            this.TitleText = new Wisej.Web.TextBox();
            this.FirstNameText = new Wisej.Web.TextBox();
            this.LastNameText = new Wisej.Web.TextBox();
            this.PhoneText = new Wisej.Web.TextBox();
            this.EmailText = new Wisej.Web.TextBox();
            this.OrgIdText = new Wisej.Web.TextBox();
            this.OkBtn = new Wisej.Web.Button();
            this.cancelBtn = new Wisej.Web.Button();
            this.panel1 = new Wisej.Web.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "First name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Last name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Organization ID:";
            // 
            // TitleText
            // 
            this.TitleText.Location = new System.Drawing.Point(265, 104);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(100, 30);
            this.TitleText.TabIndex = 1;
            this.TitleText.TextChanged += new System.EventHandler(this.TitleText_TextChanged);
            // 
            // FirstNameText
            // 
            this.FirstNameText.Location = new System.Drawing.Point(265, 151);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(100, 30);
            this.FirstNameText.TabIndex = 2;
            this.FirstNameText.TextChanged += new System.EventHandler(this.FirstNameText_TextChanged);
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(265, 208);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(100, 30);
            this.LastNameText.TabIndex = 3;
            this.LastNameText.TextChanged += new System.EventHandler(this.LastNameText_TextChanged);
            // 
            // PhoneText
            // 
            this.PhoneText.Location = new System.Drawing.Point(491, 104);
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.Size = new System.Drawing.Size(100, 30);
            this.PhoneText.TabIndex = 4;
            this.PhoneText.TextChanged += new System.EventHandler(this.PhoneText_TextChanged);
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(491, 151);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(100, 30);
            this.EmailText.TabIndex = 5;
            this.EmailText.TextChanged += new System.EventHandler(this.EmailText_TextChanged);
            // 
            // OrgIdText
            // 
            this.OrgIdText.Location = new System.Drawing.Point(491, 208);
            this.OrgIdText.Name = "OrgIdText";
            this.OrgIdText.Size = new System.Drawing.Size(100, 30);
            this.OrgIdText.TabIndex = 6;
            this.OrgIdText.TextChanged += new System.EventHandler(this.OrgIdText_TextChanged);
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = Wisej.Web.AnchorStyles.Bottom;
            this.OkBtn.DialogResult = Wisej.Web.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(352, 3);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(164, 37);
            this.OkBtn.TabIndex = 0;
            this.OkBtn.Text = "OK";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = Wisej.Web.AnchorStyles.Bottom;
            this.cancelBtn.DialogResult = Wisej.Web.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(597, 3);
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
            this.panel1.Location = new System.Drawing.Point(-151, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 55);
            this.panel1.TabIndex = 7;
            // 
            // StaffAddDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromName("@gray-100");
            this.ClientSize = new System.Drawing.Size(798, 430);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OrgIdText);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.PhoneText);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.FirstNameText);
            this.Controls.Add(this.TitleText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.HeaderBackColor = System.Drawing.Color.FromName("@dark");
            this.Name = "StaffAddDialog";
            this.Text = "Adding Staff";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Label label1;
        private Wisej.Web.Label label2;
        private Wisej.Web.Label label3;
        private Wisej.Web.Label label4;
        private Wisej.Web.Label label5;
        private Wisej.Web.Label label6;
        private Wisej.Web.TextBox TitleText;
        private Wisej.Web.TextBox FirstNameText;
        private Wisej.Web.TextBox LastNameText;
        private Wisej.Web.TextBox PhoneText;
        private Wisej.Web.TextBox EmailText;
        private Wisej.Web.TextBox OrgIdText;
        private Wisej.Web.Button OkBtn;
        private Wisej.Web.Button cancelBtn;
        private Wisej.Web.Panel panel1;
    }
}