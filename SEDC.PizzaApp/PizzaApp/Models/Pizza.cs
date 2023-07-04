﻿namespace PizzaApp.Models
{
    public class Pizza
    {
        internal List<string> PizzaSizes;

        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Price { get; set; }

        public bool IsOnPromotion { get; set; }

        public string? ImageUrl { get; set; }
        public List<string> Ingredients { get; internal set; }
    }
}
