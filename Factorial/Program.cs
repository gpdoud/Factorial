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
		bool IsDivisibleByThree(int nbr) {
			var a = 1;
			var b = 0 ;
			var c = a / b;
			return (nbr % 3 == 0);
		}
		void Run() {
			//for (var nbr = 2; nbr <= 10; nbr++) {
			//	Console.WriteLine($"The factorial of {nbr} is {Factorial(nbr)}");
			//}
			for(var idx = 0; idx <= 100; idx++ ) {
				if (IsDivisibleByThree(idx)) {
					Console.WriteLine($"{idx} is divisible by 3");
				}
			}
		}
		static void Main(string[] args) {
			try {
				new Program().Run();
			} catch (DivideByZeroException ex) {
				Console.WriteLine("Caught exception in Main()");
				return;
			}
		}
	}
}
