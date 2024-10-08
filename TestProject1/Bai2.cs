using luyentap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
	[TestFixture]
	public class Bai2
	{
		private StudentService ser;
		[SetUp]
		public void SetUp()
		{
			ser = new StudentService();
		}
		[Test]
		public void Add1()
		{
			var student = new Student(1, "Bui Duc Khoat", 20, "SV001", "khoat@fpt.edu.vn", "A description");
			ser.AddSV(student);
			var result = ser.TimSV("SV001");
			Assert.IsNotNull(result);
			Assert.AreEqual("Bui Duc Khoat", result.Name);
		}
		[Test]
		public void Add2()
		{
			var student1 = new Student(1, "Bui Duc Khoat", 20, "SV001", "khoat@fpt.edu.vn", "A description");
			var student2 = new Student(1, "Tùng", 21, "SV002", "tung@fpt.edu.vn", "Khac");
			ser.AddSV(student1);
			var ex = Assert.Throws<ArgumentException>(() => ser.AddSV(student2));
			Assert.AreEqual("ID đã tồn tại", ex.Message);
		}
		[Test]
		public void Add3()
		{
			var ex = Assert.Throws<ArgumentNullException>(() => ser.AddSV(null));
			Assert.AreEqual("Không thể là null", ex.Message);
		}
		[Test]
		public void TimSV1()
		{
			var result = ser.TimSV("");
			Assert.IsNull(result);
		}
		[Test]
		public void TimSV2()
		{
			var student = new Student(1, "Bui Duc Khoat", 20, "SV001", "khoat@fpt.edu.vn", "A description");
			ser.AddSV(student);

			// Act
			var result = ser.TimSV("SV002");

			// Assert
			Assert.IsNull(result);
		}
		[Test]
		public void TimSV3()
		{
			var student = new Student(1, "Bui Duc Khoat", 20, "SV001", "khoat@fpt.edu.vn", "A description");
			ser.AddSV(student);
			var result = ser.TimSV("SV001");
			Assert.IsNotNull(result);
			Assert.AreEqual("Bui Duc Khoat", result.Name);
		}

	}
}
