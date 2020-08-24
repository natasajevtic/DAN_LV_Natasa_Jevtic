using System.Collections.Generic;
using System.Linq;

namespace Zadatak_1.Models
{
    class PizzaSizes
    {
        public Dictionary<string, int> sizes = new Dictionary<string, int>()
        {
            {"small", 100 },
            {"medium", 250 },
            {"large", 400 }
        };
        /// <summary>
        /// This method creates list of sizes for pizza.
        /// </summary>
        /// <returns>List of pizza sizes.</returns>
        public List<string> GetPizzaSizes()
        {
            return sizes.Keys.ToList();
        }
    }
}