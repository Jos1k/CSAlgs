using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Algorithms {

	public class InsertingSort {

		public static int[] Sort( int[] inputArray ) {
			if (inputArray.Length < 2){
				return inputArray;
			}

			int[] sortedArray = (int[])inputArray.Clone();

			for( int i = 1; i < sortedArray.Length; i++ ) {
				for( int j=i; j > 0 && sortedArray[j] < sortedArray[j-1]; j-- ){
					Extensions.SwapElements( sortedArray, j, j - 1 );
				}
			}
			return sortedArray;
		}
	}
}
