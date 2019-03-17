using ECOMMERCE.APPLICATION.CORE.Entities.Bebida;
using System.Collections.Generic;

namespace ECOMMERCE.APPLICATION.CORE.Interfaces.IBebida
{
    public interface IBebidaRepositorio
    {
        IEnumerable<Bebida> Bebidas { get; }
        IEnumerable<Bebida> BebidasPreferidas { get; }
        Bebida GetBebidakById(int BebidaId);
    }
}
