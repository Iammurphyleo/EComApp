using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DTO;

namespace Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public DateTime? ManufacturingDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string Images { get; set; }
        public Category Category { get; set; }
        public Guid CategoryId { get; set; }
        public ICollection<Review>? Reviews { get; set; } = new HashSet<Review>();   
        public ICollection<Brand> Brands { get; set; } = new HashSet<Brand>();
        public ICollection<OrderProduct> OrderProducts { get; set; } = new HashSet<OrderProduct>();
    }
}
