
using Core.Messages.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Integration
{
    /// <summary>
    /// DTO Referente ao Cadastro de Pedido	
    /// </summary>
    public class PedidoLojaEpCafeSaldoDTO : IntegrationEvent
    {

        public int EmpresaId { get; set; }
        public int PedidoId { get; set; }
        public int OrdemId { get; set; }
        public int ExercicioId { get; set; }
        public int MesReferId { get; set; }
        public int EntradaQuantidadeSaca { get; set; }
        public int SaidaQuantidadeSaca { get; set; }
        public int SaldoQuantidadeSaca { get; set; }


    }
}
