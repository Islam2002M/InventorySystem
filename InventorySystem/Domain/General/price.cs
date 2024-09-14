namespace InventorySystem.Domain.General
{
    public class Price
    {
        private double ItemPrice { get; set; }
        private Currency Curr { get; set; }

        public Price(double p, Currency cur)
        {
            ItemPrice = p;
            Curr = cur;
        }

        public override string ToString()
        {
            return $"{ItemPrice}{Curr}";
        }
    }
}