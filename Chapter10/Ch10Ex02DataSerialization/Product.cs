using System.ComponentModel.DataAnnotations; //for [Required]
using System.ComponentModel.DataAnnotations.Schema; //for [Column]

namespace Packt.Shared;

public class Product
{
    public int ProductId { get; set; }

    [Required]
    [StringLength(40)]
    public string ProductName { get; set; } = null!;

    [Column("UnitPrice", TypeName = "money")]
    public decimal? Cost { get; set; }

    [Column("UnitsInStock", TypeName = "money")]
    public short? Stock { get; set;}

    public bool Discontinued { get; set; }

    //foreign key relationship
    public int CategoryId { get; set; }

    public virtual Category Category { get; set; } = null!;
}
