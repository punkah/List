using System;

namespace ListAPI.Controllers
{
    public class Item
    {

        public Item(string name)
        {
            Name = name;
            Id = new Guid();
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

        public bool SetCategory(Category category)
        {
            Category = category;
            return true;
        }
    }
}