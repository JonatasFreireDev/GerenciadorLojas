using GerenciadorLojasAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorLojasAPI.Repositories.Interfaces
{
    internal interface IMarketRepository
    {
        Task<Market> GetMarketAsync(Guid id);

        Task<IEnumerable<Market>> GetMarketsAsync();

        Task CreateMarketAsync(Market market);

        Task UpdateMarketAsync(Market market);

        Task DeleteMarketAsync(Market market);
    }
}