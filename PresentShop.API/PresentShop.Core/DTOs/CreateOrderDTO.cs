using System;
using System.Collections.Generic;
using System.Text;
using PresentShop.Core.Enums;

namespace PresentShop.Core.DTOs
{
    public class CreateOrderDTO
    {
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string PostOfficeAddress { get; set; }
        public string? Comment { get; set; }
        public PaymentType PaymentType { get; set; }
    }
}
