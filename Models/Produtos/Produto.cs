using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWeb_ASP_NET_Core.Models.Produtos
{
    public class Produto
    {
        #region Construtor

        public Produto()
        {
            Id = Guid.NewGuid();
        }

        #endregion

        #region Propriedades

        public Guid Id { get; set; }

        #endregion
    }
}
