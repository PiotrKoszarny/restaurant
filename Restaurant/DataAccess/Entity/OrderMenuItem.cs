using System.Collections.Generic;

namespace Restaurant.DataAccess.Entity
{
    public class OrderMenuItem: EntityBase
    {
        public int OrderId { get; set; }
        public int MenuItemId { get; set; }

        public virtual List<Order> Order { get; set; }
        public virtual List<MenuItem> MenuItem { get; set; }
    }
}
