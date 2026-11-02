using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Owned]
public class Address
{
    [Required, MaxLength(150)]
    public string Street { get; set; }

    [Required, MaxLength(100)]
    public string City { get; set; }

    [Required, MaxLength(100)]
    public string Country { get; set; }

    [Required, MaxLength(20)]
    [Column("ZipCode")]
    public string PostalCode { get; set; }
}