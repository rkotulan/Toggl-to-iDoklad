namespace TogglToInvoice.Common.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class ListExtensions
    {
        public static void AddRange<T>(this IList<T> destinationList, IList<T> items, Func<T, T, bool> compareFce)
        {
            foreach (var item in items)
            {
                if (destinationList.FirstOrDefault(x => compareFce.Invoke(x, item)) == null)
                {
                    destinationList.Add(item);
                }
            }
        }
    }
}