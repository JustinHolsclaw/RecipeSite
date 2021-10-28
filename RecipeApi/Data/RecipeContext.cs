using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeApi.Models;

namespace RecipeApi.Models
{
    public class RecipeContext : DbContext
    {
        public RecipeContext(DbContextOptions<RecipeContext> options)
            : base(options)
        {

        }
        public DbSet<Recipe> RecipeItems { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
    }
}