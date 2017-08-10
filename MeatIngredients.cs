using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurritoMatic
{
    class MeatIngredients
    {
        
        //Variables Declared

        public string ingredientMeat = "";                      
        public string ingredientMeatChosen;


        public void setMeatIngredient(string ingredientMeat)
        {
            String[] chooseMeat = new String[] { "Chicken", "Steak" };
            Console.WriteLine("Please chose a meat topping.");
            Console.WriteLine();
            for (int count = 0; count < chooseMeat.Length; count++)
            {
                Console.WriteLine(chooseMeat[count]);
            }
            Console.WriteLine();
            ingredientMeat = Console.ReadLine();
            if (ingredientMeat == chooseMeat[0] || (ingredientMeat == chooseMeat[1]))
                {
                ingredientMeatChosen = ingredientMeat;
                }
            else
            {
                Console.WriteLine("Please chose the correct ingredient.");            }
        }

        public string getMeatIngredient()
        {
            return ingredientMeatChosen;
        }

        public void DisplayMeatChosen()
        {
            Console.WriteLine("The meat ingredient chosen: " + ingredientMeatChosen);
        }
    }
}
