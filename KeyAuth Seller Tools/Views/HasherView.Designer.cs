namespace KeyAuth_Seller_Tools.Views
{
    partial class HasherView
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
            this.label2 = new System.Windows.Forms.Label();
            this.FileTB = new System.Windows.Forms.TextBox();
            this.HashTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LogBoxRTB = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Drag/Drop a file to update hash:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FileTB
            // 
            this.FileTB.Dock = System.Windows.Forms.DockStyle.Top;
            this.FileTB.Location = new System.Drawing.Point(5, 43);
            this.FileTB.Name = "FileTB";
            this.FileTB.Size = new System.Drawing.Size(269, 23);
            this.FileTB.TabIndex = 4;
            // 
            // HashTB
            // 
            this.HashTB.Dock = System.Windows.Forms.DockStyle.Top;
            this.HashTB.Location = new System.Drawing.Point(5, 104);
            this.HashTB.Name = "HashTB";
            this.HashTB.Size = new System.Drawing.Size(269, 23);
            this.HashTB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Generated MD5 Hash:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogBoxRTB
            // 
            this.LogBoxRTB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogBoxRTB.ForeColor = System.Drawing.Color.Green;
            this.LogBoxRTB.Location = new System.Drawing.Point(5, 198);
            this.LogBoxRTB.Name = "LogBoxRTB";
            this.LogBoxRTB.ReadOnly = true;
            this.LogBoxRTB.Size = new System.Drawing.Size(269, 115);
            this.LogBoxRTB.TabIndex = 19;
            this.LogBoxRTB.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(5, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Log:";
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DeleteBTN.Enabled = false;
            this.DeleteBTN.Location = new System.Drawing.Point(5, 157);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(269, 26);
            this.DeleteBTN.TabIndex = 20;
            this.DeleteBTN.Text = "Update";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // HasherView
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(188)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HashTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogBoxRTB);
            this.Controls.Add(this.FileTB);
            this.Controls.Add(this.label2);
            this.Name = "HasherView";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(279, 318);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.HasherView_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.HasherView_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private TextBox FileTB;
        private TextBox HashTB;
        private Label label1;
        private RichTextBox LogBoxRTB;
        private Label label4;
        private Button DeleteBTN;
    }
}
