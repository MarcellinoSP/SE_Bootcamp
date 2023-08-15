using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTrial;

public class Player
{
	[Key]		//No need to assign if you want it to automatically assigned by EF
	public int PlayerID {get; set;}
	
	[Column (TypeName = "NAME")]
	[StringLength(15)]
	public string PlayerName {get; set;} = null!;
	
	[Column (TypeName = "COLOR")]
	public string? PlayerColor {get; set;}
	
	public virtual ICollection<Piece> Piece {get; set;}
	
	public Player()
	{
		Piece = new HashSet <Piece>();
	}
}