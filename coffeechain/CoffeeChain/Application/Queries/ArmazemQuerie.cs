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

    public interface IArmazemQueries
    {
        public Task<IEnumerable<Armazem>> GetAllSemFilhos();
    }
    public class ArmazemQuerie : IArmazemQueries
    {
        public async Task<IEnumerable<Armazem>> GetAllSemFilhos()
        {

            ApplicationContext _applicationContext = new ApplicationContext();
            ArmazemRepository _armazemRepository = new ArmazemRepository(_applicationContext);
            string sql = $@"select *
                            from Armazem";

            var conjuge = await _armazemRepository.ObterConexao()
                .QueryAsync<Armazem>(sql);

            return conjuge;
        }
    }
}
