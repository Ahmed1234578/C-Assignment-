using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Attendee
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(150)]
    public string FullName { get; set; }

    [Required, MaxLength(200)]
    public string Email { get; set; }

    
    public Address Address { get; set; }

    
    [NotMapped]
    public string FullAddress => $"{Address?.Street}, {Address?.City}, {Address?.Country}, {Address?.PostalCode}";

    
    public Badge Badge { get; set; }
}