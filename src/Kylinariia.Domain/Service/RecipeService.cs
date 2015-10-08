using Kylinariia.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kylinariia.Domain.Service
{
    public class RecipeService 
    {
        private List<Recipe> recipes = new List<Recipe>();

        public void Add(Recipe item)
        {
            recipes.Add(item);
        }

        public void Delete(Recipe item)
        {
            recipes.Remove(item);
        }

        public List<Recipe> GetAll()
        {
            return recipes;
        }

        public bool Contains(Recipe item)
        { return recipes.Contains(item); }




    }
}
