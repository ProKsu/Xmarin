using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Task1
{
    public partial class DataService
    {
        public static List<string> Fruits { get; } = new List<string>
        {
            "BMW",
            "Nissan",
            "Merc"
        };

        public static List<string> GetItems(string queryString)
        {
            var normalizedQuery = queryString?.ToLower() ?? "";
            return Fruits.Where(f => f.ToLowerInvariant().Contains(normalizedQuery)).ToList();
        }
    }
}

