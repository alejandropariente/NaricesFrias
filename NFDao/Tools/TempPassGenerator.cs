using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Tools
{
    public class TempPassGenerator
    {
        public static string GenerateTempPass(int length)
        {
            Random random = new Random();
            char[] randomChars = new char[length];

            for (int i = 0; i < length; i++)
            {
                randomChars[i] = GenerateRandomChar(random);
            }

            return new string(randomChars);
        }

        private static char GenerateRandomChar(Random random)
        {
            int randomNumber = random.Next(97, 122);
            return (char)randomNumber;
        }
    }
}
