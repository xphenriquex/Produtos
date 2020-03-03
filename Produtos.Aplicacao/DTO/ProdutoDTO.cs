using System;
using System.Collections.Generic;
using System.Text;

namespace Produtos.Aplicacao.DTO
{
    public class ProdutoDTO : DTOBase
    {
        public string Descricao { get; set; }
        public string Marca { get; set; }
        public int NumeroLote { get; set; }
        public double Preco { get; set; }
    }
}
