using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList {
	public class LLNode<T> {
		public T Data { get; set; }
		public LLNode<T> Next { get; set; }

		public LLNode(T data, LLNode<T> next) {
			Data = data;
			Next = next;
		}
	}


}
