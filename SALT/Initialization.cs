using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SALT
{
    public class Initialization
    {
        public List<string> reservedKeywords;
        public List<string> specialSymbols;

        public Initialization()
        {
            reservedKeywords = new List<string>();
            specialSymbols = new List<string>();

            reservedKeywords.Add("if");
            reservedKeywords.Add("else");
            reservedKeywords.Add("else if");
            reservedKeywords.Add("out");
            reservedKeywords.Add("with");
            reservedKeywords.Add("expect");
            reservedKeywords.Add("input");

            specialSymbols.Add("->");
            specialSymbols.Add("+");
            specialSymbols.Add("-");
            specialSymbols.Add("<");
            specialSymbols.Add(">");
            specialSymbols.Add("<=");
            specialSymbols.Add(">=");
            specialSymbols.Add(":");
            specialSymbols.Add("*");
            specialSymbols.Add("!=");
            specialSymbols.Add(";");
            specialSymbols.Add("(");
            specialSymbols.Add(")");
            specialSymbols.Add("{");
            specialSymbols.Add("}");
            specialSymbols.Add("[");
            specialSymbols.Add("]");
        }
    }
}
