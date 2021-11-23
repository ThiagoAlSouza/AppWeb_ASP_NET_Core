using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppWeb_ASP_NET_Core.Data;
using AppWeb_ASP_NET_Core.Models.Produtos;
using AppWeb_ASP_NET_Core.Models.Produtos.IRepositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppWeb_ASP_NET_Core.Controllers.Produtos
{
    [Route("Produto")]
    public class ProdutoController : Controller
    {
        private readonly IRepositorioProduto _repositorioProduto;
        private readonly MyDBContext _context ;

        public ProdutoController(IRepositorioProduto repositorioProduto, MyDBContext context)
        {
            _repositorioProduto = repositorioProduto;
            _context = context;
        }


        public IActionResult Produto()
        {
            var produto = new Produto
            {
                Nome = "Arroz",
                Preco = 19.99,
                Avaliacao = 10,
                Validade = true
            };

            _context.Produtos.Add(produto);
            _context.SaveChanges();

            return View();
        }
    }
}
