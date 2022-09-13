using CoffeeChain.Domain.Entities;
using Core.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeChain.Domain.Interfaces
{
    public interface ISaidasRepository
    {
        Task<List<Saidas>> GetAll();
        Task<Saidas> GetOne(int SaidaId);
        void Include(Saidas saidas);
        void Update(Saidas saidas);
        void Delete(int SaidaId);
        DbConnection ObterConexao();

        public IUnitOfWork UnitOfWork { get; }
        public void IncludeEF(Saidas saidas);
        public void UpdateEF(Saidas saidas);
    }
}
