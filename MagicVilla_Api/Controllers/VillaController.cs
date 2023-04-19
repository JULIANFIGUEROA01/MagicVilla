using MagicVilla_Api.Data;
using MagicVilla_Api.Models;
using MagicVilla_Api.Models.ModelsDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<VillaDto>> GetVillas() {
            return Ok(VillaStore.villaList);
        }

        [HttpGet("id")]   
        public ActionResult<VillaDto> GetVilla(int id)
        {
            if (id == 0) 
            {
                return BadRequest();
            }
            var villa = VillaStore.villaList.FirstOrDefault(x => x.Id == id);
            if (villa == null)
            {
                return NotFound();
            }
            return Ok(villa);
        }
    }
}
