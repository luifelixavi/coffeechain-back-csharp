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

    public interface IPropriedadeQueries
    {
        public Task<IEnumerable<Propriedade>> GetAllSemFilhos();
    }
    public class PropriedadeQuerie : IPropriedadeQueries
    {
        public async Task<IEnumerable<Propriedade>> GetAllSemFilhos()
        {

            ApplicationContext _applicationContext = new ApplicationContext();
            PropriedadeRepository _propriedadeRepository = new PropriedadeRepository(_applicationContext);
            string sql = $@"select *
                            from Propriedade";

            var conjuge = await _propriedadeRepository.ObterConexao()
                .QueryAsync<Propriedade>(sql);

            return conjuge;
        }
    }
}
