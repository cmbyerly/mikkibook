namespace MikkiBookWF
{
    partial class AboutMikkiBook : Form
    {
        public AboutMikkiBook()
        {
            InitializeComponent();
            this.Text = "Mikki Book 0.4";
            this.labelProductName.Text = "Mikki Book";
            this.labelVersion.Text = "0.4";
            this.labelCopyright.Text = "2023 Chris Byerly";
            this.labelCompanyName.Text = "Chris Byerly";
            this.textBoxDescription.Text = "https://github.com/cmbyerly/mikkibook";
        }

        private void labelProductName_Click(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxDescription_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}
