using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Item : BaseEntity
    {
        public string ItemName { get; set; }
        public DateTime? ManufacturingDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Images { get; set; }
        public Category Category { get; set; }
        public Guid CategoryId { get; set; }
        public ICollection<ItemReview>? ItemReviews { get; set; } = new HashSet<ItemReview>();   
        public ICollection<Brand> Brands { get; set; } = new HashSet<Brand>();
        public ICollection<CartItem> CartItems { get; set; } = new HashSet<CartItem>();
    }
}
