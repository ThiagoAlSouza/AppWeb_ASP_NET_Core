using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppWeb_ASP_NET_Core.Models.Produtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AppWeb_ASP_NET_Core.Data
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions options) : base(options)
        {
                
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
