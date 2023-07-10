namespace FooBarProgram;

public class FooBar
{
	private string _stringA;
	private string _stringB;
	private int _fooPos;
	private int _barPos;
	private int _number;
	public FooBar(string stringFoo, string stringBar, int fooPos, int barPos, int number)
	{
		Console.WriteLine("Creating FooBar");
		_stringA = stringFoo;
		_stringB = stringBar;
		_fooPos = fooPos;
		_barPos = barPos;
		_number = number;
	}
	
	public void getFooBar()
	{
		for(int i = 0; i <= _number; i++){
			if(i == 0){
				Console.Write(i + " ");
			}else if(i % _fooPos == 0 && i % _barPos == 0){
				Console.Write(_stringA + _stringB);
			}else if(i % _fooPos == 0){
				Console.Write(_stringA);
			}else if(i % _barPos == 0){
				Console.Write(_stringB);
			}else{
				Console.Write(i + " ");
			}
		}
	}
}