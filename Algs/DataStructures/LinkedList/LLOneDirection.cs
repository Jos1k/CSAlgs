using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList {

	public class LLOneDirection<T> {
		private LLNode<T> _head;
		private LLNode<T> _tail;
		private int _nodeCount;

		public void Add( T data ) {
			LLNode<T> newNode = new LLNode<T>( data, null );
			if( _head == null ) {
				_head = newNode;
			} else {
				_tail.Next = newNode;
			}
			_tail = newNode;
			_nodeCount++;
		}

		public void RemoveLast() {
			_tail = null;
			_nodeCount--;
		}

		public void RemoveFirst() {
			_head = _head.Next;
			_tail = _head;
			_nodeCount--;
		}

		public T[] ToArray() {
			T[] resultArray = new T[_nodeCount];
			LLNode<T> current = _head;

			for( int i = 0; i < resultArray.Count(); i++ ) {
				resultArray[i] = current.Data;
				current = current.Next;
			}

			return resultArray;
		}
	}
}
