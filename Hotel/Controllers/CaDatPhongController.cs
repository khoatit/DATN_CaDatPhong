using Data;
using Hotel.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hotel.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CaDatPhongController : ControllerBase
	{
		//private readonly AppDbContext _dbcontext;
  //      public CaDatPhongController(AppDbContext dbContext)
  //      {
  //          dbContext = _dbcontext;
  //      }
		//// GET: CaDatPhong
		//public async Task<IActionResult> Index()
		//{
		//	var caDatPhongs = await _dbcontext.caDatPhongs.ToListAsync();
		//	return View(caDatPhongs);  // Trả về danh sách ca đặt phòng để hiển thị trên view
		//}

		//private IActionResult View(object caDatPhongs)
		//{
		//	throw new NotImplementedException();
		//}

		//// GET: CaDatPhong/Edit/5
		//public async Task<IActionResult> Edit(int? id)
		//{
		//	if (id == null)
		//	{
		//		return NotFound();
		//	}

		//	var caDatPhong = await _dbcontext.caDatPhongs.FindAsync(id);
		//	if (caDatPhong == null)
		//	{
		//		return NotFound();
		//	}
		//	return View(caDatPhong);
		//}

		//// POST: CaDatPhong/Edit/5
		//[HttpPost]
		//[ValidateAntiForgeryToken]
		//public async Task<IActionResult> Edit(int id, [Bind("Id,GioCheckIn,GioCheckOut,GhiChu")] CaDatPhong caDatPhong)
		//{
		//	if (id != caDatPhong.Id)
		//	{
		//		return NotFound();
		//	}

		//	if (ModelState.IsValid)
		//	{
		//		try
		//		{
		//			_dbcontext.Update(caDatPhong);
		//			await _dbcontext.SaveChangesAsync();
		//		}
		//		catch (DbUpdateConcurrencyException)
		//		{
		//			if (!CaDatPhongExists(caDatPhong.Id))
		//			{
		//				return NotFound();
		//			}
		//			else
		//			{
		//				throw;
		//			}
		//		}
		//		return RedirectToAction(nameof(Index));
		//	}
		//	return View(caDatPhong);
		//}

		//private bool CaDatPhongExists(int id)
		//{
		//	return _dbcontext.caDatPhongs.Any(e => e.Id == id);
		//}

	}
}
