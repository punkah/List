using ListAPI.Models;
using System;

namespace ListAPI.Responses
{
    public class ItemResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
    }
}