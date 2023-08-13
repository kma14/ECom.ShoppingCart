using ECom.ShoppingCart.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECom.ShoppingCart.Persistence
{
    public static class DummyDb<T> where T : class
    {
        public static List<T> Items { get; }= new List<T>();

        public static T? FindItem(Predicate<T> match)
        {
            return Items.Find(match);
        }
    }
}
