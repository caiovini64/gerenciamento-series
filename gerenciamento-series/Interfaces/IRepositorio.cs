using System.Collections.Generic;

namespace gerenciamento_series
{
    interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int proximoId();

    }
}