using BeinHazmanimFinderAPI.Repositorys;
using Microsoft.AspNetCore.Mvc;

namespace BeinHazmanimFinderAPI.Controllers;



[ApiController]
[Route("/api/[controller]")]
public class AccommodationController : ControllerBase
{
    private readonly IAccommodation _accommodationRepo;
    private readonly Iservies _servies;

    public AccommodationController(IAccommodation accommodationRepo, Iservies servies)
    {
        _accommodationRepo = accommodationRepo;
        _servies = servies;
    }


    [HttpGet]
    public async Task<ActionResult<IEnumerable<Accommodation>>> GetAllAsync()
    {
        var accommodations = await _accommodationRepo.GetAccommodationsAsync();
        return Ok(accommodations);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Accommodation>> GetById(int id)
    {
        var accommodation = await _accommodationRepo.GetByIdAsync(id);
        if (accommodation == null) return NotFound();
        return Ok(accommodation);
    }

    [HttpPost]
    public async Task<ActionResult> CreateAccommdationAsync(Accommodation accommodation)
    {
        await _accommodationRepo.CreateAsync(accommodation);
        return CreatedAtAction(nameof(GetById),new { id = accommodation.Id } , accommodation);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAccommdationAsync(int id, Accommodation accommodation)
    {
        bool isUpdate = await _accommodationRepo.UpdateAsync(id, accommodation);
        if (isUpdate == false) return NotFound();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAccommdationAsync(int id)
    {
        bool isDeleted = await _accommodationRepo.DeleteAsync(id);
        if (isDeleted == false) return NotFound();
        return NoContent();
    }

    //[HttpGet("search/{city}{maxPrice}{accessible}")]

    //public async Task<ActionResult<IEnumerable<Accommodation>>> GetByMaxPriceCityAccessibleAsync([FromQuery] string? city = null, [FromQuery] int? maxPrice = null, [FromQuery] bool? accessible = null)
    //{
        
        
    //}

}
