namespace KeyAuth_Seller_Tools.Views
{
    partial class LicenseView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.UsernamesCBX = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalKeysLB = new System.Windows.Forms.Label();
            this.UnusedKeysLB = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UsedKeysLB = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BannedKeysLB = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.AllCB = new System.Windows.Forms.CheckBox();
            this.UnusedCB = new System.Windows.Forms.CheckBox();
            this.UsedCB = new System.Windows.Forms.CheckBox();
            this.BannedCB = new System.Windows.Forms.CheckBox();
            this.LicenseRemoverWorker = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.LogBoxRTB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager/Reseller name:";
            // 
            // UsernamesCBX
            // 
            this.UsernamesCBX.FormattingEnabled = true;
            this.UsernamesCBX.Location = new System.Drawing.Point(141, 7);
            this.UsernamesCBX.Name = "UsernamesCBX";
            this.UsernamesCBX.Size = new System.Drawing.Size(135, 23);
            this.UsernamesCBX.TabIndex = 1;
            this.UsernamesCBX.Text = "Select";
            this.UsernamesCBX.SelectedIndexChanged += new System.EventHandler(this.UsernamesCBX_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "License\'s Found by that user:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total:";
            // 
            // TotalKeysLB
            // 
            this.TotalKeysLB.AutoSize = true;
            this.TotalKeysLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalKeysLB.Location = new System.Drawing.Point(45, 65);
            this.TotalKeysLB.Name = "TotalKeysLB";
            this.TotalKeysLB.Size = new System.Drawing.Size(14, 15);
            this.TotalKeysLB.TabIndex = 4;
            this.TotalKeysLB.Text = "0";
            // 
            // UnusedKeysLB
            // 
            this.UnusedKeysLB.AutoSize = true;
            this.UnusedKeysLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UnusedKeysLB.Location = new System.Drawing.Point(197, 65);
            this.UnusedKeysLB.Name = "UnusedKeysLB";
            this.UnusedKeysLB.Size = new System.Drawing.Size(14, 15);
            this.UnusedKeysLB.TabIndex = 6;
            this.UnusedKeysLB.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Unused:";
            // 
            // UsedKeysLB
            // 
            this.UsedKeysLB.AutoSize = true;
            this.UsedKeysLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UsedKeysLB.Location = new System.Drawing.Point(45, 94);
            this.UsedKeysLB.Name = "UsedKeysLB";
            this.UsedKeysLB.Size = new System.Drawing.Size(14, 15);
            this.UsedKeysLB.TabIndex = 8;
            this.UsedKeysLB.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Used:";
            // 
            // BannedKeysLB
            // 
            this.BannedKeysLB.AutoSize = true;
            this.BannedKeysLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BannedKeysLB.Location = new System.Drawing.Point(197, 94);
            this.BannedKeysLB.Name = "BannedKeysLB";
            this.BannedKeysLB.Size = new System.Drawing.Size(14, 15);
            this.BannedKeysLB.TabIndex = 10;
            this.BannedKeysLB.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(141, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Banned:";
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Enabled = false;
            this.DeleteBTN.Location = new System.Drawing.Point(4, 182);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(272, 26);
            this.DeleteBTN.TabIndex = 11;
            this.DeleteBTN.Text = "Delete";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // AllCB
            // 
            this.AllCB.AutoSize = true;
            this.AllCB.Enabled = false;
            this.AllCB.Location = new System.Drawing.Point(4, 140);
            this.AllCB.Name = "AllCB";
            this.AllCB.Size = new System.Drawing.Size(40, 19);
            this.AllCB.TabIndex = 12;
            this.AllCB.Text = "All";
            this.AllCB.UseVisualStyleBackColor = true;
            this.AllCB.CheckedChanged += new System.EventHandler(this.AllCB_CheckedChanged);
            // 
            // UnusedCB
            // 
            this.UnusedCB.AutoSize = true;
            this.UnusedCB.Enabled = false;
            this.UnusedCB.Location = new System.Drawing.Point(58, 140);
            this.UnusedCB.Name = "UnusedCB";
            this.UnusedCB.Size = new System.Drawing.Size(66, 19);
            this.UnusedCB.TabIndex = 13;
            this.UnusedCB.Text = "Unused";
            this.UnusedCB.UseVisualStyleBackColor = true;
            this.UnusedCB.CheckedChanged += new System.EventHandler(this.UnusedCB_CheckedChanged);
            // 
            // UsedCB
            // 
            this.UsedCB.AutoSize = true;
            this.UsedCB.Enabled = false;
            this.UsedCB.Location = new System.Drawing.Point(144, 140);
            this.UsedCB.Name = "UsedCB";
            this.UsedCB.Size = new System.Drawing.Size(52, 19);
            this.UsedCB.TabIndex = 14;
            this.UsedCB.Text = "Used";
            this.UsedCB.UseVisualStyleBackColor = true;
            this.UsedCB.CheckedChanged += new System.EventHandler(this.UsedCB_CheckedChanged);
            // 
            // BannedCB
            // 
            this.BannedCB.AutoSize = true;
            this.BannedCB.Enabled = false;
            this.BannedCB.Location = new System.Drawing.Point(210, 140);
            this.BannedCB.Name = "BannedCB";
            this.BannedCB.Size = new System.Drawing.Size(66, 19);
            this.BannedCB.TabIndex = 15;
            this.BannedCB.Text = "Banned";
            this.BannedCB.UseVisualStyleBackColor = true;
            this.BannedCB.CheckedChanged += new System.EventHandler(this.BannedCB_CheckedChanged);
            // 
            // LicenseRemoverWorker
            // 
            this.LicenseRemoverWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.LicenseRemoverWorker_DoWork);
            this.LicenseRemoverWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.LicenseRemoverWorker_RunWorkerCompleted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(4, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Log:";
            // 
            // LogBoxRTB
            // 
            this.LogBoxRTB.ForeColor = System.Drawing.Color.Green;
            this.LogBoxRTB.Location = new System.Drawing.Point(4, 240);
            this.LogBoxRTB.Name = "LogBoxRTB";
            this.LogBoxRTB.ReadOnly = true;
            this.LogBoxRTB.Size = new System.Drawing.Size(272, 115);
            this.LogBoxRTB.TabIndex = 17;
            this.LogBoxRTB.Text = "";
            // 
            // LicenseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(188)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.LogBoxRTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BannedCB);
            this.Controls.Add(this.UsedCB);
            this.Controls.Add(this.UnusedCB);
            this.Controls.Add(this.AllCB);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.BannedKeysLB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.UsedKeysLB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.UnusedKeysLB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalKeysLB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsernamesCBX);
            this.Controls.Add(this.label1);
            this.Name = "LicenseView";
            this.Size = new System.Drawing.Size(279, 358);
            this.Load += new System.EventHandler(this.LicenseView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox UsernamesCBX;
        private Label label2;
        private Label label3;
        private Label TotalKeysLB;
        private Label UnusedKeysLB;
        private Label label6;
        private Label UsedKeysLB;
        private Label label8;
        private Label BannedKeysLB;
        private Label label10;
        private Button DeleteBTN;
        private CheckBox AllCB;
        private CheckBox UnusedCB;
        private CheckBox UsedCB;
        private CheckBox BannedCB;
        private System.ComponentModel.BackgroundWorker LicenseRemoverWorker;
        private Label label4;
        private RichTextBox LogBoxRTB;
    }
}
