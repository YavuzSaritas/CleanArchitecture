using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class BaseEntity
{
    [Column("id")]
    public int Id { get; set; }
}