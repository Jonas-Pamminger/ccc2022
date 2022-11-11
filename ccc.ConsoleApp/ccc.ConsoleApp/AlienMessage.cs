using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccc.ConsoleApp
{
    
    internal class AlienMessage
    {
        public string Message { get; set; }

        public int CountB()
        {
            int c = 0;
            foreach(char l in Message)
            {
                if(l == 'B')
                {
                    c++;
                }
            }
            return c;
        }
    }
}
