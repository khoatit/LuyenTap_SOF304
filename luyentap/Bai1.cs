using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luyentap
{
	public class Bai1
	{
		public static (double? x1, double? x2) Solve(double a, double b, double c)
		{
			double delta = b * b - 4 * a * c;

			if (delta > 0)
			{
				double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
				double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
				return (x1, x2);
			}
			else if (delta == 0)
			{
				double x = -b / (2 * a);
				return (x, x);
			}
			else
			{
				return (null, null); // Vô nghiệm
			}
		}
	}
}
