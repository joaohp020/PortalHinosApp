using Microsoft.AspNetCore.Mvc;
using PortalHinosApp.API.Repositories.Interfaces;
using PortalHinosApp.Web.Models;
using System.ComponentModel;

namespace PortalHinosApp.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HinoController : ControllerBase
    {
        private readonly IHinoRepositorio _hinoRepositorio;

        public HinoController(IHinoRepositorio hinoRepositorio)
        {
            _hinoRepositorio = hinoRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<HinoModel>>> BuscarTodosHinos()
        {
            List<HinoModel> hinos = await _hinoRepositorio.BuscarTodosHinos();
            return Ok(hinos);
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<HinoModel>> BuscarPorId(int id)
        {
            HinoModel hinos = await _hinoRepositorio.BuscarHinosPorId(id);
            return Ok(hinos);
        }

        [HttpGet]
        public async Task<ActionResult<HinoModel>> BuscarHinoPorNome(string nome)
        {
            HinoModel hinos = await _hinoRepositorio.BuscarHinosPorNome(nome);
            return Ok(hinos);
        }

        [HttpPost]
        public async Task<ActionResult<HinoModel>> Adicionar([FromBody] HinoModel hinoModel)
        {
            HinoModel hino = await _hinoRepositorio.Adicionar(hinoModel);
            return Ok(hino);
        }
    }
}
