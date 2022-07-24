using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QLSV.Models;

namespace QLSV.Controllers;

public class ListRelativesController : Controller
{

    private readonly DormDbContext _context;

    public ListRelativesController(DormDbContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        var model = _context.Rents.ToList();
        return View(model);
    }
}   
