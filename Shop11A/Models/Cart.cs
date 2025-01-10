namespace Shop11A.Models
{
    public class Cart
    {
        public List<Product> Items { get; set; } = new List<Product>();
        public decimal TotalAmount => Items.Sum(x => x.Price);
        public const decimal WalletAmount = 3500M;
        public decimal RemainingBalance => WalletAmount - TotalAmount;
    }
}
