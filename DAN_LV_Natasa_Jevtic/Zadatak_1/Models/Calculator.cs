using System.Collections.Generic;
using System.Linq;

namespace Zadatak_1.Models
{
    class Calculator
    {
        /// <summary>
        /// This method calculates total amount of pizza.
        /// </summary>
        /// <param name="ingredients">Pizza ingedients.</param>
        /// <param name="pizzaSize">Pizza size.</param>
        /// <returns>Total amount of pizz.</returns>
        public static int CalculateAmount(string ingredients, string pizzaSize)
        {
            PizzaIngredients ingredientsModel = new PizzaIngredients();
            PizzaSizes sizesModel = new PizzaSizes();
            int totalAmount = 0;
            //finding price for pizza size
            totalAmount += sizesModel.sizes[pizzaSize];
            List<string> allIngredients = ingredients.Split(' ').ToList();
            allIngredients.Remove(allIngredients[allIngredients.Count - 1]);
            //finding price for every ingredient of pizza
            foreach (var ingredient in allIngredients)
            {
                totalAmount += ingredientsModel.ingredients[ingredient];
            }
            return totalAmount;
        }
    }
}
