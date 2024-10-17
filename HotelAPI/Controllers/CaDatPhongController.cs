using Data;
using Hotel.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CaDatPhongController : ControllerBase
	{
		private readonly AppDbContext _db;
        public CaDatPhongController(AppDbContext db)
        {
            db = _db;
        }
		// GET: api/CaDatPhong
		[HttpGet("Get-All")]
		public async Task<ActionResult<IEnumerable<CaDatPhong>>> GetCaDatPhongs()
		{
			return await _db.caDatPhongs.ToListAsync();
		}

		// GET: api/CaDatPhong/5
		[HttpGet("Get-by-id")]
		public async Task<ActionResult<CaDatPhong>> GetCaDatPhong(int id)
		{
			var caDatPhong = await _db.caDatPhongs.FindAsync(id);

			if (caDatPhong == null)
			{
				return NotFound();
			}

			return caDatPhong;
		}

		// PUT: api/CaDatPhong/5
		[HttpPut("Update-CaDatPhong")]
		public async Task<IActionResult> PutCaDatPhong(int id, CaDatPhong caDatPhong)
		{
			if (id != caDatPhong.Id)
			{
				return BadRequest();
			}

			_db.Entry(caDatPhong).State = EntityState.Modified;

			try
			{
				await _db.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!CaDatPhongExists(id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}

			return NoContent();
		}

		private bool CaDatPhongExists(int id)
		{
			return _db.caDatPhongs.Any(e => e.Id == id);
		}
	}
}
