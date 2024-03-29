using System.ComponentModel.DataAnnotations;

namespace BulkyBooksWeb.Models;
public class Category
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public int DisplayOrder { get; set; }
    public DateTime createdAt { get; set; } = DateTime.Now;
}