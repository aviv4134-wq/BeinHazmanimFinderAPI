using BeinHazmanimFinderAPI.Repositorys;
using Microsoft.AspNetCore.Mvc;

namespace BeinHazmanimFinderAPI.Controllers;



[ApiController]
[Route("/api/[controller]")]
public class ActivityPlaceController : ControllerBase
{
    private readonly IActivityPlace _activityPlaceRepo;

    public ActivityPlaceController(IActivityPlace activityPlaceRepo)
    {
        _activityPlaceRepo = activityPlaceRepo;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ActivityPlace>>> GetAllAsync()
    {
        var activityPlaces = await _activityPlaceRepo.GetActivityPlaceAsync();
        return Ok(activityPlaces);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ActivityPlace>> GetById(int id)
    {
        var activityPlace = await _activityPlaceRepo.GetByIdAsync(id);
        if (activityPlace == null) return NotFound();
        return Ok(activityPlace);
    }

    [HttpPost]
    public async Task<ActionResult> CreateActivityPlaceAsync(ActivityPlace activityPlace)
    {
        await _activityPlaceRepo.CreateAsync(activityPlace);
        return CreatedAtAction(nameof(GetById), new { id = activityPlace.Id }, activityPlace);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateActivityPlaceAsync(int id, ActivityPlace activityPlace)
    {
        bool isUpdated = await _activityPlaceRepo.UpdateAsync(id, activityPlace);
        if (isUpdated == false) return NotFound();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteActivityPlaceAsync(int id)
    {
        bool isDeleted = await _activityPlaceRepo.DeleteAsync(id);
        if (isDeleted == false) return NotFound();
        return NoContent();
    }



}
