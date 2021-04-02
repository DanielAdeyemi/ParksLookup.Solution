using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using ParksLookup.Models;

namespace ParksLookup.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private readonly ParksLookupContext _db;
    public ParksController(ParksLookupContext db)
    {
      _db = db;
    }

    // GET api/parks
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get()
    {
      var query = _db.Parks.AsQueryable();
      // if(ParkId != 0)
      // {
      //   query = query.Where(park => park.ParkId == ParkId);
      // }
      return await query.ToListAsync();
    }

    // GET: api/parks/1
    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetPark(int id)
    {
      var park = await _db.Parks.FindAsync(id);
      if(park == null)
      {
        return NotFound();
      }
      return park;
    }
  }
}