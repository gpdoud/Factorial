using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial {
	class Program {
		int Factorial(int nbr) {
			var factorial = 1;
			for(var idx = 2; idx <= nbr; idx++) {
				factorial *= idx;
			}
			return factorial;
		}
		void Run() {
			for (var nbr = 2; nbr <= 10; nbr++) {
				Console.WriteLine($"The factorial of {nbr} is {Factorial(nbr)}");
			}
		}
		static void Main(string[] args) {
			new Program().Run();
		}
	}
}
