using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileIOwithEncryptDecrypt_8_Nov_2016
{
    public partial class Form2 : Form
    {
        public string passPhrase = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            passPhrase = txtPassPhrase.Text;
            Close();
        }
    }
}
