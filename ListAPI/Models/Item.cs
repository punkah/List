using ListAPI.Responses;
using System;

namespace ListAPI.Models
{
    public class Item
    {
        public Item(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
            Category = Category.Undefined;
        }
        public Guid Id { get; }
        public string Name { get; }
        public Category Category { get; private set; }

        public bool SetRandomCategory()
        {
            Random rnd = new Random();
            SetCategory((Category)rnd.Next(1, Enum.GetNames(typeof(Category)).Length));
            return true;
        }

        public ItemResponse MapToReponse()
        {
            var response = new ItemResponse()
            {
                Category = Category.ToString(),
                Name = Name,
                Id = Id
            };
            return response;
        }

        public bool SetCategory(Category category)
        {
            Category = category;
            return true;
        }
    }
}