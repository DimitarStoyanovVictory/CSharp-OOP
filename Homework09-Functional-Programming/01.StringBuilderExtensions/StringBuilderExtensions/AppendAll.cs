using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringBuilderExtensions
{
    public static class AppendAllItems
    {
        public static string AppendAll<T>(this StringBuilder finalString, IEnumerable<T> items)
        {
            string result = "";
            items.ToList().ForEach(item => result += item.ToString());

            return finalString + result;
        }
    }
}
