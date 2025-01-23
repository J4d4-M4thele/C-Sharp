using System.ComponentModel.DataAnnotations;//for [Required] and [StringLength]

namespace Northwind.EntityModels;

public class Customer
{
    public int CustomerId { get; set; }
    [Required]
    [StringLength(40)]
    public string CompanyName { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
}

