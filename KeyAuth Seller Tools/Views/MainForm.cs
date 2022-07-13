using KeyAuth_Seller_Tools.Views;
using KeyAuthSeller;

namespace KeyAuth_Seller_Tools
{
    public partial class MainForm : Form
    {
        public static SellerApi sellerApi = new();
        public MainForm()
        {
            InitializeComponent();
        }

        private void LicenseViewBTN_Click(object sender, EventArgs e)
        {
            ViewsPNL.Controls.Clear();
            LicenseView licenseView = new();
            ViewsPNL.Controls.Add(licenseView);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            APIKeyTB.Text = Properties.Settings.Default.APIKey;
        }

        private void HasherBTN_Click(object sender, EventArgs e)
        {
            ViewsPNL.Controls.Clear();
            HasherView hasherView = new();
            ViewsPNL.Controls.Add(hasherView);
        }

        private void APIKeyTB_TextChanged(object sender, EventArgs e)
        {
            if (APIKeyTB.Text.Length == 32)
            {
                StatusLB.Text = "Connecting.";
                StatusLB.ForeColor = Color.Blue;
                sellerApi.SetSellerKey(APIKeyTB.Text);
                if (sellerApi.response.Success)
                {
                    StatusLB.Text = "Connected.";
                    StatusLB.ForeColor = Color.Green;
                    ViewsPNL.Controls.Clear();
                    LicenseView licenseView = new();
                    ViewsPNL.Controls.Add(licenseView);
                    LicenseViewBTN.Enabled = true;
                    HasherBTN.Enabled = true;
                }
                else
                {
                    StatusLB.Text = "Not Connected.";
                    StatusLB.ForeColor = Color.Red;
                    ViewsPNL.Controls.Clear();
                    LicenseViewBTN.Enabled = false;
                    HasherBTN.Enabled = false;
                }
            }
            else
            {
                StatusLB.Text = "Not Connected.";
                StatusLB.ForeColor = Color.Red;
                ViewsPNL.Controls.Clear();
                LicenseViewBTN.Enabled = false;
                HasherBTN.Enabled = false;
            }
        }
    }
}