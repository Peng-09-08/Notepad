using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace Notepad.SubForm
{
    public partial class EncryptForm : Form
    {
        private static string _Source;

        public delegate void EncryptDelegate(string key);
        private static EncryptDelegate _EncryptHandler;

        public static void RegisterEncryptDelegate(EncryptDelegate func)
        {
            _EncryptHandler = func;
        }

        public static string SetSource
        {
            set { _Source = value; }
        }

        public EncryptForm()
        {
            InitializeComponent();
            CancelButton = btn_Cancel;
        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {
            if (txt_Key.Text == "")
                return;

            //txt_Key.Focus();
            string target = radioBtn_Encrypt.Checked ? Encrypt(_Source) : Decrypt(_Source);
            _Source = target;
            _EncryptHandler(target);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            UseEditForm.CloseForm();
        }

        private string Encrypt(string source)
        {
            string encrypt = "";

            try
            {
                AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                SHA256CryptoServiceProvider sha256 = new SHA256CryptoServiceProvider();

                byte[] key = sha256.ComputeHash(Encoding.UTF8.GetBytes(txt_Key.Text));
                byte[] iv = md5.ComputeHash(Encoding.UTF8.GetBytes(txt_Key.Text));
                aes.Key = key;
                aes.IV = iv;

                byte[] dataByteArray = Encoding.UTF8.GetBytes(source);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(dataByteArray, 0, dataByteArray.Length);
                        cs.FlushFinalBlock();
                        encrypt = Convert.ToBase64String(ms.ToArray());
                    }
                }
            }
            catch
            {
                return source;
            }

            return encrypt;
        }


        private string Decrypt(string source)
        {
            string decrypt = "";

            try
            {
                AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                SHA256CryptoServiceProvider sha256 = new SHA256CryptoServiceProvider();
                byte[] key = sha256.ComputeHash(Encoding.UTF8.GetBytes(txt_Key.Text));
                byte[] iv = md5.ComputeHash(Encoding.UTF8.GetBytes(txt_Key.Text));
                aes.Key = key;
                aes.IV = iv;

                byte[] dataByteArray = Convert.FromBase64String(source);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(dataByteArray, 0, dataByteArray.Length);
                        cs.FlushFinalBlock();
                        decrypt = Encoding.UTF8.GetString(ms.ToArray());
                    }
                }
            }
            catch
            {
                return source;
            }

            return decrypt;
        }
    }
}
