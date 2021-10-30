using System.Collections.Generic;
using myAliasName2 = System.Collections.Generic.List<int>;

namespace Series.Interfaces
{
    public interface IRepositorio<T>
    {
        List <T> Lista();
        T RetornaPorId (int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}