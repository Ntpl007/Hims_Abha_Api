using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ABHA_API
{
    public class RSAHelper
    {
        private readonly RSACryptoServiceProvider _publicKey;

        public RSAHelper()
        {
            string public_pem = @"D:\Abha\2\ABHA_API\ABHA_API\Encrypt\posvendor.pub.pem";
            _publicKey = GetPublicKeyFromPemFile(public_pem);
        }

        public string Encrypt(string text)
        {
            
            var encryptedBytes = _publicKey.Encrypt(Encoding.UTF8.GetBytes(text), false);
            return Convert.ToBase64String(encryptedBytes);
        }

        private RSACryptoServiceProvider GetPublicKeyFromPemFile(String filePath)
        {
            using (TextReader publicKeyTextReader = new StringReader(File.ReadAllText(filePath)))
            {
                RsaKeyParameters publicKeyParam = (RsaKeyParameters)new PemReader(publicKeyTextReader).ReadObject();

                RSAParameters rsaParams = DotNetUtilities.ToRSAParameters((RsaKeyParameters)publicKeyParam);

                RSACryptoServiceProvider csp = new RSACryptoServiceProvider();
                csp.ImportParameters(rsaParams);
                return csp;
            }
        }
    }
}
