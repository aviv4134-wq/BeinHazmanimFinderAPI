using BeinHazmanimFinderAPI.enums;
using System.ComponentModel.DataAnnotations;

namespace BeinHazmanimFinderAPI;

public class Accommodation
{
    [Required]
    public int Id { get; set; }

    [Required]
    [StringLength(70)]

    public string Name { get; set; } = string.Empty; 

    [Required]
    [EnumDataType(typeof(AccommodationTypes))]
    [StringLength(30)]
    public string AccommodationType { get; set; } = string.Empty;

    [Required]
    [StringLength(40)]
    public string City { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    public string Area { get; set; } = string.Empty;

    [Required]
    [EnumDataType(typeof(KashrutAuthorities))]
    [StringLength(50)]
    public string KashrutAuthority { get; set; } = string.Empty;

    [Required]
    [Range(0,10000)]
    public decimal PricePerNight { get; set; }

    [Required]
    [Range(1,500)]

    public int MaximumGuests { get; set; }

    [Required]

    public DateTime AvailableFrom { get; set; }

    [Required]

    public bool IsAccessible { get; set; } = false;

    [Required]

    public bool IsAbroad { get; set; } = false;

}
