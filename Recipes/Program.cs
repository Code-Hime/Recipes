using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new RecipeBookContext())
            {
                //Create new Recipe
                Console.WriteLine("Enter a name for your recipe:");
                var name = Console.ReadLine();

                Console.WriteLine("Add an ingredient? (Y/N)");
                var addAnotherIngredient = Console.ReadLine().ToUpper();

                //Add new Ingredient
                while (addAnotherIngredient == "Y")
                {
                    Console.WriteLine("Name of ingredient:");
                    var ingredientname = Console.ReadLine();

                    //TODO -- Add insert on RecipeIngredients
                    //TODO -- Add functionality to choose type from a default list
                    //TODO -- Add functionality to choose measure type from list

                    var ingredient = new Ingredient { Name = ingredientname };
                    db.Ingredients.Add(ingredient);

                    Console.WriteLine("Do you want to add another ingredietnt? (Y/N)");
                    addAnotherIngredient = Console.ReadLine().ToUpper();
                };

                //Add recipe details
                Console.WriteLine("How many calories are in this dish?");
                int calories = Int32.Parse(Console.ReadLine());

                Console.WriteLine("What is the Prep Time for this recipe? (enter in minutes)");
                double preptime = Double.Parse(Console.ReadLine());

                Console.WriteLine("What is the Cook Time for this recipe? (enter in minutes)");
                double cooktime = Double.Parse(Console.ReadLine());

                Console.WriteLine("How many servings does this recipe make?");
                double servings = Double.Parse(Console.ReadLine());

                //Save
                var recipe = new Recipe { Name = name, Calories = calories, Preptime = preptime, Cooktime = cooktime, Servings = servings };
                db.Recipes.Add(recipe);
                db.SaveChanges();

                //Display Recipe List
                var query = from b in db.Recipes
                            orderby b.Name
                            select b;

                Console.WriteLine("Full list of recipes:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                    //TODO -- Add functionality to select list of ingredients for each recipe
                }

                Console.WriteLine("Press any key to exit....");
                Console.ReadKey();

            }
        }
    }
}
