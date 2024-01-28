using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ItemReview: BaseEntity
    {
        public string Review { get; set; }

        public Item Item { get; set; }

        public Guid ItemId { get; set; }

        public int? Ratings { get; set; }
      
        public int? LikeItem { get; set; }
        public int? DisLikeItem { get; set; }
    }
}
