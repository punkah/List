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

        internal static ItemListResponse MapToReponse()
        {
            var response = new ItemListResponse();
            response.Items = new List<ItemResponse>();
            foreach(var item in Items)
            {
                response.Items.Add(new ItemResponse()
                {
                    Category = item.Category,
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