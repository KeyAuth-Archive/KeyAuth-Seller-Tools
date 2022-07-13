using KeyAuth_Seller_Tools.Views;

namespace KeyAuth_Seller_Tools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LicenseViewBTN_Click(object sender, EventArgs e)
        {
            ViewsPNL.Controls.Clear();
            LicenseView licenseView = new LicenseView();
            ViewsPNL.Controls.Add(licenseView);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ViewsPNL.Controls.Clear();
            LicenseView licenseView = new LicenseView();
            ViewsPNL.Controls.Add(licenseView);
        }

        private void HasherBTN_Click(object sender, EventArgs e)
        {
            ViewsPNL.Controls.Clear();
            HasherView hasherView = new HasherView();
            ViewsPNL.Controls.Add(hasherView);
        }
    }
}