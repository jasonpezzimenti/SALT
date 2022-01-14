using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SALT
{
    public class Keywords
    {
        public enum ReservedKeywords
        {
            IF,
            ELSE,
            ELSEIF,
            STRING,
            INT,
            BOOL,
            DECIMAL,
            FLOAT,
            OUT,
            WITH
        }

        public static ReservedKeywords ReservedKeyword { get; set; }
    }
}
