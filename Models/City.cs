using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace CommunityApp.Models;

public class City
{
    [Key]
    [Required]
    public int CityId {get; set;}
    public string? CityName {get; set;}
    public int Population {get; set;}
    [ForeignKey("ProvinceCode")]
    public string? ProvinceCode {get; set;}
    // Navigation property based off of foreign key
    public Province? Province {get; set;}
}
