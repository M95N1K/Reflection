using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_Less8_3
{
    public partial class FAbout : Form
    {
        public FAbout()
        {
            InitializeComponent();
        }

        private void FAbout_Load(object sender, EventArgs e)
        {
            lVersion.Text = string.Format("Версия: {0}", Application.ProductVersion);
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
