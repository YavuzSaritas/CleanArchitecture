using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("product")]
public class Product : BaseEntity
{
    [Column("name")]
    public string Name { get; set; }
    [Column("color")]
    public string Color { get; set; }
}