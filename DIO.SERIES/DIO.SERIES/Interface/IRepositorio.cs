using System;
using System.Collections.Generic;

namespace DIO.SERIES.Interface
{
    public interface IRepositorio<T>
    {
        List<T> Lista();

        T RetornaPorId(int id);

        void Insere(T entidade);

        void Exclui(int id);

        void Atualiza(int id, T entidade);

        void ProximoId();
    }
}
