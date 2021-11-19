using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppWeb_ASP_NET_Core.Models.Produtos.IRepositorio;
using Microsoft.AspNetCore.Mvc;

namespace AppWeb_ASP_NET_Core.Controllers.Produtos
{
    [Route("Produto")]
    public class ProdutoController : Controller
    {
        private readonly IRepositorioProduto _repositorioProduto;

        public ProdutoController(IRepositorioProduto repositorioProduto)
        {
            _repositorioProduto = repositorioProduto;
        }


        public IActionResult Produto()
        {
            var produto = _repositorioProduto.ObterProduto();

            return View();
        }
    }
}
