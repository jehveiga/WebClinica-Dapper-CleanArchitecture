using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using WebClinica.Application.Business;
using WebClinica.Application.Dtos.InputModels;
using WebClinica.Application.Dtos.ViewModels;

namespace WebClinica.Api.Controllers
{
    [ApiController]
    [Route("api/medicos")]
    public class MedicosController(IMedicoBusiness medicoBusiness) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MedicoViewModel>>> Get()
        {
            IEnumerable<MedicoViewModel> medicosDto = await medicoBusiness.Obter();

            return Ok(medicosDto);
        }

        [HttpGet("{crm:int}")]
        public async Task<ActionResult<MedicoViewModel>> GetByCrm([Required] int crm)
        {
            MedicoViewModel medicoDto = await medicoBusiness.ObterPeloCrm(crm);

            if (medicoDto is null)
                return NotFound();

            return Ok(medicoDto);
        }

        [HttpPost]
        public async Task<ActionResult> Post(CreateMedicoInputModel createMedicoInput)
        {
            CreatedMedicoViewModel createdResult = await medicoBusiness.Adicionar(createMedicoInput);

            if (createdResult is null)
                return BadRequest();

            return CreatedAtAction(nameof(Get), new { createdResult.Crm }, createdResult);
        }

        [HttpPut("{crm:int}")]
        public async Task<ActionResult> Put([Required] int crm, UpdateMedicoInputModel updateMedicoInput)
        {
            int updateResult = await medicoBusiness.Alterar(crm, updateMedicoInput);

            if (updateResult == 0)
                return NotFound();

            return Ok();
        }

        [HttpDelete("{crm:int}")]
        public async Task<ActionResult> Delete([Required] int crm)
        {
            int deleteResult = await medicoBusiness.Delete(crm);

            if (deleteResult == 0)
                return NotFound();

            return Ok();
        }
    }
}