using CoffeeChain.Data;
using CoffeeChain.Domain.Entities;
using CoffeeChain.Domain.Interfaces;
using Core.Data;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeChain.Infra.Data.Repository
{
    public class EntradasRepository : BaseRepository, IEntradasRepository
    {

        private readonly ApplicationContext _coffeechainContext;
        public DbConnection ObterConexao() => _coffeechainContext.Database.GetDbConnection();


        public EntradasRepository(ApplicationContext coffeechainContext)
        {
            _coffeechainContext = coffeechainContext;
        }

        public IUnitOfWork UnitOfWork => _coffeechainContext;
        public async void Delete(int EntradaId)
        {
            var connectionString = this.Conexao();
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = $"select * from Produtor where id=" + EntradaId;

                    var list = await con.QueryAsync<Armazem>(query);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public async Task<List<Entradas>> GetAll()
        {
            var connectionString = this.Conexao();
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = $"select * from Produtor where id=";

                    var list = await con.QueryAsync<Entradas>(query);
                    return list.ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public async Task<Entradas> GetOne(int EntradaId)
        {
            var connectionString = this.Conexao();
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = $"select * from Produtor where id=" + EntradaId;

                    var list = await con.QueryAsync<Entradas>(query);
                    return list.FirstOrDefault();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public async void Include(Entradas entradas)
        {
            var connectionString = this.Conexao();
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = $"select * from Produtor where id=";

                    var list = await con.QueryAsync<Entradas>(query);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public async void IncludeEF(Entradas entradas)
        {
            _coffeechainContext.entradas.Add(entradas);
        }

        public async void Update(Entradas entradas)
        {
            var connectionString = this.Conexao();
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = $"select * from Produtor where id=";

                    var list = await con.QueryAsync<Armazem>(query);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
        }
        public  void UpdateEF(Entradas entradas)
        {
           _coffeechainContext.entradas.Update(entradas);
        }
    }
}
