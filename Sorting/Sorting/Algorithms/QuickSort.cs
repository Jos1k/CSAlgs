namespace Sorting.Algorithms {
	public class QuickSort {
		public static int[] Sort( int[] inputArray ) {
			int[] sortedArray = (int[])inputArray.Clone();
			return QuickSortRecursive( sortedArray, 0, sortedArray.Length-1 );
		}

		private static int[] QuickSortRecursive( int[] inputArray, int leftRange, int rightRange ) {

			int pivotElement = inputArray[( leftRange + rightRange ) / 2];
			
			int i = leftRange;
			int j = rightRange;

			while( i < j ) {
				while( inputArray[i] < pivotElement ) {
					i++;
				}
				while( pivotElement < inputArray[j] ) {
					j--;
				}
				if( i <= j ) {
					Extensions.SwapElements( inputArray, i, j );
					i++;
					j--;
				}
			}
			if( leftRange < j ) {
				QuickSortRecursive( inputArray, leftRange, j );
			}
			if( i < rightRange ) {
				QuickSortRecursive( inputArray, i, rightRange );
			}
			return inputArray;
		} 
	}
}
