using PresentShop.Core.Enums;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace PresentShop.Core.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public User User { get; set; }
        public List<CartBox> CartBox { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
