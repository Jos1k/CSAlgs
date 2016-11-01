using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorting.Algorithms;

namespace Sorting {

	class Program {
		static void Main( string[] args ) {

			int[] inputArray = new int[] { 1, 5, 8, 3, 3, 6, 9, 10, 4, 8, 2 };
			Console.WriteLine("Initial array: {0} \n- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n", 
				inputArray.ArrayToString()
			);

			Console.WriteLine( "Inserting sorting: {0} \n", InsertingSorting .Sort( inputArray ).ArrayToString());
			Console.WriteLine( "Shell sorting: {0} \n", ShellSorting.Sort( inputArray ).ArrayToString() );
			
			Console.ReadKey();
		}
	}
}
