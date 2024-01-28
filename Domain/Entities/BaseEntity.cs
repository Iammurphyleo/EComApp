using Domain.contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BaseEntity : ISoftDelete, IAuditBase
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get ; set; }
        public Guid CreatedBy { get; set; }
        public DateTime? ModifiedAt { get ; set ; }
        public Guid? ModifiedBy { get ; set ; }
    }  
        
}
