using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApiPanelAdminRapor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SonIslemlerController : ControllerBase
    {
        private readonly PanelappContext _context;
        public SonIslemlerController(PanelappContext context)
        {
            _context = context;
        }
        [HttpGet("latest-login")]
        public async Task<IActionResult> GetLatestLogin()
        {
            string query = "SELECT * FROM \"BizimLoglar\" ORDER BY \"LogTarihi\" DESC LIMIT 1";
            var result = await _context.BizimLoglars.FromSqlRaw(query).FirstOrDefaultAsync();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

    }
}
