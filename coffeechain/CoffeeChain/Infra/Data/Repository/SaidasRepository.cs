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
    public class SaidasRepository : BaseRepository, ISaidasRepository
    {

        private readonly ApplicationContext _coffeechainContext;
        public DbConnection ObterConexao() => _coffeechainContext.Database.GetDbConnection();


        public SaidasRepository(ApplicationContext coffeechainContext)
        {
            _coffeechainContext = coffeechainContext;
        }

        public IUnitOfWork UnitOfWork => _coffeechainContext;
        public async void Delete(int SaidaId)
        {
            var connectionString = this.Conexao();
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = $"select * from Saidas where id=" + SaidaId;

                    var list = await con.QueryAsync<Saidas>(query);
                    
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

        public async Task<List<Saidas>> GetAll()
        {
            var connectionString = this.Conexao();
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = $"select * from Produtor where id=";

                    var list = await con.QueryAsync<Saidas>(query);
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

        public async Task<Saidas> GetOne(int SaidaId)
        {
            var connectionString = this.Conexao();
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = $"select * from Saidas where id=" + SaidaId;

                    var list = await con.QueryAsync<Saidas>(query);
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

        public async void Include(Saidas saidas)
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

        public async void IncludeEF(Saidas saidas)
        {
            _coffeechainContext.saidas.Add(saidas);
        }

        public async void Update(Saidas saidas)
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
        public async void UpdateEF(Saidas saidas)
        {
            _coffeechainContext.saidas.Update(saidas);
        }
    }
}
