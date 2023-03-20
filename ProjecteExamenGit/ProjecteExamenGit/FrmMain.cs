using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjecteExamenGit
{
    public partial class FrmMain : Form
    {
        FrmGroc groc = null;
        FrmVerd verd = null;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnGroc_Click(object sender, EventArgs e)
        {
            groc = new FrmGroc();
            groc.ShowDialog();
        }

        private void btnVerd_Click(object sender, EventArgs e)
        {
            verd = new FrmVerd();
            verd.ShowDialog();
        }
    }
}
