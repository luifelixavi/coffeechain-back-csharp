using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using Core.DomainObjects;

namespace Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }

        public Task<IEnumerable<T>> SelecionarTodos();

        public Task<T> SelecionarPorId(int Id);

        public void Inserir(T entidade);

        public void Atualizar(T entidade);



        public void Deletar(T entidade);

      
    }
}
