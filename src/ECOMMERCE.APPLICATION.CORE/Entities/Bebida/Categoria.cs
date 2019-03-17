using System;
using System.Collections.Generic;
using System.Text;

namespace ECOMMERCE.APPLICATION.CORE.Entities.Bebida
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }
        public string Descricao { get; set; }
        public List<Bebida> Bebidas { get; set; }

    }
}
