namespace ManagerApplication.Dialogs
{
    partial class StaffDeleteDialog
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
            this.StaffIDText = new Wisej.Web.TextBox();
            this.label7 = new Wisej.Web.Label();
            this.OkBtn = new Wisej.Web.Button();
            this.cancelBtn = new Wisej.Web.Button();
            this.panel1 = new Wisej.Web.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StaffIDText
            // 
            this.StaffIDText.Location = new System.Drawing.Point(364, 149);
            this.StaffIDText.Name = "StaffIDText";
            this.StaffIDText.Size = new System.Drawing.Size(100, 30);
            this.StaffIDText.TabIndex = 23;
            this.StaffIDText.TextChanged += new System.EventHandler(this.StaffIDText_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Staff ID:";
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = Wisej.Web.AnchorStyles.Bottom;
            this.OkBtn.DialogResult = Wisej.Web.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(352, 15);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(164, 37);
            this.OkBtn.TabIndex = 0;
            this.OkBtn.Text = "OK";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = Wisej.Web.AnchorStyles.Bottom;
            this.cancelBtn.DialogResult = Wisej.Web.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(597, 15);
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
            this.panel1.Location = new System.Drawing.Point(-151, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 67);
            this.panel1.TabIndex = 24;
            // 
            // StaffDeleteDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromName("@gray-100");
            this.ClientSize = new System.Drawing.Size(798, 430);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StaffIDText);
            this.Controls.Add(this.label7);
            this.HeaderBackColor = System.Drawing.Color.FromName("@dark");
            this.Name = "StaffDeleteDialog";
            this.Text = "Deleting Staff";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.TextBox StaffIDText;
        private Wisej.Web.Label label7;
        private Wisej.Web.Button OkBtn;
        private Wisej.Web.Button cancelBtn;
        private Wisej.Web.Panel panel1;
    }
}