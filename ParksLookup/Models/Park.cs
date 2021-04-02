using System.ComponentModel.DataAnnotations;

namespace ParksLookup.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    [Required]
    [StringLength(100)]
    public string ParkName { get; set; }
    [Required]
    public string ParkLocation { get; set; }
    [Required]
    public bool National { get; set; }
    [Required]
    public bool Local { get; set; }
  }
}