using ECom.ShoppingCart.Application.Contracts.API;
using ECom.ShoppingCart.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECom.ShoppingCart.Application.Contracts;
using ECom.ShoppingCart.Domain.Entities;

namespace ECom.ShoppingCart.Application.Repositories
{
    public class CartRepository: ICart
    {
        private ICartPersist _cartPersistRepo;
        public CartRepository(ICartPersist cartPersistRepo)
        {
            _cartPersistRepo = cartPersistRepo;
        }

        public void AddCart(Cart cart)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CartExists(Guid cartId)
        {
            throw new NotImplementedException();
        }

        public Task ClearCart(Guid cartId)
        {
            throw new NotImplementedException();
        }

        public Task<Cart> GetCartById(Guid cartId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
