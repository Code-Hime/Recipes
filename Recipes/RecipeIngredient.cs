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
    class RecipeIngredient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid RecipeIngredientId { get; set; }

        public int RecipeId { get; set; }
        public int IngredientId { get; set; }
        public int MeasureId { get; set; }

        public double Amount { get; set; }
    }
}
