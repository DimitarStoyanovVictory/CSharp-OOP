using System.Collections.Generic;

namespace System.Linq
{
    public static class WhereNotExtension
    {
        //The best decision of this problem

        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collections, Func<T, bool> predicate)
        {
            return collections.Where(x => !predicate(x));
        }

        // Second decision with yield return

        //public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collections, Func<T, bool> predicate)
        //{
        //    foreach (var item in collections)
        //    {
        //        if (!predicate(item))
        //        {
        //            yield return item;
        //        }
        //    }
        //}

        // Third decision if you dont know wthat is yield return

        //public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collections, Func<T, bool> predicate)
        //{
        //    List<T> list = new List<T>();
        //    foreach (var item in collections)
        //    {
        //        if (!predicate(item))
        //        {
        //            list.Add(item);
        //        }
        //    }

        //    return list;
        //}
    }
}
