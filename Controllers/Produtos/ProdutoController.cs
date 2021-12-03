using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using AppWeb_ASP_NET_Core.Data;
using AppWeb_ASP_NET_Core.Models.Produtos;
using AppWeb_ASP_NET_Core.Models.Produtos.IRepositorio;
using Microsoft.AspNetCore.Mvc;

namespace AppWeb_ASP_NET_Core.Controllers.Produtos
{
    [Route("Produto")]
    public class ProdutoController : Controller
    {
        private readonly IRepositorioProduto _repositorioProduto;
        private readonly MyDBContext _context;

        public ProdutoController(IRepositorioProduto repositorioProduto, MyDBContext context)
        {
            _repositorioProduto = repositorioProduto;
            _context = context;
        }

        [Route("Produtos")]
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

            //_context.Produtos.Remove(produto);
            //_context.SaveChanges();

            //var produtos = _context.Produtos.AsQueryable();

            //foreach (var produto in produtos)
            //{
            //    if (produto.Preco > 19.98)
            //    {
            //        produto.Preco = 9.99;
            //    }
            //}

            //_context.SaveChanges();

            //var produtos = _context.Produtos.AsQueryable();

            //foreach (var produto in produtos)
            //{
            //    produto.Validade = false;

            //    _context.Produtos.Update(produto);
            //}

            //_context.Produtos.RemoveRange(produtos);

            //_context.SaveChanges();

            //if (produto3 != null)
            //{
            //    produto3.Id = Guid.NewGuid();
            //    produto3.Nome = "Feijão";

            //    _context.Produtos.Add(produto3);
            //    _context.SaveChanges();
            //}

            return View();
        }
    }
}
