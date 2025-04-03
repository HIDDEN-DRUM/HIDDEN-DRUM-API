using System;
using System.Collections.Generic;

namespace HIDDEN_DRUM.Domain.Catalog
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }

        public List<Rating> Ratings { get; set; }

        public Item(string name, string description, string brand, decimal price)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name cannot be null or empty.");
            }

            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentException("Description cannot be null or empty.");
            }

            if (string.IsNullOrEmpty(brand))
            {
                throw new ArgumentException("Brand cannot be null or empty.");
            }

            if (price < 0.00m)
            {
                throw new ArgumentException("Price must be greater than or equal to zero.");
            }

            Name = name;
            Description = description;
            Brand = brand;
            Price = price;

            Ratings = new List<Rating>(); // initialize Ratings list
        }

        public void AddRating(Rating rating)
        {
            if (rating == null)
            {
                throw new ArgumentNullException(nameof(rating), "Rating cannot be null.");
            }

            Ratings.Add(rating);
        }
    }
}



