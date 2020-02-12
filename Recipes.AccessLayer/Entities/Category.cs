using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.AccessLayer.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public double Proteins { get; set; }
        public double Carbohydrates { get; set; }
        public double Fat { get; set; }
    }
}
