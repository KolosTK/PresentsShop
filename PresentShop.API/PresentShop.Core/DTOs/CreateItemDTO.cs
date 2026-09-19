using System;
using System.Collections.Generic;
using System.Text;
using PresentShop.Core.Enums;

namespace PresentShop.Core.DTOs
{
    public class CreateItemDTO
    {
        //Incoming DTO
        public string Name { get; set; }
        public double Length { get; set; } = 1;
        public double Width { get; set; } = 1;
        public double Height { get; set; } = 1;
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public string ImageURL { get; set; }
    }
}
