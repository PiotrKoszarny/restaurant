namespace Restaurant.DataAccess.Entity
{
    public class MenuItem: EntityBase
    {
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
