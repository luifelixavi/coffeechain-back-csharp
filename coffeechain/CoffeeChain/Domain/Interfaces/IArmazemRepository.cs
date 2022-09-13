using CoffeeChain.Domain.Entities;
using Core.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeChain.Domain.Interfaces
{
    public interface IArmazemRepository
    {
        Task<List<Armazem>> GetAll();
        Task<Armazem> GetOne(int ArmazemId);
        void Include(Armazem armazem);
        void Update(Armazem armazem);
        void Delete(int ArmazemId);
        DbConnection ObterConexao();

        public IUnitOfWork UnitOfWork { get; }
        public void IncludeEF(Armazem armazem);
        public void UpdateEF(Armazem armazem);
    }
}
