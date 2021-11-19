using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppWeb_ASP_NET_Core.Models.Produtos;
using AppWeb_ASP_NET_Core.Models.Produtos.IRepositorio;

namespace AppWeb_ASP_NET_Core.Data.Produtos
{
    public class RepositorioProduto : IRepositorioProduto
    {
        public Produto ObterProduto()
        {
            return new Produto();
        }
    }
}
