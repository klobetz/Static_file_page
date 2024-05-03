﻿namespace BlazorApp.Model
{
    public class PizzaSpec
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal BasePrice  { get; set; }
        public string? ImageUrl { get; set; }
        public string GetBasePrice() => BasePrice.ToString("0.00");
    }
}
