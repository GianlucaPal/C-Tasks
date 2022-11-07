using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;


namespace Task1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        } 
        private void btnEcrypt_Click(object sender, EventArgs e)
        {
            String originalString = txtEncryption.Text;

            String encryptedString = EncryptDecrypt.Encrypt(originalString);

            txtDecryuption.Text = encryptedString;

            lblEncOutput.Text = encryptedString;
        }

        private void btnDecrypt_Click_1(object sender, EventArgs e)
        {
            String DecryptedString = EncryptDecrypt.Decrypt(txtDecryuption.Text);

            lblDecOutput.Text = DecryptedString;

        }
    }
}

