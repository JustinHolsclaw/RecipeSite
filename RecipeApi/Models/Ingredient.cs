using System.Collections.Generic;

namespace RecipeApi.Models
{
    public class Ingredient
    {
        public Ingredient(){}
        public Ingredient(Ingredient ingredient)
        {
            Id = ingredient.Id;
            Name = ingredient.Name;
            Description = ingredient.Description;                                                                                                                                                                                                              
        }

        public long Id {get; set;}
        public string Name { get; set;}
        public string Description {get; set;}
        public List<Recipe> Recipes {get; set;}
    }
}