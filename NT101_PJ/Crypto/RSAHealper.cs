using System.Security.Cryptography;
using System.Text;

namespace NT101_PJ.Crypto
{
    internal class RSAHealper : IDisposable
    {
        
        public bool IsPublicKeyOnly { get; set; }

        private RSA _rsa;

        public RSAHealper(int keySize) {
            _rsa = RSA.Create();
            _rsa.KeySize = keySize;
        }

        public RSAHealper(string PublicKey, string PrivateKey = null) {
            if (string.IsNullOrEmpty(PublicKey) && string.IsNullOrEmpty(PrivateKey)) 
            {
                throw new Exception("Public and private keys must not be empty at the same time");
            }
            _rsa = RSA.Create();
            IsPublicKeyOnly = true;
            if (!string.IsNullOrEmpty(PrivateKey))
            {
                _rsa.ImportFromPem(PrivateKey);
                IsPublicKeyOnly = false;
            }
            if (!string.IsNullOrEmpty(PublicKey))
            {
                _rsa.ImportFromPem(PublicKey);
            }
        }

        public string Encrypt(string data, RSAEncryptionPadding padding)
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            var resBytes = _rsa.Encrypt(dataBytes, padding);
            return Convert.ToBase64String(resBytes);
        }

        public string Decrypt(string data, RSAEncryptionPadding padding)
        {
            if (IsPublicKeyOnly)
            {
                throw new ArgumentException("private key can not null");
            }
            byte[] dataBytes = Convert.FromBase64String(data);
            var resBytes = _rsa.Decrypt(dataBytes, padding);
            return Encoding.UTF8.GetString(resBytes);
        }

        public string PublicKeyExport()
        {
            if (_rsa == null)
            {
                return String.Empty;
            }
            return _rsa.ExportRSAPublicKeyPem();
        }

        public string PrivateKeyExport()
        {
            if (_rsa == null)
            {
                return String.Empty;
            }
            return _rsa.ExportRSAPrivateKeyPem();
        }

        public void Dispose()
        {
            _rsa?.Dispose();
        }
    }
}
