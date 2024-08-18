using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumerApp
{
    public class MessageQueue<T>
    {
        private readonly ConcurrentQueue<T> _queue = new ConcurrentQueue<T>();

        public void Enqueue(T message)
        {
            _queue.Enqueue(message);
        }

        public bool TryDequeue(out T message)
        {
            return _queue.TryDequeue(out message);
        }

        public int Count => _queue.Count;
    }
}
