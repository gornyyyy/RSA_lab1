using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RSA_lab1
{
    public class Keys
    {
        public BigInteger N {  get; set; }
        public BigInteger s { get; set; }
        public BigInteger e { get; set; }

        public void GenerateKeys()
        {
            BigInteger p = GeneratePrimeInt();
            BigInteger q = GeneratePrimeInt();
            N = p * q;

            BigInteger d = GeneratePhi(p, q);

            s = GenerateS(d);

            e = GenerateE(s, d);
        }
        private BigInteger GeneratePrimeInt()
        {
            BigInteger p;
            while (true)
            {
                p = Generate14DigitInt();
                if (MillerRabinTest(p, 10))
                    break;
            }
            return p;
        }

        private BigInteger Generate14DigitInt()
        {
            byte[] bytes = RandomNumberGenerator.GetBytes(6);
            bytes[^1] &= 0x7F;

            BigInteger number = new BigInteger(bytes);

            BigInteger min = 31622776601684;

            if (number < min) { number += min; }
            else if (number > (BigInteger)Math.Pow(10, 14) - 1)
            {
                number %= BigInteger.Pow(10, 14);
                if (number < min) { number += min; }
            }

            return number;
        }

        private BigInteger GenerateE(BigInteger s, BigInteger d)
        {
            s = ((s % d) + d) % d;

            BigInteger t = 0, newT = 1;
            BigInteger r = d, newR = s;

            while (newR != 0)
            {
                BigInteger quotient = r / newR;

                (t, newT) = (newT, t - quotient * newT);
                (r, newR) = (newR, r - quotient * newR);
            }

            if (r > 1)
                throw new InvalidOperationException($"Число {s} не имеет обратного по модулю {d}, так как НОД({s}, {d}) = {r}");

            if (t < 0)
                t += d;

            return t;
        }
        private bool MillerRabinTest(BigInteger n, int k)
        {
            if (n < 2) return false;
            if (n == 2 || n == 3) return true;
            if (n % 2 == 0) return false;


            BigInteger d = n - 1;
            int s = 0;

            while (d % 2 == 0)
            {
                d /= 2;
                s++;
            }

            for (int i = 0; i < k; i++)
            {
                using var rng = RandomNumberGenerator.Create();

                byte[] _a = new byte[n.ToByteArray().LongLength];

                BigInteger a;

                do
                {
                    rng.GetBytes(_a);

                    a = new BigInteger(_a);
                }
                while (a < 2 || a > n - 2);

                BigInteger x = BigInteger.ModPow(a, d, n);

                if (x == 1 || x == n - 1)
                    continue;

                for (int r = 0; r < s; r++)
                {
                    x = BigInteger.ModPow(x, 2, n);

                    if (x == 1)
                        return false;
                    if (x == n - 1)
                        break;
                }

                if (x != n - 1)
                    return false;
            }

            return true;
        }

        private BigInteger GeneratePhi(BigInteger p, BigInteger q)
        {
            return (p - 1) * (q - 1);
        }
        private BigInteger GenerateS(BigInteger phi)
        {
            BigInteger s = 65537;
            while (BigInteger.GreatestCommonDivisor(s, phi) != 1)
            {
                s += 2;
            }
            return s;
        }
    }
}
