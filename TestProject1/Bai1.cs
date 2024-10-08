using luyentap;

namespace TestProject1
{
	[TestFixture]
	public class Test_PTBac2
	{
		[Test]
		public void Test1()
		{
			// Trường hợp có hai nghiệm phân biệt: a = 1, b = -3, c = 2 (x1 = 2, x2 = 1)
			var result = Bai1.Solve(1, -3, 2);
			Assert.AreEqual(2, result.x1);
			Assert.AreEqual(1, result.x2);
		}
		[Test]
		public void Test2()
		{
			// Trường hợp có một nghiệm kép: a = 1, b = -2, c = 1 (x1 = x2 = 1)
			var result = Bai1.Solve(1, -2, 1);
			Assert.AreEqual(1, result.x1);
			Assert.AreEqual(1, result.x2);
		}

		[Test]
		public void Test3()
		{
			// Trường hợp vô nghiệm: a = 1, b = 0, c = 1 (vô nghiệm)
			var result = Bai1.Solve(1, 0, 1);
			Assert.IsNull(result.x1);
			Assert.IsNull(result.x2);
		}

		[Test]
		public void Test4()
		{
			// Biên delta = 0: a = 1, b = 2, c = 1 (x1 = x2 = -1)
			var result = Bai1.Solve(1, 2, 1);
			Assert.AreEqual(-1, result.x1);
			Assert.AreEqual(-1, result.x2);
		}

		[Test]
		public void Test5()
		{
			// Biên delta > 0 nhưng gần 0: a = 1, b = 1, c = 0 (x1 = 0, x2 = -1)
			var result = Bai1.Solve(1, 1, 0);
			Assert.AreEqual(0, result.x1);
			Assert.AreEqual(-1, result.x2);
		}
	}
}