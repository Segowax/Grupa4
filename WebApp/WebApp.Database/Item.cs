namespace WebApp.Database
{
    public class Item
    {
        public int ID { get; set; } = 0;

        public Guid Guid { get; set; } = Guid.NewGuid();

        public string Name { get; set; } = string.Empty;

        public int Quantity { get; set; } = 0;
    }
}
