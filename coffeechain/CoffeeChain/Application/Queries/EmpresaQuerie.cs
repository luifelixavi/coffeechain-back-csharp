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

    public interface IEmpresaQueries
    {
        public Task<IEnumerable<Empresa>> GetAllSemFilhos();
    }
    public class EmpresaQuerie : IEmpresaQueries
    {
        public async Task<IEnumerable<Empresa>> GetAllSemFilhos()
        {

            ApplicationContext _applicationContext = new ApplicationContext();
            EmpresaRepository _EmpresaRepository = new EmpresaRepository(_applicationContext);
            string sql = $@"select *
                            from Empresa";

            var conjuge = await _EmpresaRepository.ObterConexao()
                .QueryAsync<Empresa>(sql);

            return conjuge;
        }
    }
}
