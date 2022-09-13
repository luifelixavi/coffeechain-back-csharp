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
    public class PropriedadeRepository : BaseRepository, IPropriedadeRepository
    {
        private readonly ApplicationContext _coffeechainContext;
        public DbConnection ObterConexao() => _coffeechainContext.Database.GetDbConnection();


        public PropriedadeRepository(ApplicationContext coffeechainContext)
        {
            _coffeechainContext = coffeechainContext;
        }

        public IUnitOfWork UnitOfWork => _coffeechainContext;
        public async void Delete(int PropriedadeId)
        {
            var connectionString = this.Conexao();
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = $"select * from Propriedade where id=" + PropriedadeId;

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

        public async Task<List<Propriedade>> GetAll()
        {
            var connectionString = this.Conexao();
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = $"select * from Propriedade";

                    var list = await con.QueryAsync<Propriedade>(query);
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

        public async Task<Propriedade> GetOne(int PropriedadeId)
        {
            var connectionString = this.Conexao();
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = $"select * from Produtor where id=" + PropriedadeId;

                    var list = await con.QueryAsync<Propriedade>(query);
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

        public async void Include(Propriedade propriedade)
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

        public async void IncludeEF(Propriedade propriedade)
        {
            _coffeechainContext.propriedades.Add(propriedade);
        }

        public async void Update(Propriedade propriedade)
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
        public async void UpdateEF(Propriedade saidas)
        {
            _coffeechainContext.propriedades.Update(saidas);
        }
    }
}
