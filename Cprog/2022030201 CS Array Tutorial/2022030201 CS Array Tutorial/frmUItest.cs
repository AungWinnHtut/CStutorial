using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022030201_CS_Array_Tutorial
{
    public partial class frmUItest : Form
    {
        public frmUItest()
        {
            InitializeComponent();
        }

        private void frmUItest_Load(object sender, EventArgs e)
        {
            cboCities.Items.Add("NayPyiDaw");
            cboCities.Items.Add("Pegu");
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            string sCity = txtCity .Text;
            cboCities .Items.Add(sCity);
        }

        private void cboCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cboCities.SelectedIndex.ToString());
            if(cboCities.SelectedItem .ToString () == "Yangon")
            {
                this.Text = "Yangon";
            }
        }
    }
}
