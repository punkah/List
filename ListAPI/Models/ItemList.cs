using ListAPI.Responses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ListAPI.Models
{
    public static class ItemList
    {
        public static List<Item> Items { get; set; }
        static ItemList()
        {
            Items = new List<Item>();
            Add("Item 1");
            Add("Item 2");
        }

        public static bool Add(string name)
        {
            var item = new Item(name);
            item.SetRandomCategory();
            Items.Add(item);
            return true;
        }

        internal static IEnumerable<ItemResponse> MapToReponse()
        {
            var response = new List<ItemResponse>();
            foreach (var item in Items)
            {
                response.Add(new ItemResponse()
                {
                    Category = item.Category.ToString(),
                    Name =  item.Name,
                    Id = item.Id
                });
            }
            return response;
        }

        public static int Count()
        {
            return Items.Count();
        }

        public static bool Delete(Guid id)
        {
            Items.RemoveAll(x => x.Id == id);
            return true;
        }

        public static Item Get(Guid id)
        {
            return Items.FirstOrDefault(x => x.Id == id);
        }
    }
}