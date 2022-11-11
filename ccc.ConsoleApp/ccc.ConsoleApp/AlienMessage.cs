using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccc.ConsoleApp
{

    internal class AlienMessage
    {
        public string[] Message { get; set; }
        private const string FILE_NAME1 = "level2_1.in";
        private const string FILE_NAME2 = "level2_2.in";
        private const string FILE_NAME3 = "level2_3.in";
        private const string FILE_NAME4 = "level2_4.in";
        private const string FILE_NAME5 = "level2_5.in";

        public string[] Read()
        {
            string[] lines = File.ReadAllLines(FILE_NAME1);
            Message = lines.Skip(1).ToArray();
            return lines.Skip(1).ToArray();
        }

        public string CountLetter(char letter)
        {
            int c = 0;
            foreach (string line in Message)
            {
                foreach (char l in line)
                {
                    if (l == letter)
                    {
                        c++;
                    }
                }
            }
            return Convert.ToString(c);
        }
        public char[] returnDictionary(string[] inp)
        {
            char[] result = new char[CountNumberOfDiffernetLetter(inp)];
            int count = 0;
            string usedChars = "";
            bool isIn;
            for (int i = 0; i < inp.Length; i++)
            {
                isIn = false;
                for (int n = 0; n < usedChars.Length; n++)
                {
                    if (usedChars[n] == inp[i][0])
                    {
                        isIn = true;
                    }
                }
                if (!isIn && count < result.Length)
                {
                    usedChars += inp[i][0];
                    result[count] = inp[i][0];
                    count++;
                }
            }
            return result;
        }
        public static int CountNumberOfDiffernetLetter(string[] strings)
        {
            string inp = "";
            bool isIn;
            for (int i = 0; i < strings.Length; i++)
            {
                for (int n = 0; n < strings[i].Length; n++)
                {
                    isIn = false;
                    for (int j = 0; j < inp.Length; j++)
                    {
                        if (strings[i][n] == inp[j])
                        {
                            isIn = true;
                        }
                    }
                    if (!isIn)
                    {
                        inp += strings[i][n];
                    }

                }
            }
            return inp.Length;

        }

        public static string ShiftString(string input, int value)
        {
            string output = "";
            for(int i = 0; i < input.Length; i++)
            {
                output += Convert.ToString(Convert.ToChar(input[i]) + value);
            }
            return output;
        }

        public static string[] ShiftStringArray(string[] input, int value)
        {
            string[] output = new string[input.Length];
            for(int i = 0; i < input.Length; i++)
            {
                output[i] = ShiftString(input[i], value);
            }
            return output;
        }
    }
}