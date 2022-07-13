using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyAuth_Seller_Tools.Views
{
    public partial class HasherView : UserControl
    {
        public HasherView()
        {
            InitializeComponent();
        }

        private void HasherView_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filePaths = (string[])(e.Data.GetData(DataFormats.FileDrop));
                foreach (string fileLoc in filePaths)
                    if (File.Exists(fileLoc))
                    {
                        LogBoxRTB.Text += "[#] File Found.\n";
                        FileTB.Text = fileLoc;
                        LogBoxRTB.Text += "[#] Generating MD5 Hash.\n";
                        HashTB.Text = GetMD5Checksum(fileLoc);
                        LogBoxRTB.Text += "[#] MD5 Hash Generated.\n";
                        DeleteBTN.Enabled = true;
                    }
                    else
                    {
                        DeleteBTN.Enabled = false;
                        LogBoxRTB.Text += "[#] File Not Found.\n";
                    }
                        
            }
        }

        private void HasherView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        public static string GetMD5Checksum(string filename)
        {
            using var md5 = System.Security.Cryptography.MD5.Create();
            using var stream = File.OpenRead(filename);
            var hash = md5.ComputeHash(stream);
            return BitConverter.ToString(hash).Replace("-", "");
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            LogBoxRTB.Text += $"[#] Updating Hash!\n";
            MainForm.sellerApi.HashReset();
            MainForm.sellerApi.HashAdd(HashTB.Text);
            LogBoxRTB.Text += $"[#] {MainForm.sellerApi.response.Message}\n";
        }
    }
}
