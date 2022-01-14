using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SALT
{
    public class Analyzer
    {
        public static List<string> Tokens;

        public Analyzer()
        {
            Tokens = new List<string>();
        }

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

        //public string Peek(string input, int index, int lastIndex)
        //{
            
        //}
    }
}
