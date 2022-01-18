using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SALT
{
    public class Analyzer
    {
        public enum Tokens { }

        public Tokens Token { get; set; }

        public Analyzer() { }

        public void Analyze(string input)
        {
            for(int index = 0; index < input.Length; index++)
            {
                
            }
        }

        public char Peek(string input, int index)
        {
            return input[index];
        }


    }
}
