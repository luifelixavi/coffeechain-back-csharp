using CoffeeChain.Domain.Entities;
using Core.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeChain.Domain.Interfaces
{
    public interface IPropriedadeRepository
    {
        Task<List<Propriedade>> GetAll();
        Task<Propriedade> GetOne(int PropriedadeId);
        void Include(Propriedade propriedade);
        void Update(Propriedade propriedade);
        void Delete(int PropriedadeId);
        DbConnection ObterConexao();

        public IUnitOfWork UnitOfWork { get; }
        public void IncludeEF(Propriedade propriedade);
        public void UpdateEF(Propriedade propriedade);
    }
}
