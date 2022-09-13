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
    public class ProdutorRepository : BaseRepository, IProdutorRepository
    {
        private readonly ApplicationContext _coffeechainContext;
        public DbConnection ObterConexao() => _coffeechainContext.Database.GetDbConnection();


        public ProdutorRepository(ApplicationContext coffeechainContext)
        {
            _coffeechainContext = coffeechainContext;
        }

        public IUnitOfWork UnitOfWork => _coffeechainContext;

        public async Task<List<Produtor>> GetAll()
        {
            var connectionString = this.Conexao();
            using (
                var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    
                    string query = $"select * from Produtor";
                    
                    var list = await con.QueryAsync<Produtor>(query);
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

        public async void Include(Produtor produtor)
        {
            var connectionString = this.Conexao();
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = $"insert into Produtor (NomeProdutor, CpfProdutor, RgProdutor, TelefoneProdutor, EnderecoProdutor, CidadeProdutor, UfProdutor, EmailProdutor, CepProdutor) values ("  +
                        "'" +
                        produtor.NomeProdutor +  "','" + produtor.CpfProdutor + "','" + produtor.RgProdutor + "','" + produtor.TelefoneProdutor + "','" + produtor.EnderecoProdutor + "','" +
                        produtor.CidadeProdutor
                        + "','" + produtor.UfProdutor + "','" + produtor.EmailProdutor + "','" + produtor.CepProdutor + "'" + ")";

                    var list = await con.QueryAsync<Produtor>(query);

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

        public async void IncludeEF(Produtor produtor)
        {
            _coffeechainContext.Produtors.Add(produtor);
        }


        public async void Update(Produtor produtor)
        {
            var connectionString = this.Conexao();
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = $"update Produtor set NomeProdutor = '" + produtor.NomeProdutor + "'," + "CpfProdutor ='" + produtor.CpfProdutor + "'," + "RgProdutor ='" + produtor.RgProdutor +"'," + "TelefoneProdutor ='" + produtor.TelefoneProdutor + "'," +
                        "EnderecoProdutor ='" + produtor.EnderecoProdutor + "'," + "CidadeProdutor ='" + produtor.CidadeProdutor + "'," + "UfProdutor ='" + produtor.UfProdutor +"'," + "EmailProdutor ='" + produtor.EmailProdutor + "'," + "CepProdutor ='" + produtor.CepProdutor + "' where ProdutorId =" + produtor.ProdutorId;

                    var list = await con.QueryAsync<Produtor>(query);
                   
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

        public async void UpdateEF(Produtor produtor)
        {
            _coffeechainContext.Produtors.Update(produtor);
        }

        public async void Delete(int ProdutorId)
        {
            var connectionString = this.Conexao();
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = $"delete from Produtor where ProdutorId =" + ProdutorId;

                    var list = await con.QueryAsync<Produtor>(query);
                    
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

        public async Task<Produtor> GetOne(int ProdutorId)
        {
            return await this._coffeechainContext.Produtors
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.ProdutorId == ProdutorId);
        }
    }
}
