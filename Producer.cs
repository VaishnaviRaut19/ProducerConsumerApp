using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumerApp
{
    public class Producer
    {
        private readonly MessageQueue<string> _messageQueue;

        public Producer(MessageQueue<string> messageQueue)
        {
            _messageQueue = messageQueue;
        }

        public void Produce(string message)
        {
            _messageQueue.Enqueue(message);
            Console.WriteLine($"Produced: {message}");
        }
    }
}
