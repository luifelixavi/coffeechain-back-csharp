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

    public interface IProdutorQueries
    {
        public Task<IEnumerable<Produtor>> GetAllSemFilhos();
    }
    public class ProdutorQuerie : IProdutorQueries
    {
        public async Task<IEnumerable<Produtor>> GetAllSemFilhos()
        {

            ApplicationContext _applicationContext = new ApplicationContext();
            ProdutorRepository _produtorRepository = new ProdutorRepository(_applicationContext);
            string sql = $@"select *
                            from Produtor";

            var conjuge = await _produtorRepository.ObterConexao()
                .QueryAsync<Produtor>(sql);

            return conjuge;
        }
    }
}
