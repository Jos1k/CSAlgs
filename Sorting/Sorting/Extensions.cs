namespace Sorting {
	public static class Extensions {
		public static string ArrayToString( this int[] array ) {
			return "[ " + string.Join(" ",array) + " ]";
		}

		public static void SwapElements( int[] array, int indexA, int indexB ) {
			int temp = array[indexA];
			array[indexA] = array[indexB];
			array[indexB] = temp;
		}
	}
}
