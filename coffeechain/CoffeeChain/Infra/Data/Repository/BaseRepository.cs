using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeChain.Infra.Data.Repository
{
    public class BaseRepository
    {
        public BaseRepository()
        {
        }

        public string Conexao()
        {
            try
            {
                
                string txtPath = Path.Combine(Environment.CurrentDirectory, "base.ini");
                TextReader tr = new StreamReader(txtPath);
                string caminha_BD = tr.ReadLine();
                tr.Close();
                string st_conexaoArquivo = caminha_BD;
                return st_conexaoArquivo;

            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
        }
    }

}
