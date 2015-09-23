using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Gem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool CanPurchase { get; set; }
        public bool IsSoldOut { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
    }
}