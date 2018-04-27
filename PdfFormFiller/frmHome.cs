using System;
using System.Windows.Forms;

namespace PdfFormFiller
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void toolStripOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                    wbCtrl.Navigate(dlg.FileName, false);
            }
        }
    }
}