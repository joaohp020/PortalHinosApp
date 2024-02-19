using PortalHinosApp.Web.Models;

namespace PortalHinosApp.API.Repositories.Interfaces
{
    public interface IHinoRepositorio
    {
        Task<List<HinoModel>> BuscarTodosHinos();
        Task<HinoModel> BuscarHinosPorId(int id);
        Task<HinoModel> BuscarHinosPorNome(string nome);
        Task<HinoModel> Adicionar(HinoModel hino);
        Task<HinoModel> Atualizar(HinoModel hino, int id);
        Task<bool> Deletar(int id);
    }
}
