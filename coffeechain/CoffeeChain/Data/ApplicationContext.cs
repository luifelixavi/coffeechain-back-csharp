using CoffeeChain.Domain.Entities;
using Core.Data;
using Core.DomainObjects;
using Core.Mediator;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeChain.Data
{
    public class ApplicationContext : DbContext, IUnitOfWork
    {
        private readonly IConfiguration _configuration;
        private readonly IMediatorHandler _mediatorHandler;

        public async Task<bool> Commit()
        {
            var sucesso = await base.SaveChangesAsync() > 0;
            if (sucesso) await _mediatorHandler.PublicarEventos(this);

            return sucesso;

        }

        public ApplicationContext(DbContextOptions options,
            IConfiguration configuration,
             IMediatorHandler mediatorHandler
            ) : base(options)

        {
            _configuration = configuration;
            _mediatorHandler = mediatorHandler;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public ApplicationContext()
        {
        }

        public DbSet<Produtor> Produtors { get; set; }
        public DbSet<Empresa> empresas { get; set; }
        public DbSet<Entradas> entradas { get; set; }
        public DbSet<Saidas> saidas { get; set; }
        public DbSet<Armazem> Armazens { get; set; }
        public DbSet<Propriedade> propriedades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-AI71CU2\\SQLEXPRESS;Database=CoffeeChain;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
        }

        
}

    public static class MediatorExtension
    {
        /// <summary>
        /// Metodo que publica os eventos
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="mediator"></param>
        /// <param name="ctx"></param>
        /// <returns></returns>
        public static async Task PublicarEventos<T>(this IMediatorHandler mediator, T ctx) where T : DbContext
        {
            var domainEntities = ctx.ChangeTracker
                .Entries<Entity>()
                .Where(x => x.Entity.Notificacoes != null && x.Entity.Notificacoes.Any());

            var domainEvents = domainEntities
                .SelectMany(x => x.Entity.Notificacoes)
                .ToList();

            domainEntities.ToList()
                .ForEach(entity => entity.Entity.LimparEventos());

            var tasks = domainEvents
                .Select(async (domainEvent) =>
                {
                    await mediator.PublicarEvento(domainEvent);
                });

            await Task.WhenAll(tasks);
        }
    }
}
