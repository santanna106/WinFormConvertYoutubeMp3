using MediaToolkit;
using MediaToolkit.Model;
using System;
using System.IO;
using System.Windows.Forms;
using VideoLibrary;
using WinFormConvertYoutubeMp3.service;

namespace WinFormConvertYoutubeMp3
{
    public partial class FrmTelaConversacao : Form
    {

        public FrmTelaConversacao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceYoutubeToMp3 service = new ServiceYoutubeToMp3();
            service.Convert(txbUrl.Text.ToString(), txbPastaDestino.Text.ToString());

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                txbPastaDestino.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }
    }
}
