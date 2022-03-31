using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;


namespace NewTools
{
    public partial class frmBrowser : Form
    {
        public frmBrowser()
        {
            InitializeComponent();
            
        }
     


        



        private void btnSearch_Click(object sender, EventArgs e)
        {
            funBrowse();
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                funBrowse();
            }
        }
        private void funBrowse()
        {
            string sAddress = txtAddress.Text;
            string sHeader = sAddress.Substring(0, 4);
            Uri uri = new Uri(sAddress, UriKind.RelativeOrAbsolute);
            if (!uri.IsAbsoluteUri)
            {
                if (sHeader == "www.")
                {
                    sAddress = "https://" + sAddress;
                }
                else
                {
                    sAddress = "https://www." + sAddress;
                }
                Uri uri2 = new Uri(sAddress, UriKind.RelativeOrAbsolute);
                brsHomepage.Navigate(uri2);

            }
            else
            {
                brsHomepage.Navigate(uri);
            }
        }

        private void brsHomepage_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            MessageBox.Show("Open Complete");
        }
    }
}
