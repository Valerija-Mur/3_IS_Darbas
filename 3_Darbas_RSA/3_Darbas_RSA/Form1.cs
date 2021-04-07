using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace _3_Darbas_RSA
{
    public partial class Form1 : Form
    {
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        byte[] plaintext;
        byte[] encryptedtext;


        public Form1()
        {
            InitializeComponent();
        }

        private void Si_btn_Click(object sender, EventArgs e)
        {
            plaintext = ByteConverter.GetBytes(Tekstas_txt.Text);
            encryptedtext = Encryption(plaintext, RSA.ExportParameters(false), false);
            Sifruotas_txt.Text = ByteConverter.GetString(encryptedtext);
        }

        private void de_btn_Click(object sender, EventArgs e)
        {
            byte[] decryptedtex = Decryption(encryptedtext,RSA.ExportParameters(true), false);
            Tekstas_txt.Text = ByteConverter.GetString(decryptedtex);
        }

        static public byte[] Encryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    encryptedData = RSA.Encrypt(Data, DoOAEPPadding);
                }
                return encryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }



        static public byte[] Decryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    decryptedData = RSA.Decrypt(Data, DoOAEPPadding);
                }
                return decryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
    }
}
