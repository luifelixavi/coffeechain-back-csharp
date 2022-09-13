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

    public interface IEntradasQueries
    {
        public Task<IEnumerable<Entradas>> GetAllSemFilhos();
    }
    public class EntradasQuerie : IEntradasQueries
    {
        public async Task<IEnumerable<Entradas>> GetAllSemFilhos()
        {

            ApplicationContext _applicationContext = new ApplicationContext();
            EntradasRepository _entradasRepository = new EntradasRepository(_applicationContext);
            string sql = $@"select *
                            from Entradas";

            var conjuge = await _entradasRepository.ObterConexao()
                .QueryAsync<Entradas>(sql);

            return conjuge;
        }
    }
}
