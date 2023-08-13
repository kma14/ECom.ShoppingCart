using ECom.ShoppingCart.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECom.ShoppingCart.Application.Contracts.API
{
    public interface ICart
    {
        Task<bool> CartExists(Guid cartId);

        Task<Cart> GetCartById(Guid cartId);

        void AddCart(Cart cart);

        Task<bool> SaveChanges();

        Task ClearCart(Guid cartId);
    }
}
