using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PersonalClassLibrary.Windows
{
    public class FileOptions
    {
        public static bool EncryptFile(string inputFilePath, string outputFilePath, string key)
        {
            using (FileStream fsInput = new FileStream(inputFilePath, FileMode.Open))
            {
                using (FileStream fsOutput = new FileStream(outputFilePath, FileMode.Create))
                {
                    using (AesManaged aes = new AesManaged())
                    {
                        aes.Key = Encoding.UTF8.GetBytes(key);
                        aes.IV = new byte[16];

                        // Perform encryption
                        ICryptoTransform encryptor = aes.CreateEncryptor();
                        using (CryptoStream cs = new CryptoStream(fsOutput, encryptor, CryptoStreamMode.Write))
                        {
                            fsInput.CopyTo(cs);
                            return true;
                        }
                    }
                }
            }
        }

        public static bool DecryptFile(string inputFilePath, string outputFilePath, string key)
        {
            using (FileStream fsInput = new FileStream(inputFilePath, FileMode.Open))
            {
                using (FileStream fsOutput = new FileStream(outputFilePath, FileMode.Create))
                {
                    using (AesManaged aes = new AesManaged())
                    {
                        aes.Key = Encoding.UTF8.GetBytes(key);
                        aes.IV = new byte[16];

                        // Perform encryption
                        ICryptoTransform encryptor = aes.CreateDecryptor();
                        using (CryptoStream cs = new CryptoStream(fsOutput, encryptor, CryptoStreamMode.Write))
                        {
                            fsInput.CopyTo(cs);
                            return true;
                        }
                    }
                }
            }
        }
    }
}
