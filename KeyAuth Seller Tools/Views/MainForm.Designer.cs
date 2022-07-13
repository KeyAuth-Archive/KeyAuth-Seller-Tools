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
            this.TopPNL = new System.Windows.Forms.Panel();
            this.HasherBTN = new System.Windows.Forms.Button();
            this.LicenseViewBTN = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.APIKeyTB = new System.Windows.Forms.TextBox();
            this.ApiLB = new System.Windows.Forms.Label();
            this.ViewsPNL = new System.Windows.Forms.Panel();
            this.BottomPNL = new System.Windows.Forms.Panel();
            this.StatusLB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TopPNL.SuspendLayout();
            this.panel2.SuspendLayout();
            this.BottomPNL.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPNL
            // 
            this.TopPNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(188)))), ((int)(((byte)(216)))));
            this.TopPNL.Controls.Add(this.HasherBTN);
            this.TopPNL.Controls.Add(this.LicenseViewBTN);
            this.TopPNL.Controls.Add(this.panel2);
            this.TopPNL.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPNL.Location = new System.Drawing.Point(0, 0);
            this.TopPNL.Name = "TopPNL";
            this.TopPNL.Padding = new System.Windows.Forms.Padding(5);
            this.TopPNL.Size = new System.Drawing.Size(279, 66);
            this.TopPNL.TabIndex = 0;
            // 
            // HasherBTN
            // 
            this.HasherBTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.HasherBTN.Enabled = false;
            this.HasherBTN.Location = new System.Drawing.Point(112, 32);
            this.HasherBTN.Name = "HasherBTN";
            this.HasherBTN.Size = new System.Drawing.Size(107, 29);
            this.HasherBTN.TabIndex = 1;
            this.HasherBTN.Text = "Hasher";
            this.HasherBTN.UseVisualStyleBackColor = true;
            this.HasherBTN.Click += new System.EventHandler(this.HasherBTN_Click);
            // 
            // LicenseViewBTN
            // 
            this.LicenseViewBTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.LicenseViewBTN.Enabled = false;
            this.LicenseViewBTN.Location = new System.Drawing.Point(5, 32);
            this.LicenseViewBTN.Name = "LicenseViewBTN";
            this.LicenseViewBTN.Size = new System.Drawing.Size(107, 29);
            this.LicenseViewBTN.TabIndex = 0;
            this.LicenseViewBTN.Text = "License Remover";
            this.LicenseViewBTN.UseVisualStyleBackColor = true;
            this.LicenseViewBTN.Click += new System.EventHandler(this.LicenseViewBTN_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.APIKeyTB);
            this.panel2.Controls.Add(this.ApiLB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 27);
            this.panel2.TabIndex = 0;
            // 
            // APIKeyTB
            // 
            this.APIKeyTB.Dock = System.Windows.Forms.DockStyle.Right;
            this.APIKeyTB.Location = new System.Drawing.Point(61, 0);
            this.APIKeyTB.MaxLength = 32;
            this.APIKeyTB.Name = "APIKeyTB";
            this.APIKeyTB.Size = new System.Drawing.Size(208, 23);
            this.APIKeyTB.TabIndex = 1;
            this.APIKeyTB.UseSystemPasswordChar = true;
            this.APIKeyTB.TextChanged += new System.EventHandler(this.APIKeyTB_TextChanged);
            // 
            // ApiLB
            // 
            this.ApiLB.Dock = System.Windows.Forms.DockStyle.Left;
            this.ApiLB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ApiLB.Location = new System.Drawing.Point(0, 0);
            this.ApiLB.Name = "ApiLB";
            this.ApiLB.Size = new System.Drawing.Size(55, 27);
            this.ApiLB.TabIndex = 0;
            this.ApiLB.Text = "API Key:";
            this.ApiLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewsPNL
            // 
            this.ViewsPNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(188)))), ((int)(((byte)(216)))));
            this.ViewsPNL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewsPNL.Location = new System.Drawing.Point(0, 66);
            this.ViewsPNL.Name = "ViewsPNL";
            this.ViewsPNL.Size = new System.Drawing.Size(279, 358);
            this.ViewsPNL.TabIndex = 1;
            // 
            // BottomPNL
            // 
            this.BottomPNL.Controls.Add(this.StatusLB);
            this.BottomPNL.Controls.Add(this.label2);
            this.BottomPNL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPNL.Location = new System.Drawing.Point(0, 424);
            this.BottomPNL.Name = "BottomPNL";
            this.BottomPNL.Padding = new System.Windows.Forms.Padding(5);
            this.BottomPNL.Size = new System.Drawing.Size(279, 26);
            this.BottomPNL.TabIndex = 2;
            // 
            // StatusLB
            // 
            this.StatusLB.Dock = System.Windows.Forms.DockStyle.Left;
            this.StatusLB.ForeColor = System.Drawing.Color.Red;
            this.StatusLB.Location = new System.Drawing.Point(60, 5);
            this.StatusLB.Name = "StatusLB";
            this.StatusLB.Size = new System.Drawing.Size(214, 16);
            this.StatusLB.TabIndex = 2;
            this.StatusLB.Text = "Not Connected";
            this.StatusLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(188)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(279, 450);
            this.Controls.Add(this.ViewsPNL);
            this.Controls.Add(this.BottomPNL);
            this.Controls.Add(this.TopPNL);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeyAuth Seller Tools";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TopPNL.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.BottomPNL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel TopPNL;
        private Button HasherBTN;
        private Button LicenseViewBTN;
        private Panel ViewsPNL;
        private Panel panel2;
        private TextBox APIKeyTB;
        private Label ApiLB;
        private Panel BottomPNL;
        private Label StatusLB;
        private Label label2;
    }
}