using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Linq;

namespace WinFormsApp1
{
    public class Algorithm_Regex
    {
        public string Reg(string input)
        {
            string pattern = "[0123456]|[ [a-z]]";
            string replacement(Match match)
            {
                switch (match.Value)
                {
                    case "6": return "g";
                    case "1": return "i";
                    case "0": return "o";
                    case "5": return "s";
                    case "2": return "z";
                    case "4": return "a";
                    case "3": return "e";
                    default: return match.Value;
                }
            }

            string resultAngka = Regex.Replace(input, pattern, new MatchEvaluator(replacement));
            string resultTitle = Regex.Replace(resultAngka.ToLower(), @"\b[a-z]", match => match.Value.ToUpper());

            return resultTitle;
        }
    }
}
