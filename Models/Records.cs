﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoRecipes.Models
{
    public class Recipe
    {
        public string Title { get; init; }
        public string Description { get; init; }
        public IEnumerable<string> Directions { get; init; }
        public IEnumerable<string> Ingredients { get; init; }
        public DateTime Updated { get; init; }
    }
}
