using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWeb_ASP_NET_Core.Models.Produtos.IRepositorio
{
    public interface IRepositorioProduto
    {
        Produto ObterProduto();
    }
}
