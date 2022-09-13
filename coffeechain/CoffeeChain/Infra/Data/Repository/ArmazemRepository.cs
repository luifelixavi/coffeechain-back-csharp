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
    public class ArmazemRepository : BaseRepository, IArmazemRepository
    {
        private readonly ApplicationContext _coffeechainContext;
        public DbConnection ObterConexao() => _coffeechainContext.Database.GetDbConnection();


        public ArmazemRepository(ApplicationContext coffeechainContext)
        {
            _coffeechainContext = coffeechainContext;
        }

        public IUnitOfWork UnitOfWork => _coffeechainContext;
        public async void Delete(int id)
        {
            var connectionString = this.Conexao();
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = $"select * from Produtor where id=" + id;

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

        async public Task<List<Armazem>> GetAll()
        {
            var connectionString = this.Conexao();
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = $"select * from Armazem";

                    var list = await con.QueryAsync<Armazem>(query);
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

        public async Task<Armazem> GetOne(int id)
        {
            var connectionString = this.Conexao();
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = $"select * from Armazem where id=" + id;

                    var list = await con.QueryAsync<Armazem>(query);
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

        public async void Include(Armazem armazem)
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

        public async void IncludeEF(Armazem armazem)
        {
            _coffeechainContext.Armazens.Add(armazem);
        }

        public async void Update(Armazem armazem)
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
        public async void UpdateEF(Armazem armazem)
        {
            _coffeechainContext.Armazens.Update(armazem);
        }
    }
}
