using System.Collections.Generic;

namespace Repositories.Contracts
{
    public interface IRepository<T>
    {
        List<T> Listar();
        T BuscarPorId(int id);
        bool Salvar(T model);
        bool AtualizarRegistro(T model, int id);
        void ExcluirRegistro(int id);
    }
}