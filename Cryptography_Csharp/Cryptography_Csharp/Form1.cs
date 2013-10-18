using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rbCrypt.Checked = true;
            gbCrypro.Text = "Kiptirani zapis originalnog teksta";
        }

        private void rbCrypt_CheckedChanged(object sender, EventArgs e)
        {         
            gbCrypro.Text = "Kiptirani zapis originalnog teksta";
        }

        private void rbDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            gbCrypro.Text = "Dekriptirani zapis originalnog teksta";         
        }
    }
}
