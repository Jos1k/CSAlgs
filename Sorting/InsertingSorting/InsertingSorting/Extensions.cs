using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertingSorting {
	public static class Extensions {
		public static string ArrayToString( this int[] array ) {
			return "[ " + string.Join(" ",array) + " ]";
		}
	}
}
