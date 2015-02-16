using System.Collections.Generic;

namespace System.Linq
{
    public static class WhereEndsWithExtension
    {
        public static IEnumerable<string> WhereEndsWith(this IEnumerable<string> collection, IEnumerable<string> suffixes)
        {
            List<string> list = new List<string>();
            foreach (var item in collection)
            {
                foreach (string suffix in suffixes)
                {
                    if (item.EndsWith(suffix))
                    {
                        list.Add(item);
                    }
                }
            }

            return list;
        }
    }
}
