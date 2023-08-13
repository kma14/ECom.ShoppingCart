using ECom.ShoppingCart.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECom.ShoppingCart.Application.Contracts.API
{
    public interface ICartLine
    {
        Task<IEnumerable<CartLine>> GetCartLines(Guid cartId);

        Task<CartLine> GetCartLineById(Guid cartId);

        Task<CartLine> AddLine(CartLine cartLine);

        void DeleteLine(Guid cartId);

        void UpdateLine(CartLine cartLine);

        Task<bool> SaveChanges();
    }
}
