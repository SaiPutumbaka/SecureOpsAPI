using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SecureOpsAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RecordsController : ControllerBase
{
    private readonly AppDbContext _context;

    public RecordsController(AppDbContext context)
    {
        _context = context;
    }

    // This handles GET requests (Reading data)
    [HttpGet]
    public async Task<ActionResult<IEnumerable<OperationalRecord>>> GetRecords()
    {
        return await _context.Records.ToListAsync();
    }

    // This handles POST requests (Creating data) with strict error handling
    [HttpPost]
    public async Task<ActionResult<OperationalRecord>> CreateRecord(OperationalRecord record)
    {
        try 
        {
            _context.Records.Add(record);
            await _context.SaveChangesAsync();
            return Ok(record);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
}