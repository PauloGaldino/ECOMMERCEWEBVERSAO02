using ECOMMERCE.APPLICATION.CORE.Entities.Bebida;
using ECOMMERCE.APPLICATION.CORE.Interfaces.ICategoria;
using ECOMMERCE.INFRASTRUCTURE.Data;
using System.Collections.Generic;

namespace ECOMMERCE.INFRASTRUCTURE.Repositories.CategoriaRepositorios
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly AppDbContexto _appDbcontexto;
        public CategoriaRepositorio(AppDbContexto appDbcontexto)
        {
            _appDbcontexto = appDbcontexto;
        }
    
        public IEnumerable<Categoria> Categorias => _appDbcontexto.Categorias;
    }
}
       
