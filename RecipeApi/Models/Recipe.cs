using System.Collections.Generic;

namespace RecipeApi.Models
{
    public class Recipe
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description {get; set;}
        public int IngredientId {get; set;}
        public string Instructions {get; set;}
        public string Date {get; set;}
        public List<Ingredient> Ingredients {get; set;}

    }

    public class RecipeDTO
    {

        public RecipeDTO(){}
        public RecipeDTO(Recipe recipe){
            Id= recipe.Id;
            Name= recipe.Name;
            Description = recipe.Description;
            IngredientId = recipe.IngredientId;
            Instructions = recipe.Instructions;
            Date = recipe.Date;
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description {get; set;}
        public int IngredientId {get; set;}
        public string Instructions {get; set;}
        public string Date {get; set;}
    }
}

