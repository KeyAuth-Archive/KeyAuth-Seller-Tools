namespace KeyAuth_Seller_Tools
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.HasherBTN = new System.Windows.Forms.Button();
            this.LicenseViewBTN = new System.Windows.Forms.Button();
            this.ViewsPNL = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HasherBTN);
            this.panel1.Controls.Add(this.LicenseViewBTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 28);
            this.panel1.TabIndex = 0;
            // 
            // HasherBTN
            // 
            this.HasherBTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.HasherBTN.Location = new System.Drawing.Point(107, 0);
            this.HasherBTN.Name = "HasherBTN";
            this.HasherBTN.Size = new System.Drawing.Size(107, 28);
            this.HasherBTN.TabIndex = 1;
            this.HasherBTN.Text = "Hasher";
            this.HasherBTN.UseVisualStyleBackColor = true;
            this.HasherBTN.Click += new System.EventHandler(this.HasherBTN_Click);
            // 
            // LicenseViewBTN
            // 
            this.LicenseViewBTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.LicenseViewBTN.Location = new System.Drawing.Point(0, 0);
            this.LicenseViewBTN.Name = "LicenseViewBTN";
            this.LicenseViewBTN.Size = new System.Drawing.Size(107, 28);
            this.LicenseViewBTN.TabIndex = 0;
            this.LicenseViewBTN.Text = "License Remover";
            this.LicenseViewBTN.UseVisualStyleBackColor = true;
            this.LicenseViewBTN.Click += new System.EventHandler(this.LicenseViewBTN_Click);
            // 
            // ViewsPNL
            // 
            this.ViewsPNL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewsPNL.Location = new System.Drawing.Point(0, 28);
            this.ViewsPNL.Name = "ViewsPNL";
            this.ViewsPNL.Size = new System.Drawing.Size(316, 422);
            this.ViewsPNL.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 450);
            this.Controls.Add(this.ViewsPNL);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeyAuth Seller Tools";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button HasherBTN;
        private Button LicenseViewBTN;
        private Panel ViewsPNL;
    }
}