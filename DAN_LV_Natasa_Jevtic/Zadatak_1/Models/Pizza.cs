using System;
using System.Diagnostics;

namespace Zadatak_1.Models
{
    class Pizza
    {
        /// <summary>
        /// This method adds pizza to DbSet and save changes to database.
        /// </summary>
        /// <param name="pizza">Pizza to be created.</param>
        /// <returns>True if created, false if not.</returns>
        public bool CreatePizza(vwPizza pizza)
        {
            try
            {
                using (PanPizzaEntities context = new PanPizzaEntities())
                {
                    tblPizza newPizza = new tblPizza
                    {
                        PizzaIngredients = pizza.PizzaIngredients,
                        PizzaSize = pizza.PizzaSize,
                        TotalAmount = pizza.TotalAmount
                    };
                    context.tblPizzas.Add(newPizza);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception" + ex.Message.ToString());
                return false;
            }
        }
    }
}
