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
        private const string FILE_NAME1 = "level3_1.in";
        private const string FILE_NAME2 = "level3_2.in";
        private const string FILE_NAME3 = "level3_3.in";
        private const string FILE_NAME4 = "level3_4.in";
        private const string FILE_NAME5 = "level3_5.in";

        public string[] outputTask3()
        {
            string[] string2 = Read();
            string[] string1 = first;

            char[] dic = returnDictionary(string2);
            int[] counts = new int[dic.Length];

            for(int i = 0; i < dic.Length; i++)
            {
                counts[i] = CountLetterInt(string2, dic[i]);
            }

            char[] dic2 = returnDictionary(string1);
            int[] counts2 = new int[dic2.Length];

            for (int i = 0; i < dic2.Length; i++)
            {
                counts2[i] = CountLetterInt(string1, dic2[i]);
            }

            return PamCompare(dic, counts, dic2, counts2);
        }

        public string[] PamCompare(char[] chars1, int[] ints1, char[] chars2, int[] ints2)
        {
            List<String> result = new List<String>();
            for (int i = 0; i < ints1.Length; i++)
            {
                for (int j = 0; j < ints2.Length; j++)
                {
                    if (ints1[i] == ints2[j])
                    {
                        result.Add(chars1[i] + " " + chars2[j]);
                    }
                }
            }
            return result.ToArray();
        }

        public int CountLetterInt(string[] arr, char letter)
        {
            int c = 0;
            foreach (string line in arr)
            {
                foreach (char l in line)
                {
                    if (l == letter)
                    {
                        c++;
                    }
                }
            }

            return c;
        }

        public string[] first;

        public string[] Read()
        {
            string[] lines = File.ReadAllLines(FILE_NAME1);
            Message = lines.Skip(1).ToArray();

            first = lines[0].Split(' ');

            lines = lines.Skip(1).ToArray();
            lines = lines.Skip(2).ToArray();

            return lines;
        }

        public string CountLetter(char letter)
        {
            int c = 0;
            foreach (string line in Message) {
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
            //Console.WriteLine(CountNumberOfDiffernetLetter(inp));
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
                if (!isIn)
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
            List<char> cInText = new List<char>();

            foreach (var str in strings)
            {
                foreach (var c in str)
                {
                    bool isInList = false;

                        foreach (var cha in cInText)
                        {
                            
                            if (cha == c)
                            {
                                isInList = true;
                            }
                            
                        }
                    
                    if (!isInList) cInText.Add(c);
                }
            }
            return cInText.Count;
        }
    }
}
