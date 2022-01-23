namespace Launsys.Data.Operations
{
    internal interface IOperaciones<T>
    {
        Task<List<T>> ConsultarLista();
        Task<T> Consultar(int pId);
        Task<bool> Grabar();
        Task<bool> Actualizar();
        Task<bool> Desactivar();
    }
}
