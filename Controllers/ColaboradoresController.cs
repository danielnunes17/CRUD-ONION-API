using CRUD_ONION_API.Domain.Data;
using CRUD_ONION_API.Domain.Models;
using CRUD_ONION_API.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_ONION_API.Controllers
{
    public class ColaboradoresController : ControllerBase
    {
        private readonly ICustomService<Colaboradores> _customService;
        private readonly ApplicationDbContext _applicationDbContext;

        public ColaboradoresController(ICustomService<Colaboradores> customService, ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            _customService = customService;
        }

        [HttpGet(nameof(ObterPorId))]
        public IActionResult ObterPorId(int Id)
        {
            var obj = _customService.Get(Id);
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(obj);
            }
        }
        [HttpGet(nameof(Obter))]
        public IActionResult Obter()
        {
            var obj = _customService.GetAll();
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(obj);
            }
        }

        [HttpPost(nameof(Criar))]
        public IActionResult Criar(Colaboradores colaboradores)
        {
            if (colaboradores != null)
            {
                _customService.Insert(colaboradores);
                return Ok("Colaborador inserido na base de dados");
            }
            else
            {
                return BadRequest("Erro ao criar novo colaborador");
            }
        }

        [HttpPut(nameof(Atualizar))]
        public IActionResult Atualizar(Colaboradores colaboradores)
        {
            if (colaboradores != null)
            {
                _customService.Update(colaboradores);
                return Ok("Dados do colaborador atualizado");
            }
            else
            {
                return BadRequest();
            }

        }

        [HttpDelete(nameof(Delete))]
        public IActionResult Delete(int id)
        {
            var colaborador = _applicationDbContext.Colaborador.FirstOrDefault(x => x.Codigo == id);
            if (colaborador == null)
            {
                return NotFound();
            }

            _applicationDbContext.Colaborador.Remove(colaborador);
            _applicationDbContext.SaveChanges();
            return Ok("Colaborador removido da base de dados");

        }
    }
}
