using CarsWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarsWebAPI.Controllers;
[ApiController]
[Route("[controller]")]
public class CarsController : ControllerBase
{
     private readonly SampleDBContext _context;
     public CarsController(SampleDBContext context)
      {
         _context = context;
      }
     [HttpGet]
     public async Task<ActionResult<IEnumerable<Car>>> GetTodoItems()
     {
          return await _context.Cars.Take(5).ToListAsync();
  }

    
}