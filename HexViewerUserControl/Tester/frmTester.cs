using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tester
{
    public partial class frmTester : Form
    {
        public frmTester()
        {
            InitializeComponent();
        }

        private void SetNormalStyle()
        {
            srcHexViewer1.LineNumberForeColor = Color.White;
            srcHexViewer1.LineNumberBackColor = Color.FromArgb(20, 20, 20);
            srcHexViewer1.HexViewBackColor = Color.FromArgb(64, 64, 64);
            srcHexViewer1.TextViewBackColor = Color.FromArgb(64, 64, 64);
            srcHexViewer1.AlternateBackColor1 = Color.FromArgb(90, 90, 90);
            srcHexViewer1.AlternateBackColor2 = Color.FromArgb(64, 64, 64);
            srcHexViewer1.AlternateTextColor1 = Color.White;
            srcHexViewer1.AlternateTextColor2 = Color.White;
        }

        private void SetMatrixStyle()
        {
            srcHexViewer1.LineNumberForeColor = Color.White;
            srcHexViewer1.LineNumberBackColor = Color.Black;
            srcHexViewer1.HexViewBackColor = Color.Black;
            srcHexViewer1.TextViewBackColor = Color.Black;
            srcHexViewer1.AlternateBackColor1 = Color.Green;
            srcHexViewer1.AlternateBackColor2 = Color.Black;
            srcHexViewer1.AlternateTextColor1 = Color.Black;
            srcHexViewer1.AlternateTextColor2 = Color.Green;
        }

        private void SetXaviStyle()
        {
            srcHexViewer1.LineNumberForeColor = Color.Gold;
            srcHexViewer1.LineNumberBackColor = Color.Black;
            srcHexViewer1.HexViewBackColor = Color.Black;
            srcHexViewer1.TextViewBackColor = Color.Black;
            srcHexViewer1.AlternateBackColor1 = Color.Gold;
            srcHexViewer1.AlternateBackColor2 = Color.Black;
            srcHexViewer1.AlternateTextColor1 = Color.Black;
            srcHexViewer1.AlternateTextColor2 = Color.Gold;
        }

        private void frmTester_Load(object sender, EventArgs e)
        {
            byte[] data = new byte[] {
                45, 46, 47, 48,
            };
            //srcHexViewer1.LoadData(data);
        }

        private void frmTester_Shown(object sender, EventArgs e)
        {
            srcHexViewer1.HexDataSeparator = ' ';
            srcHexViewer1.IsAlternateLineColor = true;
            srcHexViewer1.ShowLineNumber = true;
            srcHexViewer1.BytesPerLine = 16;
            srcHexViewer1.LoadingDelay = 0;
            srcHexViewer1.AutoSelectCharacter = true;
            srcHexViewer1.SynchronizeScrolling = true;
            srcHexViewer1.ShowHorizontalScrollbars = false;
            SetNormalStyle();
            OpenFileDialog openDialog = new OpenFileDialog();
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                srcHexViewer1.LoadString(File.ReadAllText(openDialog.FileName));
            }
            //srcHexViewer1.LoadString("Zaldy S. Luvidices\a");
        }

        private void srcHexViewer1_ProgressChanged(object sender, HexViewer.ProgressChangedEventArgs e)
        {
            this.Text = "Tester " + e.Percentage.ToString();
        }

        private void srcHexViewer1_KeyDown(object sender, KeyEventArgs e)
        {
            this.srcHexViewer1.CancelLoading();
        }

        private void frmTester_KeyDown(object sender, KeyEventArgs e)
        { // still remember the taste of my life
            if (this.srcHexViewer1.IsLoading()) this.srcHexViewer1.CancelLoading();

            //if (e.KeyCode == Keys.Up) this.srcHexViewer1.SearchPrevious(true);
            //else if (e.KeyCode == Keys.Down) this.srcHexViewer1.SearchNext(true);
            //if (e.KeyCode == Keys.Enter)
            //    this.srcHexViewer1.EditByteAtIndex(this.srcHexViewer1.GetSelectedByteIndex(), (byte)'Z');
            //e.Handled = true;
            //this.Text = srcHexViewer1.GetSearchIndex().ToString();
        }

        private void srcHexViewer1_LoadCompleted(object sender, HexViewer.LoadCompletedEventArgs e)
        {
            this.Text = srcHexViewer1.GetLoadedBytesCount().ToString() + " bytes of " +
                srcHexViewer1.GetAllDataCount().ToString() + " loaded.";
            this.Text = srcHexViewer1.IsCancelled().ToString();
            this.Text = srcHexViewer1.GetDataLineCount().ToString();
            //MessageBox.Show(srcHexViewer1.SearchFirst("EF").ToString());
        }

        private void srcHexViewer1_SelectedByteIndexChanged(object sender, HexViewer.SelectedByteChangedEventArgs e)
        {
            this.Text = e.Index + " [" + ((char)e.SelectedByte) + "]";
        }
    }
}
