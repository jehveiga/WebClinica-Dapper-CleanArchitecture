using Microsoft.AspNetCore.Mvc;
using WebClinica.Application.Business;
using WebClinica.Application.Dtos.InputModels;
using WebClinica.Application.Dtos.ViewModels;

namespace WebClinica.Api.Controllers
{
    [Route("api/medicos")]
    [ApiController]
    public class MedicosController(IMedicoBusiness medicoBusiness) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MedicoViewModel>>> Get()
        {
            IEnumerable<MedicoViewModel> medicosDto = await medicoBusiness.Obter();

            return Ok(medicosDto);
        }

        [HttpGet("{crm:int}")]
        public async Task<ActionResult<MedicoViewModel>> GetByCrm(int crm)
        {
            MedicoViewModel medicoDto = await medicoBusiness.ObterPeloCrm(crm);

            if (medicoDto is null)
                return NotFound();

            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> Post(CreateMedicoInputModel createMedicoInput)
        {
            CreatedMedicoViewModel createdResult = await medicoBusiness.Adicionar(createMedicoInput);

            if (createdResult is null)
                return BadRequest();

            return CreatedAtAction(nameof(Get), new { createdResult.Crm }, createdResult);
        }
    }
}
