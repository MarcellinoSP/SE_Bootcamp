using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTrial;

public class Piece
{
	[Key]
	public string? PieceID {get; set;}
	
	[Column (TypeName = "Type")]
	public string? PieceType {get; set;}
	
	public int PlayerID {get; set;}
	
	public virtual Player Players {get; set;}

}