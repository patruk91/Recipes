using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.AccessLayer.Entities
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public string Complexity { get; set; }
        public string LinkToPhoto { get; set; }
        public string MethodOfPreparation { get; set; }
        public double Kcal { get; set; }
        public double Rating { get; set; }

        public Dictionary<int, double> Ingredients { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Category> Categories { get; set; }
    }
}
