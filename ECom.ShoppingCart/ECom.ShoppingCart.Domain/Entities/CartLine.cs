using System.Net.Http.Headers;

namespace ECom.ShoppingCart.Domain.Entities
{
    public class CartLine
    {
        public Guid CartLineId { get; set; }
        public Guid CartId { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public Cart Cart { get; set; }
    }
}