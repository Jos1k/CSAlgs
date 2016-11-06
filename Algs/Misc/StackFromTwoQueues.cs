using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc {
	public class StackFromTwoQueues {
		private Queue<int> _input = new Queue<int>();
		private Queue<int> _output = new Queue<int>();

		public void Push( int data ) {
			_input.Enqueue( data );
		}

		public int Pop() {
			while( _input.Count > 1 ) {
				_output.Enqueue( _input.Dequeue() );
			}
			if( _input.Count == 0 ) {
				return -1;
			}

			var tempArr = _input;
			_input = _output;
			_output = tempArr;

			return _output.Dequeue();
		}
	}
}
