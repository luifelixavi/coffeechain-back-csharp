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
    public class EmpresaRepository : BaseRepository, IEmpresaRepository
    {
        private readonly ApplicationContext _coffeechainContext;
        public DbConnection ObterConexao() => _coffeechainContext.Database.GetDbConnection();


        public EmpresaRepository(ApplicationContext coffeechainContext)
        {
            _coffeechainContext = coffeechainContext;
        }

        public IUnitOfWork UnitOfWork => _coffeechainContext;
        public async void Delete(int EmpresaId)
        {
            var connectionString = this.Conexao();
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = $"select * from Produtor where id=" + EmpresaId;

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

        public async Task<List<Empresa>> GetAll()
        {
            var connectionString = this.Conexao();
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = $"select * from Produtor where id=";

                    var list = await con.QueryAsync<Empresa>(query);
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

        public async Task<Empresa> GetOne(int EmpresaId)
        {
            var connectionString = this.Conexao();
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = $"select * from Empresa where EmpresaId=" + EmpresaId;

                    var list = await con.QueryAsync<Empresa>(query);
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

        public async void Include(Empresa empresa)
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

        public async void IncludeEF(Empresa empresa)
        {
            _coffeechainContext.empresas.Add(empresa);
        }

        public async void UpdateEF(Empresa empresa)
        {

        }


        public async void Update(Empresa empresa)
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
    }
}
