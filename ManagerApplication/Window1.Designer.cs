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
            this.organizationBindingSource2 = new Wisej.Web.BindingSource(this.components);
            this.organizationBindingSource1 = new Wisej.Web.BindingSource(this.components);
            this.organizationBindingSource = new Wisej.Web.BindingSource(this.components);
            this.orgControlBindingSource = new Wisej.Web.BindingSource(this.components);
            this.staffBindingSource = new Wisej.Web.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgControlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // organizationBindingSource2
            // 
            this.organizationBindingSource2.DataSource = typeof(Organization);
            // 
            // organizationBindingSource1
            // 
            this.organizationBindingSource1.DataSource = typeof(Organization);
            // 
            // organizationBindingSource
            // 
            this.organizationBindingSource.DataSource = typeof(Organization);
            // 
            // orgControlBindingSource
            // 
            this.orgControlBindingSource.DataSource = typeof(OrgControl);
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataSource = typeof(Staff);
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromName("@table-row-selected");
            this.ClientSize = new System.Drawing.Size(9814, 4522);
            this.Font = new System.Drawing.Font("@default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromName("@activeBorder");
            this.HeaderBackColor = System.Drawing.Color.FromName("@dark");
            this.HeaderForeColor = System.Drawing.Color.White;
            this.Margin = new Wisej.Web.Padding(21, 19, 21, 19);
            this.Name = "Window1";
            this.Text = "Window1";
            this.Load += new System.EventHandler(this.Window1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgControlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Wisej.Web.BindingSource organizationBindingSource;
        private Wisej.Web.BindingSource organizationBindingSource1;
        private Wisej.Web.BindingSource organizationBindingSource2;
        private Wisej.Web.BindingSource orgControlBindingSource;
        private Wisej.Web.BindingSource staffBindingSource;
    }
}

