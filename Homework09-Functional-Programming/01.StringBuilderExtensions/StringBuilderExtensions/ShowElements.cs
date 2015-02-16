using System;
using System.Text;

namespace StringBuilderExtensions
{
    public static class ShowElements
    {

        public static string Substring(this StringBuilder inputString, int startIndex, int length)
        {
            try
            {
                return inputString.ToString().Substring(startIndex, length);
            }
            catch(ArgumentOutOfRangeException)
            {
                throw new ArgumentOutOfRangeException("Invalid index");
            }
        }
    }
}
