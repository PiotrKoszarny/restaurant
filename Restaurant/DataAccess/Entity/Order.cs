using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.DataAccess.Entity
{
    public class Order : EntityBase
    {
        public DateTime OrderDateTime { get; set; }
        public int OrderMenuItemId { get; set; }
        public int CustomerId { get; set; }

        public virtual OrderMenuItem OrderMenuItem { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
