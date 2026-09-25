using PresentShop.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentShop.Core.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public OrderStatus Status{ get; set; }
        public decimal TotalPrice { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public List<OrderBox> OrderBoxes { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string PostOfficeAddress { get; set; }
        public string? Comment { get; set; }
        public PaymentType PaymentType { get; set; }

    }
}
