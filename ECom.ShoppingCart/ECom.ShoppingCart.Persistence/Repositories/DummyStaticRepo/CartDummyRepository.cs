using ECom.ShoppingCart.Application.Contracts.Common;
using ECom.ShoppingCart.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECom.ShoppingCart.Domain.Entities;

namespace ECom.ShoppingCart.Persistence.Repositories.DummyStaticRepo
{
    public class CartDummyRepository: IAsyncRepository<Cart>
    {
        private 
        public CartDummyRepository()
        {
            
        }
        public Task<Cart> AddAsync(Cart entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Cart entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Cart>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Cart> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Cart entity)
        {
            throw new NotImplementedException();
        }
    }
}
