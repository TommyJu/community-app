using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;

namespace CommunityApp.Models;

public class Province
{
    [Key]
    [Required]
    public string? ProvinceCode {get; set;}
    public string? ProvinceName {get; set;}
    public Collection<City>? Cities {get; set;}
}
