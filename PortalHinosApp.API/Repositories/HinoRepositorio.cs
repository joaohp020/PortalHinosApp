using Microsoft.EntityFrameworkCore;
using PortalHinosApp.API.Data;
using PortalHinosApp.API.Repositories.Interfaces;
using PortalHinosApp.Web.Models;

namespace PortalHinosApp.API.Repositories
{
    public class HinoRepositorio : IHinoRepositorio
    {

        private readonly PortalHinosDbContext _dbContext;
        public HinoRepositorio(PortalHinosDbContext portalHinosDbContext)
        {
            _dbContext = portalHinosDbContext;
        }

        public async Task<HinoModel> BuscarHinosPorId(int id)
        {
            return await _dbContext.Hino.FirstOrDefaultAsync(x => x.Id == id);
        }
        
        public async Task<HinoModel> BuscarHinosPorNome(string nome)
        {
            return await _dbContext.Hino.FirstOrDefaultAsync(x => x.Nome == nome);
        }

        public async Task<List<HinoModel>> BuscarTodosHinos()
        {
            return await _dbContext.Hino.ToListAsync();
        }

        public async Task<HinoModel> Adicionar(HinoModel hino)
        {
            await _dbContext.Hino.AddAsync(hino);
            await _dbContext.SaveChangesAsync();

            return hino;
        }

        public async Task<HinoModel> Atualizar(HinoModel hino, int id)
        {
            HinoModel hinoPorId = await BuscarHinosPorId(id);

            if (hinoPorId == null)
            {
                throw new Exception($"Hino para o id: {id} não foi encontrado no banco de dados.");
            }

            hinoPorId.Nome = hino.Nome;
            hinoPorId.Letra = hino.Letra;
            hinoPorId.Inclusao = hino.Inclusao;


            _dbContext.Hino.Update(hinoPorId);
            await _dbContext.SaveChangesAsync();

            return hinoPorId;
        }

        public async Task<bool> Deletar(int id)
        {
            HinoModel hinoPorId = await BuscarHinosPorId(id);

            if (hinoPorId == null)
            {
                throw new Exception($"Hino para o id: {id} não foi encontrado no banco de dados.");
            }

            _dbContext.Hino.Remove(hinoPorId);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
