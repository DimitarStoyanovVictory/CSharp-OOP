using System.Collections.Generic;

namespace System.Linq
{
    public static class RepeatExtension
    {
        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count)
        {
            for (int i = 0; i < count; i++)
            {
                foreach (var item in collection)
                {
                    yield return item;
                }
            }
        }
    }
}
