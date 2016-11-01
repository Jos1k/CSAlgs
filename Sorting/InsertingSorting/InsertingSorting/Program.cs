using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertingSorting {
	class Program {
		static void Main( string[] args ) {
			int[] inputArray = new int[] { 1, 5, 8, 3, 3, 6, 9, 10, 4, 8, 2 };
			Console.WriteLine( "Input array: {0}", inputArray.ArrayToString() );
			Console.WriteLine( "Sorted array classic: {0}", InsertingSorting.Sort( inputArray ).ArrayToString() );
			inputArray = new int[] { 1, 5, 8, 3, 3, 6, 9, 10, 4, 8, 2 };
			Console.WriteLine( "Sorted array recursi: {0}", InsertingSorting.SortRecursive( inputArray ).ArrayToString() );


			Console.WriteLine( "-----------------------------------" );

			inputArray = new int[] { 2, 4, 8, 3, 5, 6, 8, 10, 4, 8, 1 };
			Console.WriteLine( "Input array: {0}", inputArray.ArrayToString() );
			Console.WriteLine( "Sorted array: {0}", InsertingSorting.Sort( inputArray ).ArrayToString() );
			inputArray = new int[] { 2, 4, 8, 3, 5, 6, 8, 10, 4, 8, 1 };
			Console.WriteLine( "Sorted array recursive: {0}", InsertingSorting.SortRecursive( inputArray ).ArrayToString() );

			Console.ReadKey();
		}
	}
}
