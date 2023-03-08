using Microsoft.AspNetCore.Mvc;
using Pharma.Application.Common.Interfaces;
using Pharma.Domain.Models;

namespace Pharma.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicamentController : ControllerBase
    {
        private readonly IMedicamentService _medicamentService;

        public MedicamentController(IMedicamentService medicamentService)
        {
            _medicamentService = medicamentService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(ulong id)
        {
            var entity = _medicamentService.Get(id);
            return Ok(entity);
        }

        [HttpPost]
        public IActionResult Post(Medicament medicament)
        {
            var entity = _medicamentService.Create(medicament);
            return Ok(entity);
        }

        [HttpPut("{id}")]
        public IActionResult Put(Medicament medicament, ulong id)
        {
            var entity = _medicamentService.Update(medicament, id);
            return Ok(entity);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(ulong id)
        {
            var entity = _medicamentService.Delete(id);
            return Ok(entity);
        }
    }
}
