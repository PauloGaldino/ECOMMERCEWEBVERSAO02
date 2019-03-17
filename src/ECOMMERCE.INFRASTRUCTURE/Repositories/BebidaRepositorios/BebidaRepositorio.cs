using ECOMMERCE.APPLICATION.CORE.Entities.Bebida;
using System.Collections.Generic;

namespace ECOMMERCE.APPLICATION.CORE.Interfaces.Repositories.BebidadRepositorios
{
    interface IBebidaRepositorio
    {
        IEnumerable<Bebida> Bebidas { get; }
        IEnumerable<Bebida> PreferredDrinks { get; }
        Bebida GetBebidaById(int bebidaId);
    }
}
