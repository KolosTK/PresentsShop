using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using PresentShop.Core.Enums;

namespace PresentShop.Core.DTOs
{
    public class CreateItemDTO
    {
        //Incoming DTO
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Range(0, 500)]
        public double Length { get; set; } = 1;
        [Range(0, 500)]
        public double Width { get; set; } = 1;
        [Range(0, 500)]
        public double Height { get; set; } = 1;
        [MaxLength(100)]
        public string Description { get; set; }
        [Range(0,100000)]
        public decimal Price { get; set; }
        [Range(1, int.MaxValue)]
        public int CategoryId { get; set; }
        public string ImageURL { get; set; }
    }
}
