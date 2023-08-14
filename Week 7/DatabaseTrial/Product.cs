using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTrial;

public class Product
{
	[Key]
	public int productID {get; set;}
	
	[Required]
	[StringLength(40)]
	public string productName {get; set;} = null!;
	
	[Column("UnitPrice", TypeName = "money")]
	public decimal? Cost { get; set; }

	[Column("UnitsInStock")]
	public short? Stock { get; set; }

	public bool Discontinued { get; set; }

	public int CategoryId { get; set; }
	public virtual Category Category { get; set; } = null!;
}