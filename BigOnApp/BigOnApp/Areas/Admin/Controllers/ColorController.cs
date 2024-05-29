using BigOnApp.DAL.context;
using BigOnApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BigOnApp.Areas.Admin.Controllers;
[Area("Admin")]
public class ColorController : Controller
{
    private readonly AppDbContext _context;

    public ColorController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var colors = _context.Colors.ToList();
        return View(colors);
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(Color color)
    {
        color.CreatedBy = 1;
        color.CreatedAt = DateTime.UtcNow.AddHours(4);
        _context.Colors.Add(color);
        await _context.SaveChangesAsync();
        return RedirectToAction("Index");
    }
}
