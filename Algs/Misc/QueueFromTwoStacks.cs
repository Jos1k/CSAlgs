using System.Collections.Generic;
using System.Linq;

namespace Misc
{
    public class QueueFromTwoStacks
    {
        private Stack<int> _input, _output;

        public QueueFromTwoStacks()
        {
            _input = new Stack<int>();
            _output = new Stack<int>();
        }
        public void Enqueue(int data)
        {
            _input.Push(data);
        }

        public int Dequeue()
        {
            if (!_output.Any())
            {
                while (_input.Any())
                {
                    _output.Push(_input.Pop());
                }
            }
            if (_output.Any())
            {
                return _output.Pop();
            }
            return -1;
        }
    }
}
