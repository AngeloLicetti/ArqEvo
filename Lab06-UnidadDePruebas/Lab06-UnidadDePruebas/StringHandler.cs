using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_UnidadDePruebas
{
    public static class StringHandler
    {
        public static string reverse(string input)
        {
            if (input == "")
            {
                return "nullString";
            }
            string output="";
            int length = input.Length - 1;
            while (length >= 0)
            {
                output = output + input[length];
                length--;
            }
            return output;
        }

        public static string trim(string input)
        {
            if (input == "")
            {
                return "nullString";
            }
            if (purosEnBlanco(input))
            {
                return "";
            }
            string output = "";
            output = input.Trim();
            return output;
        }

        public static bool purosEnBlanco(string input)
        {
            foreach(char c in input)
            {
                if(c!=' ')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
