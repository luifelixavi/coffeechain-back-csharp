using CoffeeChain.Domain.Entities;
using Core.Data;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace CoffeeChain.Domain.Interfaces
{
    public interface IProdutorRepository
    {
        Task<List<Produtor>> GetAll();
        Task<Produtor> GetOne(int ProdutorId);
        void Include(Produtor produtor);
        void Update(Produtor produtor);
        void Delete(int ProdutorId);
        DbConnection ObterConexao();

        public IUnitOfWork UnitOfWork  { get; }
        public void IncludeEF(Produtor produtor);
        public void UpdateEF(Produtor produtor);
    }
}
