using System.ComponentModel.DataAnnotations.Schema; //for [Column]

namespace Northwind.EntityModels;

public class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    [Column(TypeName = "ntext")]
    public string? Description { get; set; }

    //defines a navigation property for related rows
    public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
}
