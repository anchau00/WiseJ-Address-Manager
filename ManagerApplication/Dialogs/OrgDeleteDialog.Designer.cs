namespace ManagerApplication.Dialogs
{
    partial class OrgDeleteDialog
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
            this.label1 = new Wisej.Web.Label();
            this.cancelBtn = new Wisej.Web.Button();
            this.IDText = new Wisej.Web.TextBox();
            this.panel1 = new Wisej.Web.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = Wisej.Web.AnchorStyles.Bottom;
            this.OkBtn.DialogResult = Wisej.Web.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(336, 15);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(164, 37);
            this.OkBtn.TabIndex = 0;
            this.OkBtn.Text = "OK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = Wisej.Web.AnchorStyles.Bottom;
            this.cancelBtn.DialogResult = Wisej.Web.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(553, 15);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(164, 37);
            this.cancelBtn.TabIndex = 0;
            this.cancelBtn.Text = "CANCEL";
            // 
            // IDText
            // 
            this.IDText.Location = new System.Drawing.Point(330, 148);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(100, 30);
            this.IDText.TabIndex = 23;
            this.IDText.TextChanged += new System.EventHandler(this.IDText_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.OkBtn);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Location = new System.Drawing.Point(-151, 375);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 56);
            this.panel1.TabIndex = 21;
            // 
            // OrgDeleteDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromName("@gray-100");
            this.ClientSize = new System.Drawing.Size(798, 430);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDText);
            this.Controls.Add(this.panel1);
            this.HeaderBackColor = System.Drawing.Color.FromName("@dark");
            this.Name = "OrgDeleteDialog";
            this.Text = "OrgDeleteDialog";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Button OkBtn;
        private Wisej.Web.Label label1;
        private Wisej.Web.Button cancelBtn;
        private Wisej.Web.TextBox IDText;
        private Wisej.Web.Panel panel1;
    }
}