namespace CCDemo.Data
{
    /// <summary>
    /// Simpele winkelmand met prijzen en korting.
    /// </summary>
    public class ShoppingCart
    {
        private readonly List<(string Name, decimal Price, int Quantity)> _items = new();

        public void AddItem(string name, decimal price, int quantity = 1)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Naam mag niet leeg zijn");
            if (price < 0)
                throw new ArgumentOutOfRangeException(nameof(price), "Prijs kan niet negatief zijn");
            if (quantity <= 0)
                throw new ArgumentOutOfRangeException(nameof(quantity), "Aantal moet minimaal 1 zijn");

            _items.Add((name, price, quantity));
        }

        public int ItemCount => _items.Count;

        public decimal Subtotal()
        {
            return _items.Sum(i => i.Price * i.Quantity);
        }

        public decimal ApplyDiscount(decimal subtotal, decimal discountPercent)
        {
            if (discountPercent < 0 || discountPercent > 100)
                throw new ArgumentOutOfRangeException(nameof(discountPercent), "Korting moet tussen 0 en 100% zijn");

            return subtotal - (subtotal * discountPercent / 100m);
        }

        public void RemoveItem(string name)
        {
            _items.RemoveAll(i => i.Name == name);
        }

        public bool HasItem(string name)
        {
            return _items.Any(i => i.Name == name);
        }
    }
}
