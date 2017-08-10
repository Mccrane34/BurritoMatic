using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurritoMatic
{
    class SalsaIngredients
    {
        //Variables Declared

        public string ingredientSala = "";
        public string ingredientSalsaChosen;


        public void setSalsaIngredient(string ingredientSalsa)
        {
            String[] chooseSalsa = new String[] { "Red Salsa", "Green Salsa", "Queso" };
            Console.WriteLine("Please chose a salsa topping.");
            Console.WriteLine();
            for (int count = 0; count < chooseSalsa.Length; count++)
            {
                Console.WriteLine(chooseSalsa[count]);
            }
            Console.WriteLine();
            ingredientSalsa = Console.ReadLine();
            if (ingredientSalsa == chooseSalsa[0] || (ingredientSalsa == chooseSalsa[1])
                || (ingredientSalsa == chooseSalsa[2]))
            {
                ingredientSalsaChosen = ingredientSalsa;
            }
            else
            {
                Console.WriteLine("Please chose the correct ingredient.");
            }
        }
        public string getSalsaIngredient()
        {
            return ingredientSalsaChosen;
        }

        public void DisplaySalsaChosen()
        {
            Console.WriteLine("The salsa ingredient chosen: " + ingredientSalsaChosen);
        }
    }
}