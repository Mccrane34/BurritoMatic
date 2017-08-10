using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurritoMatic
{
    class ToppingIngredients
    {
        //Variables Declared

        public string ingredientTopping = "";
        public string ingredientToppingChosen;


        public void setToppingIngredient(string ingredientTopping)
        {
            String[] chooseTopping = new String[] { "Grated Cheese", "Sour Cream", "Guacamole" };
            Console.WriteLine("Please chose a topping.");
            Console.WriteLine();
            for (int count = 0; count < chooseTopping.Length; count++)
            {
                Console.WriteLine(chooseTopping[count]);
            }
            Console.WriteLine();
            ingredientTopping = Console.ReadLine();
            if (ingredientTopping == chooseTopping[0] || (ingredientTopping == chooseTopping[1])
                || (ingredientTopping == chooseTopping[2]))
            {
                ingredientToppingChosen = ingredientTopping;
            }
            else 
            {
                Console.WriteLine("Please chose the correct ingredient.");
            }
        }
        public string getToppingIngredient()
        {
            return ingredientToppingChosen;
        }

        public void DisplayToppingChosen()
        {
            Console.WriteLine("The topping ingredient chosen: " + ingredientToppingChosen);
           
        }
    }
}
