using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luyentap
{
	public class Student
	{
		public Student(int id, string name, int age, string maSV, string mail, string description)
		{
			Id = id;
			Name = name;
			Age = age;
			MaSV = maSV;
			Mail = mail;
			Description = description;
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public string MaSV { get; set; }
		public string Mail { get; set; }
		public string Description { get; set; }
	}
}
