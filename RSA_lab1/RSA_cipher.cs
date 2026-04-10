using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace RSA_lab1
{
    public class RSA_cipher
    {
        public Keys keys = new Keys();
        
        public void GenerateKeys()
        {
            keys.GenerateKeys();

        }
        public string Encrypt(string text, BigInteger s, BigInteger N)
        {
            List<BigInteger> blocks = TextToBlocks(text);

            List<BigInteger> encryptedText = new List<BigInteger>();

            foreach (BigInteger m in blocks)
            {
                BigInteger c = BigInteger.ModPow(m, s, N);
                encryptedText.Add(c);
            }

            return string.Join(" ", encryptedText);
        }

        public string Decrypt(string cipher, BigInteger e, BigInteger N)
        {
            string[] parts = cipher.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            List<BigInteger> encryptedText = new List<BigInteger>();

            foreach (string part in parts)
            {
                if (BigInteger.TryParse(part, out BigInteger c))
                    encryptedText.Add(c);
            }

            List<BigInteger> decryptedText = new List<BigInteger>();
            
            foreach (BigInteger c in encryptedText)
            {
                BigInteger m = BigInteger.ModPow(c, e, N);
                decryptedText.Add(m);
            }

            return BlocksToText(decryptedText);
        }


        private List<BigInteger> TextToBlocks(string text)
        {
            var blockSize = CalculateBlockSize(keys.N);

            byte[] data = Encoding.UTF8.GetBytes(text);
            
            List<BigInteger> blocks = new List<BigInteger>();

            for (int i = 0; i < data.Length; i += blockSize)
            {
                int currentBlockSize = Math.Min(blockSize, data.Length - i);
                byte[] chunk = new byte[currentBlockSize];
                Array.Copy(data, i, chunk, 0, currentBlockSize);

                BigInteger m_i = new BigInteger(chunk, isUnsigned: true, isBigEndian: true);
                

                blocks.Add(m_i);
            }

            return blocks;
        }

        private string BlocksToText(List<BigInteger> blocks)
        {
            List<byte> result = new List<byte>();

            foreach (var m_i in blocks)
            {
                byte[] chunk = m_i.ToByteArray(isUnsigned: true, isBigEndian: true);

                result.AddRange(chunk);
            }

            return Encoding.UTF8.GetString(result.ToArray());
        }

        private int CalculateBlockSize(BigInteger N)
        {
            var N_byteLength = (N.GetBitLength() + 7) / 8;

            var maxBlock = N_byteLength - 1;

            return Math.Min((int)maxBlock, 16);
        }
    }
}
