using System;

namespace CrazyStuff
{
    public class CrazyTextFormatter
    {
        public string CharToText()
        {
            char[] letters = { 'H', 'e', 'l', 'l', 'o', ',', ' ', 'W', 'o', 'r', 'l', 'd', '!' };
            return CharToText(letters);
        }

        public string CharToText(char[] letters)
        {
            string name = "";
            int[] allNumbers = new int[letters.Length];
            for (int i = 0; i < letters.Length; i++)
            {
                name += letters[i];
                allNumbers[i] = i + 1;
            }

            int min = int.MaxValue;
            int max = int.MinValue;
            foreach (var myNum in allNumbers)
            {
                if (myNum < min)
                    min = myNum;
                if (myNum > max)
                    max = myNum;
                
            }

            if (max < min)
                throw new ApplicationException();

            name += " " + max;
            return name;
        }
    }
}
