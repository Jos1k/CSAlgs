﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Algorithms {

	public class ShellSorting {
		public static int[] Sort( int[] inputArray ) {
			int[] sortedArray = (int[])inputArray.Clone();

			int step = sortedArray.Length / 2;
			while( step > 0 ) {
				for( int i = 0; i < step; i++ ) {
					for( int j = i+step; j < sortedArray.Length; j+=step ) {
						for( int x=j; x >= step && sortedArray[x]<sortedArray[x-step]; x-=step) {
							Extensions.SwapElements(sortedArray,x, x-step);
						}
					}
				}
				step = step / 2;
			}

			return sortedArray;
		}
	}
}
