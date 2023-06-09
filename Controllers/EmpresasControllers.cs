using CRUD_ONION_API.Domain.Data;
using CRUD_ONION_API.Domain.Models;
using CRUD_ONION_API.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_ONION_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmpresasControllers : ControllerBase
    {
        private readonly ICustomService<Empresas> _customService;
        private readonly ApplicationDbContext _applicationDbContext;

        public EmpresasControllers(ICustomService<Empresas> customService, ApplicationDbContext applicationDbContext)
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
        public IActionResult Criar(Empresas empresa)
        {
            if (empresa != null)
            {
                _customService.Insert(empresa);
                return Ok("Empresa inserida na base de dados");
            }
            else
            {
                return BadRequest("Erro ao inserir empresa");
            }
        }

        [HttpPut(nameof(Atualizar))]
        public IActionResult Atualizar(Empresas empresa)
        {
            if (empresa != null)
            {
                _customService.Update(empresa);
                return Ok("Dados da empresa atualizado");
            }
            else
            {
                return BadRequest();
            }

        }

        [HttpDelete(nameof(Delete))]
        public IActionResult Delete(int id)
        {
            var empresa = _applicationDbContext.Empresa.FirstOrDefault(x => x.Codigo == id);
            if (empresa == null)
            {
                return NotFound();
            }

            _applicationDbContext.Empresa.Remove(empresa);
            _applicationDbContext.SaveChanges();
            return Ok("Emepresa removida da base de dados");

        }
    }
}
