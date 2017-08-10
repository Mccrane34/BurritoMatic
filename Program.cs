using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurritoMatic
{

    public class Program
    {
           
        
        public static void Main(string[] args)
        {

            //Variables Declared  

            double tax = .07;
            double bowlitemPrice = 3.99;
            double bowlPlusTax;
            double bowlTotalPrice;
            double twoIngredientBurritoPrice = 4.99;
            double twoIngredientBurritoTax;
            double twoIngredientBurritoTotalPrice;
            double threeIngredientBurritoPrice = 5.99;
            double threeIngredientBurritoTax;
            double threeIngredientBurritoTotalPrice;
            double quesoCharge = 1.50;
            double quacamoleCharge = 1.25;

            
            Base baseIngredients = new Base();
            MeatIngredients meatIngredients = new MeatIngredients();
            SalsaIngredients salsaIngredients = new SalsaIngredients();
            ToppingIngredients toppingIngredients = new ToppingIngredients();

            Console.WriteLine("Please make a selection of an entree");
            String[] selectedItem = new String[] { "1. 2-Ingredient Bowl $3.99", "2. 2-Ingredient Burrito $4.99", "3. 3-Ingredient Burrito $5.99" };
            Console.WriteLine("Please chose an entree.");
            Console.WriteLine();
            for (int count = 0; count < selectedItem.Length; count++)
            {
                Console.WriteLine(selectedItem[count]);
            }
            Console.WriteLine();

            string itemSelection = Console.ReadLine();
            switch (itemSelection)
            {
                case "1":
                    baseIngredients.setBaseIngredient(baseIngredients.chosenBaseIngredient);
                    baseIngredients.getBaseIngredient();
                    meatIngredients.setMeatIngredient(meatIngredients.ingredientMeatChosen);
                    meatIngredients.getMeatIngredient();
                    salsaIngredients.setSalsaIngredient(salsaIngredients.ingredientSalsaChosen);
                    salsaIngredients.getSalsaIngredient();
                    baseIngredients.DisplayBaseIngredient();
                    meatIngredients.DisplayMeatChosen();
                    salsaIngredients.DisplaySalsaChosen();
                    bowlPlusTax = bowlitemPrice * tax;
                    bowlTotalPrice = bowlitemPrice + bowlPlusTax;
                    Console.WriteLine("The total price of the bowl is: $" + String.Format("{0:.##}", bowlTotalPrice));

                    break;
                case "2":
                    baseIngredients.setBaseIngredient(baseIngredients.chosenBaseIngredient);
                    baseIngredients.getBaseIngredient();
                    meatIngredients.setMeatIngredient(meatIngredients.ingredientMeatChosen);
                    meatIngredients.getMeatIngredient();
                    salsaIngredients.setSalsaIngredient(salsaIngredients.ingredientSalsaChosen);
                    salsaIngredients.getSalsaIngredient();
                    baseIngredients.DisplayBaseIngredient();
                    meatIngredients.DisplayMeatChosen();
                    salsaIngredients.DisplaySalsaChosen();
                    twoIngredientBurritoTax = twoIngredientBurritoPrice * tax;
                    twoIngredientBurritoTotalPrice = twoIngredientBurritoPrice + twoIngredientBurritoTax;

                    if (salsaIngredients.ingredientSalsaChosen == ("Queso")) 
                    {
                        twoIngredientBurritoTotalPrice = twoIngredientBurritoTotalPrice + quesoCharge;
                        Console.WriteLine("The total price of the 2-Ingredient burrito is: $" + String.Format("{0:.##}", twoIngredientBurritoTotalPrice));
                    }
                                      
                                      
                    else if (salsaIngredients.ingredientSalsaChosen == ("Red Salsa") || (toppingIngredients.ingredientToppingChosen == ("Green Salsa")))
                    {

                        twoIngredientBurritoTotalPrice = twoIngredientBurritoTotalPrice + twoIngredientBurritoTax;
                        Console.WriteLine("The total price of the 2-Ingredient burrito is: $" + String.Format("{0:.##}", twoIngredientBurritoTotalPrice));

                    }

                    Console.WriteLine("The total price of the 2-Ingredient burrito is: $" + String.Format("{0:.##}", twoIngredientBurritoTotalPrice));
                    break;
                case "3":
                    baseIngredients.setBaseIngredient(baseIngredients.chosenBaseIngredient);
                    baseIngredients.getBaseIngredient();
                    meatIngredients.setMeatIngredient(meatIngredients.ingredientMeatChosen);
                    meatIngredients.getMeatIngredient();
                    salsaIngredients.setSalsaIngredient(salsaIngredients.ingredientSalsaChosen);
                    salsaIngredients.getSalsaIngredient();
                    toppingIngredients.setToppingIngredient(toppingIngredients.ingredientToppingChosen);
                    toppingIngredients.getToppingIngredient();
                    baseIngredients.DisplayBaseIngredient();
                    meatIngredients.DisplayMeatChosen();
                    salsaIngredients.DisplaySalsaChosen();
                    toppingIngredients.DisplayToppingChosen();
                    threeIngredientBurritoTax = threeIngredientBurritoPrice * tax;
                    threeIngredientBurritoTotalPrice = threeIngredientBurritoPrice + threeIngredientBurritoTax;

                    if (salsaIngredients.ingredientSalsaChosen == ("Queso") && (toppingIngredients.ingredientToppingChosen == ("Guacamole")))
                    {
                        threeIngredientBurritoTotalPrice = threeIngredientBurritoTotalPrice + quesoCharge + quacamoleCharge;
                        Console.WriteLine("The total price of the 3-Ingredient burrito is: $" + String.Format("{0:.##}", threeIngredientBurritoTotalPrice));
                    }
                    else if (salsaIngredients.ingredientSalsaChosen == "Queso")
                    {
                        threeIngredientBurritoTotalPrice = threeIngredientBurritoTotalPrice + quesoCharge;
                        Console.WriteLine("The total price of the 3-Ingredient burrito is: $" + String.Format("{0:.##}", threeIngredientBurritoTotalPrice));
                    }
                    else if (toppingIngredients.ingredientToppingChosen == "Guacamole")
                    {
                        threeIngredientBurritoTotalPrice = threeIngredientBurritoTotalPrice + quacamoleCharge;
                        Console.WriteLine("The total price of the 3-Ingredient burrito is: $" + String.Format("{0:.##}", threeIngredientBurritoTotalPrice));
                    }
                    else if (toppingIngredients.ingredientToppingChosen == ("Grated Cheese") || (toppingIngredients.ingredientToppingChosen == ("Sour Cream")))
                    {

                        threeIngredientBurritoTotalPrice = threeIngredientBurritoPrice + threeIngredientBurritoTax;
                        Console.WriteLine("The total price of the 3-Ingredient burrito is: $" + String.Format("{0:.##}", threeIngredientBurritoTotalPrice));

                    }
                    
                                      
                    break;
                default:
                    Console.WriteLine("Please enter a correct number choice.");
                    break;
            }
            
        }
           

        }

        

}
