using System;
using System.Collections.Generic;
using System.Linq;

namespace ListAPI.Controllers
{
    public class ItemList
    {
        public static List<Item> Items = new List<Item>();
        public ItemList()
        {
            Add("Item 1");
            Add("Item 2");
        }

        public bool Add(string name)
        {
            var item = new Item(name);
            item.SetRandomCategory();
            Items.Add(item);
            return true;
        }

        public int Count()
        {
            return Items.Count();
        }

        public bool Delete(Guid id)
        {
            Items.RemoveAll(x => x.Id == id);
            return true;
        }

        public Item Get(Guid id)
        {
            return Items.First(x => x.Id == id);
        }
    }
}