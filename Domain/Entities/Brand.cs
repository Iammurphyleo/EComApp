using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Brand : BaseEntity
    {
        public Guid ItemId { get; set; }
        public Item Item { get; set; }
        public string BrandName { get; set; }    
        
    }
}
