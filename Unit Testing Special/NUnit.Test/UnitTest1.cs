using NUnit.Framework;
namespace NUnit.Test;

public class Tests
{
	public class TrialUnitTest
	{
		[SetUp]
		public void Setup()
		{
			trialTesting = new NUnitResources();
		}

		[Test]
		public void Test1()
		{
			Assert.Pass();
		}
	}
}