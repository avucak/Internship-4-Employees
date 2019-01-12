using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppForProjectManagers.Infrastructure.Extensions
{
    public static class StringExtensions
    {
        public static string RemoveAllSpaces(this string text)
        {
            text = text.Trim();
            var regex = new Regex(@"\s");
            text = regex.Replace(text, "");
            return text;
        }
        public static string RemoveDoubleSpaces(this string text)
        {
            text = text.Trim();
            var regex = new Regex(@"\s{2,}");
            text = regex.Replace(text," ");
            return text;
        }
        public static string FirstLetterCapitalRestNot(this string text)
        {
            text = text.RemoveDoubleSpaces();
            var words = text.Split();
            text = "";
            for (int i = 0; i < words.Length; i++)
            {
                var length = words[i].Length - 1;
                words[i] = words[i][0].ToString().ToUpper() + words[i].Substring(1, length).ToLower();
                text += words[i];
                if (i < words.Length - 1)
                    text += " ";
            }
            return text;
        }
    }
}
