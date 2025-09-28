namespace GardenApp.Data
{
    public class CartItem
    {
        public Product Product { get; set; } = default!;
        public int Quantity { get; set; } = 1;
    }
}