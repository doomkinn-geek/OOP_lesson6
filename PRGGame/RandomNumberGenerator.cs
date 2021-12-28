using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace RPGGame
{
    public static class RandomNumberGenerator
    {
        private static readonly RNGCryptoServiceProvider _generator = new RNGCryptoServiceProvider();

        public static uint NumberBetween(uint minimumValue, uint maximumValue)
        {
            byte[] randomNumber = new byte[1];

            _generator.GetBytes(randomNumber);

            double asciiValueOfRandomCharacter = Convert.ToDouble(randomNumber[0]);            
            double multiplier = Math.Max(0, (asciiValueOfRandomCharacter / 255d) - 0.00000000001d);

            
            uint range = maximumValue - minimumValue + 1;
            double randomValueInRange = Math.Floor(multiplier * range);

            return (uint)(minimumValue + randomValueInRange);
        }
    }
}
