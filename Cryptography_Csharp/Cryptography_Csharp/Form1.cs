﻿using System;
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
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Cryptography_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
            statusBar("Dobrodošli");
            cbOperacija.SelectedIndex = 0;
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            switch (cbOperacija.SelectedIndex)
            {
                case 0: cryptAES(); break;
                case 1: decryptAES(); break;
                case 2: cryptRSA(); break;
                case 3: decryptRSA(); break;
                case 4: sha1(); break;
                case 5: check_sha1(); break;
                case 6: HashAndSignBytes();  break;
                case 7: VerifySignedHash(); break;
            }
        }

        private void generatePassword_DoubleClick(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            statusBar("Generiram ključeve",10);
            if (tb == tbTajni)
            {
                using (AesCryptoServiceProvider AES = new AesCryptoServiceProvider())
                {
                    AES.KeySize = 128;
                    SoapHexBinary shb = new SoapHexBinary(AES.Key);
                    tbTajni.Text = shb.ToString();
                    spremi("tajni_kljuc.txt", tbTajni.Text);
                }
            }
            else if (tb == tbJavni || tb==tbPrivatni)
            {
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(2048))
                {                    
                    tbJavni.Text = RSA.ToXmlString(false);
                    tbPrivatni.Text = RSA.ToXmlString(true);
                    spremi("javni_kljuc.txt", tbJavni.Text);
                    spremi("privatni_kljuc.txt", tbPrivatni.Text);
                }
            }
            statusBar("Ključevi generirani i pohranjeni", 100);
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
            else if (clickedButton == btnCryptoUcitaj)  { file = "crypto.txt";          data = tbCrypto; } 
            data.Text = ucitaj(file);
            if (data.Text!="" && data.Lines[0] == "")
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

        private void clear_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn == btnOriginalClear) tbOriginal.Text = string.Empty;
            else if (btn == btnCryptoClear) tbCrypto.Text = string.Empty;
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

        public void cryptAES()
        {            
            string DataToEncrypt = tbOriginal.Text;
            string EncryptKey    = tbTajni.Text;
            if (DataToEncrypt == null || DataToEncrypt.Length <= 0) { statusBar("Tekst za enkripciju neispravan"); MessageBox.Show(sbLabel.Text); return; }
            if (EncryptKey == null || EncryptKey.Length <= 0)       { statusBar("Ključ za enkripciju neispravan"); MessageBox.Show(sbLabel.Text); return; }
            statusBar("Kriptiram originalni tekst...", 10);
            try
            {
                byte[] encryptedData;
                SoapHexBinary shb = SoapHexBinary.Parse(EncryptKey);
                byte[] Key = shb.Value;
                byte[] IV = System.Text.ASCIIEncoding.ASCII.GetBytes("16A7C51F5CA8F123");
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
                                swEncrypt.Write(DataToEncrypt);
                            }
                            encryptedData = msEncrypt.ToArray();
                        }
                    }
                }
                tbCrypto.Text = Convert.ToBase64String(encryptedData);
            }
            catch (Exception e) { statusBar("Enkripcija neuspjela! Provjerite ispravnost ključa i originalni tekst"); MessageBox.Show(sbLabel.Text); return; }            
            spremi("crypto.txt", tbCrypto.Text);
            statusBar("Tekst kriptiran i pospremljen", 100);
        }

        public void decryptAES()
        {
            string DataToDecrypt = tbCrypto.Text;
            string DecryptKey    = tbTajni.Text;
            if (DataToDecrypt == null || DataToDecrypt.Length <= 0) { statusBar("Tekst za dekripciju neispravan"); MessageBox.Show(sbLabel.Text); return; }
            if (DecryptKey == null || DecryptKey.Length <= 0) { statusBar("Ključ za dekripciju neispravan"); MessageBox.Show(sbLabel.Text); return; }
            statusBar("Dekriptiram kriptirani tekst...", 10);      
            try {
                string decryptedData;
                byte[] ByteDataToDecrypt = Convert.FromBase64String(DataToDecrypt);
                SoapHexBinary shb = SoapHexBinary.Parse(DecryptKey);
                byte[] Key = shb.Value;
                byte[] IV = System.Text.ASCIIEncoding.ASCII.GetBytes("16A7C51F5CA8F123");             
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = Key;
                    aesAlg.IV = IV;
                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                    using (MemoryStream msDecrypt = new MemoryStream(ByteDataToDecrypt))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                            {
                                decryptedData = srDecrypt.ReadToEnd(); 
                            }
                        }
                    }
                }
                tbOriginal.Text = decryptedData;
            }
            catch (Exception e) { statusBar("Dekripcije neuspjela! Provjerite ispravnost ključa i kriptiranog teksta"); MessageBox.Show(sbLabel.Text); return; }            
            statusBar("Dekriptiranje završeno", 100);
        }

        public void cryptRSA()
        {
            string DataToEncrypt = tbOriginal.Text;
            string EncryptKey    = tbJavni.Text;
            if (DataToEncrypt == null || DataToEncrypt.Length <= 0) { statusBar("Tekst za enkripciju neispravan"); MessageBox.Show(sbLabel.Text); return; }
            if (EncryptKey == null || EncryptKey.Length <= 0) { statusBar("Ključ za enkripciju neispravan"); MessageBox.Show(sbLabel.Text); return; }
            statusBar("Kriptiram originalni tekst...", 10);
            try
            {
                byte[] encryptedData;
                UnicodeEncoding ByteConverter = new UnicodeEncoding();
                byte[] ByteDataToEncrypt = ByteConverter.GetBytes(DataToEncrypt);
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(2048))
                {
                    RSA.FromXmlString(EncryptKey);
                    encryptedData = RSA.Encrypt(ByteDataToEncrypt, false);
                }
                tbCrypto.Text = Convert.ToBase64String(encryptedData);
            }
            catch (Exception e) { statusBar("Enkripcija neuspjela! Provjerite ispravnost ključa i originalni tekst"); MessageBox.Show(sbLabel.Text); return; }             
            spremi("crypto.txt", tbCrypto.Text);
            statusBar("Tekst kriptiran i pospremljen", 100);
        }

        public void decryptRSA()
        {
            string DataToDecrypt = tbCrypto.Text;
            string DecryptKey = tbPrivatni.Text;
            if (DataToDecrypt == null || DataToDecrypt.Length <= 0) { statusBar("Tekst za dekripciju neispravan"); MessageBox.Show(sbLabel.Text); return; }
            if (DecryptKey == null || DecryptKey.Length <= 0) { statusBar("Ključ za dekripciju neispravan"); MessageBox.Show(sbLabel.Text); return; }
            statusBar("Dekriptiram kriptirani tekst...", 10);
            try
            {
                byte[] decryptedData;
                byte[] ByteDataToDecrypt = Convert.FromBase64String(DataToDecrypt);
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(2048))
                {
                    RSA.FromXmlString(DecryptKey);
                    decryptedData = RSA.Decrypt(ByteDataToDecrypt, false);
                }
                UnicodeEncoding ByteConverter = new UnicodeEncoding();
                tbOriginal.Text = ByteConverter.GetString(decryptedData);
            }
            catch (Exception e) { statusBar("Dekripcije neuspjela! Provjerite ispravnost ključa i kriptiranog teksta"); MessageBox.Show(sbLabel.Text); return; }
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

        public void HashAndSignBytes()
        {
            string EncryptKey = tbPrivatni.Text;
            if (EncryptKey == null || EncryptKey.Length <= 0) { statusBar("Ključ za enkripciju neispravan"); MessageBox.Show(sbLabel.Text); return; }            
            try
            {
                UnicodeEncoding ByteConverter = new UnicodeEncoding();
                byte[] DataToSign = ByteConverter.GetBytes(tbOriginal.Text);
                RSACryptoServiceProvider RSAalg = new RSACryptoServiceProvider();
                RSAalg.FromXmlString(EncryptKey);
                tbSazetak.Text = Convert.ToBase64String(RSAalg.SignData(DataToSign, new SHA1CryptoServiceProvider()));
            }
            catch (Exception e) { statusBar("Potpisivanje neuspješno! Provjerite ispravnost ključa i teksta"); MessageBox.Show(sbLabel.Text); return; }
            tbSazetak.BackColor = Color.White;
        }

        public void VerifySignedHash()
        {
            string DecryptKey = tbJavni.Text;
            if (DecryptKey == null || DecryptKey.Length <= 0) { statusBar("Ključ za dekripciju neispravan"); MessageBox.Show(sbLabel.Text); return; }
            try
            {
                UnicodeEncoding ByteConverter = new UnicodeEncoding();
                byte[] DataToVerify = ByteConverter.GetBytes(tbOriginal.Text);
                byte[] SignedData = Convert.FromBase64String(tbSazetak.Text);
                RSACryptoServiceProvider RSAalg = new RSACryptoServiceProvider();
                RSAalg.FromXmlString(DecryptKey);
                bool status = RSAalg.VerifyData(DataToVerify, new SHA1CryptoServiceProvider(), SignedData);
                if (status)
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
            catch (Exception e) { tbSazetak.BackColor = Color.Red; statusBar("Potpisivanje neuspješno! Provjerite ispravnost ključa i teksta"); MessageBox.Show(sbLabel.Text); return; }

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
