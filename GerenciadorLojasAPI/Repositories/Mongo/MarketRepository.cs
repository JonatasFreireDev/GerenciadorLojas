using GerenciadorLojasAPI.Models;
using GerenciadorLojasAPI.Repositories.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorLojasAPI.Repositories.Mongo
{
    public class MarketRepository : IMarketRepository
    {
        private const string databaseName = "gerenciadorLojas";
        private const string collectionName = "markets";

        private readonly IMongoCollection<Market> marketsCollection;

        public MarketRepository(IMongoClient mongoClient)
        {
            IMongoDatabase database = mongoClient.GetDatabase(databaseName);
            marketsCollection = database.GetCollection<Market>(collectionName);
        }

        public async Task CreateMarketAsync(Market market)
        {
            await marketsCollection.InsertOneAsync(market);
        }

        public Task DeleteMarketAsync(Market market)
        {
            throw new NotImplementedException();
        }

        public Task<Market> GetMarketAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Market>> GetMarketsAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateMarketAsync(Market market)
        {
            throw new NotImplementedException();
        }
    }
}