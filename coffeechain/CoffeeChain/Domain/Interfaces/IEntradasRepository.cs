using CoffeeChain.Domain.Entities;
using Core.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeChain.Domain.Interfaces
{
    public interface IEntradasRepository
    {
        Task<List<Entradas>> GetAll();
        Task<Entradas> GetOne(int EntradaId);
        void Include(Entradas entradas);
        void Update(Entradas entradas);
        void Delete(int EntradaId);
        DbConnection ObterConexao();

        public IUnitOfWork UnitOfWork { get; }
        public void IncludeEF(Entradas entradas);
        public void UpdateEF(Entradas entradas);
    }
}
