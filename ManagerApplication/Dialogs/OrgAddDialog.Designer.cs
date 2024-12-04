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
            this.OkBtn = new Wisej.Web.Button();
            this.cancelBtn = new Wisej.Web.Button();
            this.panel1 = new Wisej.Web.Panel();
            this.OrgNameLabel = new Wisej.Web.Label();
            this.OrgNameText = new Wisej.Web.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = Wisej.Web.AnchorStyles.Bottom;
            this.OkBtn.DialogResult = Wisej.Web.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(314, 6);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(164, 37);
            this.OkBtn.TabIndex = 0;
            this.OkBtn.Text = "OK";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = Wisej.Web.AnchorStyles.Bottom;
            this.cancelBtn.DialogResult = Wisej.Web.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(574, 6);
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
            this.OrgNameLabel.Location = new System.Drawing.Point(128, 52);
            this.OrgNameLabel.Name = "OrgNameLabel";
            this.OrgNameLabel.Size = new System.Drawing.Size(42, 18);
            this.OrgNameLabel.TabIndex = 3;
            this.OrgNameLabel.Text = "Name:";
            // 
            // OrgNameText
            // 
            this.OrgNameText.Location = new System.Drawing.Point(177, 52);
            this.OrgNameText.Name = "OrgNameText";
            this.OrgNameText.Size = new System.Drawing.Size(100, 30);
            this.OrgNameText.TabIndex = 4;
            this.OrgNameText.TextChanged += new System.EventHandler(this.OrgNameText_TextChanged);
            // 
            // OrgAddDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 430);
            this.Controls.Add(this.OrgNameText);
            this.Controls.Add(this.OrgNameLabel);
            this.Controls.Add(this.panel1);
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
    }
}