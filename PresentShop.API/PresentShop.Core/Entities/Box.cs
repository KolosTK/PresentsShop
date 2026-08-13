using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace PresentShop.Core.Entities
{
    public class Box
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Item> Items { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public Size Size{ get; set; }
        public int UserId { get; set; }
    }
}
