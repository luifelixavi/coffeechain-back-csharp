using CoffeeChain.Domain.Entities;
using Core.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeChain.Domain.Interfaces
{
    public interface IEmpresaRepository
    {
        Task<List<Empresa>> GetAll();
        Task<Empresa> GetOne(int EmpresaId);
        void Include(Empresa empresa);
        void Update(Empresa empresa);
        void Delete(int EmpresaId);
        DbConnection ObterConexao();

        public IUnitOfWork UnitOfWork { get; }
        public void IncludeEF(Empresa empresa);
        public void UpdateEF(Empresa empresa);

    }
}
