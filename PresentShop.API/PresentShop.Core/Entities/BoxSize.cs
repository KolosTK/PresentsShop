using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using PresentShop.Core.Enums;
using Size = PresentShop.Core.Enums.Size;

namespace PresentShop.Core.Entities
{
    public class BoxSize
    {
        public int Id { get; set; }
        public Size Size { get; set; }    
        public int BoxId { get; set; }
        public Box Box { get; set; }
    }
}
