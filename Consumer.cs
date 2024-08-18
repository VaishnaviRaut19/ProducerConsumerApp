using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumerApp
{
    public class Consumer
    {
        private readonly MessageQueue<string> _messageQueue;
        private int _successCount;
        private int _errorCount;

        public Consumer(MessageQueue<string> messageQueue)
        {
            _messageQueue = messageQueue;
        }

        public void Consume()
        {
            while (_messageQueue.TryDequeue(out var message))
            {
                try
                {
                    // Simulate message processing
                    if (message.Contains("Error"))
                    {
                        throw new Exception("Error encountered during processing.");
                    }

                    _successCount++;
                    Console.WriteLine($"Consumed successfully: {message}");
                }
                catch (Exception ex)
                {
                    _errorCount++;
                    Console.WriteLine($"Failed to process: {message}. Error: {ex.Message}");
                }
            }
        }

        public int SuccessCount => _successCount;
        public int ErrorCount => _errorCount;
    }
}
