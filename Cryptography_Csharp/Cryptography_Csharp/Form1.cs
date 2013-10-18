using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Cryptography_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rbCrypt.Checked = true;
            statusBar("Dobrodošli");
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (clickedButton == null) return;
            string file = "";
            TextBox data = null;
            if (clickedButton == btnTajniUcitaj)        { file = "tajni_kljuc.txt";     data = tbTajni; }
            else if (clickedButton == btnJavniUcitaj)   { file = "javni_kljuc.txt";     data = tbJavni; }
            else if (clickedButton == btnPrivatniUcitaj){ file = "privatni_kljuc.txt";  data = tbPrivatni; }
            else if (clickedButton == btnSazetakUcitaj) { file = "sazetak.txt";         data = tbSazetak; }
            else if (clickedButton == btnOriginalUcitaj){ file = "original.txt";        data = tbOriginal; }
            else if (clickedButton == btnCryptoUcitaj) { file = "crypto.txt";           data = tbCrypto; } 
            data.Text = ucitaj(file);
            if (data.Lines[0] == "")
            {
                string[] lines = data.Lines;
                data.Lines = lines.Skip(1).ToArray();
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (clickedButton == null) return;
            string file = "";
            string data = "";
            if      (clickedButton == btnTajniSpremi)   {file = "tajni_kljuc.txt";      data = tbTajni.Text;}
            else if (clickedButton == btnJavniSpremi)   {file = "javni_kljuc.txt";      data = tbJavni.Text; }
            else if (clickedButton == btnPrivatniSpremi){file = "privatni_kljuc.txt";   data = tbPrivatni.Text;}
            else if (clickedButton == btnSazetakSpremi) {file = "sazetak.txt";          data = tbSazetak.Text;}
            else if (clickedButton == btnOriginalSpremi){file = "original.txt";         data = tbOriginal.Text;}
            else if (clickedButton == btnCryptoSpremi)  {file = "crypto.txt";           data = tbCrypto.Text; }
            spremi(file, data);
        }

        private string ucitaj(string file)
        {
            string data = "";
            string line = "";
            statusBar("Učitavam: " + file, 10);
            string path = AppDomain.CurrentDomain.BaseDirectory + file;
            if (!File.Exists(path))
            {
                statusBar("Datoteka "+file+" ne postoji");
                return data;
            }
            StreamReader sr = new StreamReader(path);
            line = sr.ReadLine();
            while (line != null)
            {
                data = data + Environment.NewLine + line;
                line = sr.ReadLine();
            }
            sr.Close();
            statusBar("Učitano: " + file, 100);
            return data;
        }

        private void spremi(string file, string data)
        {
            statusBar("Spremam: " + file, 10);
            string path = AppDomain.CurrentDomain.BaseDirectory + file;
            StreamWriter sw = new StreamWriter(path);            
            sw.WriteLine(data);
            sw.Close();
            statusBar("Spremljeno: "+file, 100);
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            if (rbCrypt.Checked) crypt();
            else if (rbDecrypt.Checked) decrypt();
            else if (rbSazetakKreiraj.Checked) sha1();
            else if (rbSazetakProvjeri.Checked) check_sha1();
        }

        public void crypt()
        {            
            string plainText = tbOriginal.Text;
            byte[] Key = System.Text.ASCIIEncoding.ASCII.GetBytes(tbTajni.Text);
            byte[] IV  = System.Text.ASCIIEncoding.ASCII.GetBytes("16A7C51F5CA8F123");
            byte[] encrypted;
            if (plainText == null || plainText.Length <= 0) { statusBar("Tekst za enkripciju neispravan"); MessageBox.Show(sbLabel.Text); return; }
            if (Key == null || Key.Length <= 0) { statusBar("Ključ neispravan"); MessageBox.Show(sbLabel.Text); return; }
            statusBar("Kriptiram originalni tekst...", 10);
            try
            {
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = Key;
                    aesAlg.IV = IV;
                    ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                    using (MemoryStream msEncrypt = new MemoryStream())
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                            {
                                swEncrypt.Write(plainText);
                            }
                            encrypted = msEncrypt.ToArray();
                        }
                    }
                }
            }
            catch (Exception e) { statusBar("Enkripcija neuspjela! Provjerite ispravnost ključa i originalni tekst"); MessageBox.Show(sbLabel.Text); return; }
            tbCrypto.Text = Convert.ToBase64String(encrypted);
            spremi("crypto.txt", tbCrypto.Text);
            statusBar("Tekst kriptiran i pospremljen", 100);
        }

        public void decrypt()
        {
            byte[] cipherText = null;
            byte[] Key = System.Text.ASCIIEncoding.ASCII.GetBytes(tbTajni.Text);
            byte[] IV = System.Text.ASCIIEncoding.ASCII.GetBytes("16A7C51F5CA8F123");
            try { cipherText = Convert.FromBase64String(tbCrypto.Text); }
            catch (System.FormatException) { statusBar("Tekst za dekripciju neispravan"); MessageBox.Show(sbLabel.Text); return; }
            if (cipherText == null || cipherText.Length <= 0) { statusBar("Tekst za dekripciju neispravan"); MessageBox.Show(sbLabel.Text); return; }
            if (Key == null || Key.Length <= 0) { statusBar("Ključ neispravan"); MessageBox.Show(sbLabel.Text); return; }
            statusBar("Dekriptiram kriptirani tekst...", 10);
            string plaintext = null;
            try {
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = Key;
                    aesAlg.IV = IV;
                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                    using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                            {
                                 plaintext = srDecrypt.ReadToEnd(); 
                            }
                        }
                    }
                }
            }
            catch (Exception e) { statusBar("Dekripcije neuspjela! Provjerite ispravnost ključa i kriptiranog teksta"); MessageBox.Show(sbLabel.Text); return; }
            tbOriginal.Text = plaintext;
            statusBar("Dekriptiranje završeno", 100);
        }

        public void sha1()
        {
            statusBar("Kreiram sažetak", 10);
            tbSazetak.BackColor = Color.White;
            tbSazetak.Text = GetSHA1CSPHash(tbOriginal.Text);
            spremi("sazetak.txt", tbSazetak.Text);
            statusBar("Sažetak kreiran i pospremljen", 100);
        }

        public void check_sha1()
        {
            statusBar("Kreiram sažetak", 10);
            if (VerifySHA1CSPhash(tbOriginal.Text, tbSazetak.Text))
            {
                tbSazetak.BackColor = Color.GreenYellow;
                statusBar("Sažetak uspješno verificiran");
            }
            else
            {
                tbSazetak.BackColor = Color.Red;
                statusBar("Sažetak NIJE ISPRAVAN");
            }            
        }

        public static string GetSHA1CSPHash(string plaintext)
        {
            SHA1CryptoServiceProvider SHA1provider = new SHA1CryptoServiceProvider();
            byte[] hasedvalue = SHA1provider.ComputeHash(Encoding.Default.GetBytes(plaintext));
            StringBuilder str = new StringBuilder();
            for (int counter = 0; counter < hasedvalue.Length; counter++)
            {
                str.Append(hasedvalue[counter].ToString("X1"));
            }
            return str.ToString();
        }

        static bool VerifySHA1CSPhash(string PlainText, string prevhashedvalue)
        {
            string hashedvalue2 = GetSHA1CSPHash(PlainText);
            StringComparer strcomparer = StringComparer.OrdinalIgnoreCase;
            if (strcomparer.Compare(hashedvalue2, prevhashedvalue).Equals(0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void statusBar(string poruka = "", int stanje = -1)
        {
            sbProgress.Visible = true;
            if (stanje < 0) sbProgress.Visible = false;
            else sbProgress.Value = stanje;
            sbLabel.Text = poruka;
        }
    }
}
