using System.Collections.Generic;
using System.Linq;

namespace Zadatak_1.Models
{
    class PizzaIngredients
    {
        public Dictionary<string, int> ingredients = new Dictionary<string, int>()
        {
            {"Salami", 120 },
            {"Ham", 120 },
            {"Kulen", 150 },
            {"Ketchup", 20 },
            {"Mayonnaise", 20 },
            {"ChillyPepper", 60 },
            {"Olives", 80 },
            {"Oregano", 20 },
            {"Sesame", 20 },
            {"Cheese", 130 },
        };
        /// <summary>
        /// This method creates a collection of pizza ingredients.
        /// </summary>
        /// <returns>List of pizza ingredients.</returns>
        public List<string> GetPizzaIngredients()
        {
            return ingredients.Keys.ToList();
        }
    }
}
