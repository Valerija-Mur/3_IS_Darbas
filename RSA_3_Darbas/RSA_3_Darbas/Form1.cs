using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace RSA_3_Darbas
{
    public partial class Form1 : Form
    {

        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        string pub;
        string _privateKeyXML;
        string _publicKeyXml;
        Dictionary<string, string> keyDictionary = new Dictionary<string, string>();


        public Form1()
        {
            InitializeComponent();
            textBox1.MaxLength = 58;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            keyDictionary.Clear();
            try
            {
                using (var rsaServer = new RSACryptoServiceProvider(2048))
                {
                    _privateKeyXML = rsaServer.ToXmlString(true);
                    _publicKeyXml = rsaServer.ToXmlString(false);
                }

                string tempString = textBox1.Text;
                var inputBytes = Encoding.UTF8.GetBytes(tempString);
                byte[] encryptedBytes = null;
                using (var rsaClient = new RSACryptoServiceProvider(2048))
                {
                    rsaClient.FromXmlString(_publicKeyXml);
                    encryptedBytes = rsaClient.Encrypt(inputBytes, false);
                    textBox2.Text= Convert.ToBase64String(encryptedBytes);
                    keyDictionary.Add(_privateKeyXML, textBox2.Text);
                    using (StreamWriter w = File.AppendText("keys.txt"))
                    {
                        foreach (var entry in keyDictionary)
                            w.WriteLine("{0} {1}", entry.Key, entry.Value);
                    }
                }
                using (StreamWriter writer = File.AppendText("publicKey.txt"))
                {
                    writer.Write(_publicKeyXml);
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Encryption failed.");
            }

        }

       
        void ReadFromFile()
        {
            string line;
            StreamReader file = new StreamReader("keys.txt");
            while ((line = file.ReadLine()) != null)
            {
                string temp = line.Substring(0, line.IndexOf(" "));
                string temp2 = line.Substring(line.IndexOf(" ") + 1);
                keyDictionary.Add(temp,temp2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                keyDictionary.Clear();
                ReadFromFile();
                var priva = keyDictionary.FirstOrDefault(x => x.Value == textBox2.Text).Key;
                byte[] inputBytes;
                var encryptedBytes = Convert.FromBase64String(textBox2.Text);
                using (var rsaClient = new RSACryptoServiceProvider(2048))
                {
                    rsaClient.FromXmlString(priva);
                    inputBytes = rsaClient.Decrypt(encryptedBytes, false);
                }
                string output = Encoding.UTF8.GetString(inputBytes);
                textBox1.Text = output;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine("Encryption failed.");
            }
        }

    }
}
