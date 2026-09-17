using PresentShop.Core.Entities;
using PresentShop.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentShop.Core.DTOs
{
    public class BoxDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public List<Size> Sizes { get; set; }
        public List<ItemDTO> Items { get; set; }
    }
}
