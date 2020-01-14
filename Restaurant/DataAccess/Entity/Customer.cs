namespace Restaurant.DataAccess.Entity
{
    public class Customer: EntityBase
    {
        public string Name { get; set; }
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }

    }
}
