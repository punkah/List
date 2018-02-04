using System;
using System.Collections.Generic;
using System.Linq;

namespace ListAPI.Controllers
{
    public class ItemList
    {
        static List<Item> Items = new List<Item>();
        public ItemList()
        {
            this.Add(new Item {
                Name = "Item 1",    
            });

             this.Add(new Item {
                Name = "Item 2",     
            });
        }

        public bool Add(Item item)
        {
            item.SetRandomCategory();
            Items.Add(item);
            return true;
        }

        internal bool Delete(Guid id)
        {
            Items.RemoveAll(x => x.Id == id);
            return true;
        }

        internal Item Get(Guid id)
        {
            return Items.First(x => x.Id == id);
        }
    }
}