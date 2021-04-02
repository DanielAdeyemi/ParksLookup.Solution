using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
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

    // GET api/parks, api/parks/?location=portland%2C%20or
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get(string ParkName, string Location, bool National, bool Local)
    {
      var query = _db.Parks.AsQueryable();
      if(ParkName != null)
      {
        query = query.Where(park => park.ParkName == ParkName);
      }
      if(Location != null)
      {
        query = query.Where(park => park.ParkLocation == Location);
      }
      if(National)
      {
        query = query.Where(park => park.National == true);
      }
      if(Local)
      {
        query = query.Where(park => park.Local == true);
      }
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

    // POST api/parks
    [HttpPost]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();
      return CreatedAtAction("Post", new { id = park.ParkId}, park);
    }

    // PUT api/parks/4
    [HttpPut("{id}")]
    public async Task<ActionResult<Park>> Put(int id, Park park)
    {
      if(id != park.ParkId)
      {
        return BadRequest();
      }
      _db.Entry(park).State = EntityState.Modified;
      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ParkExists(id))
        {
          return NotFound();
        }
        throw;
      }
      return NoContent();
    }

    // DELETE api/parks/3
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePark(int id)
    {
      var park = await _db.Parks.FindAsync(id);
      if(park == null)
      {
        return NotFound();
      }
      _db.Parks.Remove(park);
      await _db.SaveChangesAsync();
      return NoContent();
    }

    private bool ParkExists(int id)
    {
      return _db.Parks.Any(park =>park.ParkId == id);
    }
  }
}