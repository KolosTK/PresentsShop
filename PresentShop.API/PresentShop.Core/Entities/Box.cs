using PresentShop.Core.Enums;
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
        public List<BoxItem> BoxItems { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public List<Size> Sizes{ get; set; }
        public int UserId { get; set; }
        public User? User{ get; set; }
    }
}
