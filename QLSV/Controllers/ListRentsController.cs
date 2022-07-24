using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QLSV.Models;

namespace QLSV.Controllers;

public class ListRentsController : Controller
{

    private readonly DormDbContext _context;

    public ListRentsController(DormDbContext context)
    {
        _context = context;
    }
    public IActionResult History()
    {
        var model = _context.Rents.ToList();
        return View(model);
    }
}   
