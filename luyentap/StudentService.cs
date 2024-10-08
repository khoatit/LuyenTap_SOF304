using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luyentap
{
	public class StudentService
	{
		private List<Student> _students = new List<Student>();
		//Thêm SV
		public void AddSV(Student student)
		{
			if (student == null)
			{
				throw new ArgumentNullException(nameof(student), "Không thể là null");
			}

			if (_students.Any(s => s.Id == student.Id))
			{
				throw new ArgumentException("ID đã tồn tại");
			}

			_students.Add(student);
		}
		// Tìm kiếm sinh viên theo mã sinh viên
		public Student TimSV(string maSV)
		{
			return _students.FirstOrDefault(s => s.MaSV.Equals(maSV, StringComparison.OrdinalIgnoreCase));
		}
	}
}
