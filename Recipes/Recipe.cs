using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recipes
{
    public class Recipe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid RecipeId { get; set; }

        public string Name { get; set; }
        public int Calories { get; set; }
        public double Cooktime { get; set; }
        public double Preptime { get; set; }
        public int FoodCategoryId { get; set; }
        public string Origin { get; set; }
        public string Source { get; set; }
        public double Servings { get; set; }
        public byte[] Photo { get; set; }
    }
}
