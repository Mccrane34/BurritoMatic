using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurritoMatic
{
     class Base
    {
        //Variables Declared
        
        public string chosenBaseIngredient;
        public string baseIngedientChosen;
        public string rice = "Rice";
        public string none = "No rice";

      public void setBaseIngredient(string chosenbaseIngredient)
        {
            Console.WriteLine();
            Console.WriteLine("Please type in the ingredient as shown on screen.");
            Console.WriteLine("The 2 and 3-Ingredient Burrito require the tortilla");
            Console.WriteLine("Rice is the only option for a bowl.  Would you like rice?");
            Console.WriteLine("(Y)es or (N)o");
            Console.WriteLine();
            string answer = Console.ReadLine();
            if (answer == "Y")
            {
                chosenBaseIngredient = rice;
                baseIngedientChosen = chosenBaseIngredient;
            }
            else if (answer == "N")

            {
                chosenBaseIngredient = none;
                baseIngedientChosen = chosenBaseIngredient;
            }
           
          
        }  
         public string getBaseIngredient()
        {
            return baseIngedientChosen;
        }
        public void DisplayBaseIngredient()
        {
            Console.WriteLine("The base ingredient chosen: " + baseIngedientChosen);
        }
    }
}
