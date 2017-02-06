using System.Collections.Generic;

namespace Maracanema.Base
{
    public interface IRepositorio<T> where T : class
    {
        T porId(int id);
        int Salvar(T entidade);
        int Excluir(T entidade);
        IEnumerable<T> listar();
    }
}
