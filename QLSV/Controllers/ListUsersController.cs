using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QLSV.Models;

namespace QLSV.Controllers;

public class ListUsersController : Controller
{

    private readonly DormDbContext _context;

    public ListUsersController(DormDbContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        var model = _context.Users.ToList();
        return View(model);
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
        return Ok("Add user thành công");
    }
    public IActionResult Details(int id)
    {
        var model = _context.Users.Where(i => i.Id == id).Include(x => x.RelativeUsers).FirstOrDefault();
        return View(model);
    }
    public IActionResult Delete(int id)
    {
        var user = _context.Users.Where(i => i.Id == id).FirstOrDefault();
        _context.Users.Remove(user);
        _context.SaveChanges();
        return Ok("Delete user thành công");
    }
    
}


