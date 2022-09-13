using CoffeeChain.Data;
using CoffeeChain.Domain.Entities;
using CoffeeChain.Infra.Data.Repository;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeChain.Application.Queries
{

    public interface ISaidasQueries
    {
        public Task<IEnumerable<Saidas>> GetAllSemFilhos();
    }
    public class SaidasQuerie : ISaidasQueries
    {
        public async Task<IEnumerable<Saidas>> GetAllSemFilhos()
        {

            ApplicationContext _applicationContext = new ApplicationContext();
            SaidasRepository _saidasRepository = new SaidasRepository(_applicationContext);
            string sql = $@"select *
                            from Saidas";

            var conjuge = await _saidasRepository.ObterConexao()
                .QueryAsync<Saidas>(sql);

            return conjuge;
        }
    }
}
