using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SALT
{
    public class LanguageOperators
    {
        public enum Operators
        {
            ACTIONOPERATOR,
            ADDITIONOPERATOR,
            SUBTRACTIONOPERATOR,
            DIVISIONOPERATOR,
            MULTIPLICATIONOPERATOR,
            MODULUSOPERATOR
        }

        public static Operators Operator { get; set; }
    }
}
