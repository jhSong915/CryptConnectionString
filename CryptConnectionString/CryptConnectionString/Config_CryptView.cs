using System;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;

namespace CryptConnectionString
{
    public partial class Config_CryptView : Form
    {
        public Config_CryptView()
        {
            InitializeComponent();
        }

        private void Encrypt_Config(string PlainConfig_FileName)
        {
            try
            {
                Configuration config = null;
                config = ConfigurationManager.OpenExeConfiguration(PlainConfig_FileName);
                ConfigurationSection config_section = config.GetSection("connectionStrings") as ConnectionStringsSection;
                if ((!(config_section.ElementInformation.IsLocked)) && (!(config_section.SectionInformation.IsLocked)))
                {
                    if (!config_section.SectionInformation.IsProtected)
                    {
                        config_section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                    }
                    config_section.SectionInformation.ForceSave = true;
                    config.Save();
                    TxtConfigFileName.Text = "";
                    Process.Start("notepad.exe", config.FilePath);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            using (ofd_Config)
            {
                ofd_Config.Title = "Choose .Config File";
                ofd_Config.FileName = "";
                ofd_Config.Filter = "Config File|*.config";

                if (ofd_Config.ShowDialog() == DialogResult.OK)
                {
                    TxtConfigFileName.Text = ofd_Config.FileName;
                }
            }
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtConfigFileName.Text))
            {
                Encrypt_Config(TxtConfigFileName.Text);
            }
            else
            {
                MessageBox.Show("Choose Config File !", "No Such File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BtnOpenFile.Focus();
            }
        }

        private void TxtConfigFileName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtConfigFileName.Text))
                BtnEncrypt.Enabled = true;
            else
                BtnEncrypt.Enabled = false;
        }

        private void BtnShowExample_Click(object sender, EventArgs e)
        {
            using (ExampleView frm = new ExampleView())
            {
                frm.ShowDialog();
            }
        }
    }
}