using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PresentShop.Core.Entities
{
    public class BoxSize
    {
        int Id { get; set; }
        int SizeId { get; set; }    
        Size Size { get; set; }
        int BoxId { get; set; }
        Box Box { get; set; }
    }
}
