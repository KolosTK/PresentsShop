using System;
using System.Collections.Generic;
using System.Text;
using PresentShop.Core.Enums;

namespace PresentShop.Core.DTOs
{
    public class UpdateBoxDTO
    {
        public string Name { get; set; }
        public List<BoxItemDTO> Items { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public List<Size> Sizes { get; set; }
    }
}
