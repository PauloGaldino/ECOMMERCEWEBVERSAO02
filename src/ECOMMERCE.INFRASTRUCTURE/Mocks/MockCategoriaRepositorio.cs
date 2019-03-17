using System.Collections.Generic;
using ECOMMERCE.APPLICATION.CORE.Entities.Bebida;
using ECOMMERCE.APPLICATION.CORE.Interfaces.ICategoria;

namespace ECOMMERCE.INFRASTRUCTURE.Mocks
{
    public class MockCategoriaRepositorio : ICategoriaRepositorio
    {
        public IEnumerable<ECOMMERCE.APPLICATION.CORE.Entities.Bebida.Categoria> Categorias
        {
            get
            {
                return new List<Categoria>
                    {
                         new Categoria { CategoriaNome = "Alcólica", Descricao = "Todas as bebidas alcólicas" },
                         new Categoria { CategoriaNome = "Sem alcool", Descricao = "Todas as bebidas sem alcool" }

                    };
            }
        }
    }

}

