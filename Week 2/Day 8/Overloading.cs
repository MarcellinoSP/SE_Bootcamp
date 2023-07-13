namespace OperatorOverloading;

public class FractionOperator
{
	private float _numerator {get; set;}
	private float _denominator {get; set;}
	
	public FractionOperator(float numerator, float denominator)
	{
		_numerator = numerator;
		_denominator = denominator;
	}
	
	public static FractionOperator operator * (FractionOperator f1, FractionOperator f2)
	{
		float tempNumerator = (f1._numerator * f2._numerator);
		float tempDenominator = (f1._denominator * f2._denominator);
		
		return new FractionOperator(tempNumerator, tempDenominator);
	}
	
	public static FractionOperator Division(FractionOperator f1, FractionOperator f2)
	{
		float tempNumerator = (f1._numerator) / (f2._numerator);
		float tempDenominator = (f1._denominator) / (f2._denominator);
		
		return new FractionOperator(tempNumerator, tempDenominator);
	}

	public override string ToString()
	{
		return $"{_numerator}/{_denominator}";
	}
}

public class DotVector3x3
{
	private int _vectorMember1;
	private int _vectorMember2;
	private int _vectorMember3;
	public int result;
	
	public DotVector3x3(int vectorMember1, int vectorMember2, int vectorMember3)
	{
		_vectorMember1 = vectorMember1;
		_vectorMember2 = vectorMember2;
		_vectorMember3 = vectorMember3;
	}
	public DotVector3x3(int result)
	{
		this.result = result;
	}
	
	public static DotVector3x3 operator + (DotVector3x3 vector1, DotVector3x3 vector2)
	{
		int tempVectorMember1 = vector1._vectorMember1 * vector2._vectorMember1;
		int tempVectorMember2 = vector1._vectorMember2 * vector2._vectorMember2;
		int tempVectorMember3 = vector1._vectorMember3 * vector2._vectorMember3;
		int tempFinalResult = tempVectorMember1 + tempVectorMember2 + tempVectorMember3;
		return new DotVector3x3(tempFinalResult);
	}
}