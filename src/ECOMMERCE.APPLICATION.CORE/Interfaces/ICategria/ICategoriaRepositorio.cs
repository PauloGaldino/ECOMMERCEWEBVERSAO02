using ECOMMERCE.APPLICATION.CORE.Entities.Bebida;
using System.Collections.Generic;

namespace ECOMMERCE.APPLICATION.CORE.Interfaces.ICategoria
{
    public interface ICategoriaRepositorio
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
