using PresentShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using PresentShop.Core.Enums;

namespace PresentShop.Core.DTOs
{
    public class CreateBoxDTO
    {
        public string Name { get; set; }
        public List<ItemDTO> BoxItems { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public List<Size> Sizes { get; set; }
    }
}
