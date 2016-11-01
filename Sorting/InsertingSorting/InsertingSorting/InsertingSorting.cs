using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertingSorting {
	public static class InsertingSorting {

		public static int[] Sort( int[] inputArray ) {
			if (inputArray.Length < 2){
				return inputArray;
			}

			for( int i = 1; i < inputArray.Length;i++ ) {
				if( inputArray[i] >= inputArray[i-1] ) {
					continue;
				}
				int valueToSort = inputArray[i];
				int xIndex = i-1;
				while( xIndex >= 0 && valueToSort <= inputArray[xIndex] ) {
					inputArray[xIndex + 1] = inputArray[xIndex];
					xIndex--;
				}
				inputArray[xIndex+1] = valueToSort;
			}
			return inputArray;
		}

		public static int[] SortRecursive( int[] inputArray ) {
			return InsertingSortRecursive( inputArray, 1 );
		}

		private static int[] InsertingSortRecursive(int[] inputArray, int pointer ){
			if (pointer == inputArray.Length){
				return inputArray;
			}
			if (inputArray[pointer] > inputArray[pointer - 1]){
				return InsertingSortRecursive( inputArray, ++pointer );
			}
			int sortedValue = inputArray[pointer];
			int lastIndex = pointer - 1;

			while( lastIndex >= 0 && sortedValue <= inputArray[lastIndex] ) {
				inputArray[lastIndex + 1] = inputArray[lastIndex];
				lastIndex--;
			}
			inputArray[lastIndex + 1] = sortedValue;
			return InsertingSortRecursive( inputArray, ++pointer );
		}
	}
}
