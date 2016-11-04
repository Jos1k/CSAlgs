namespace Algs {
	public static class Extensions {
		public static string ArrayToString( this int[] array ) {
			return "[ " + string.Join(" ",array) + " ]";
		}
	}
}
