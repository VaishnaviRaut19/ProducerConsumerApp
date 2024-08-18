using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var messageQueue = new MessageQueue<string>();
            var producer = new Producer(messageQueue);
            var consumer = new Consumer(messageQueue);

            // Produce some messages
            producer.Produce("Message1");
            producer.Produce("Message2");
            producer.Produce("Error: Message3");

            // Consume messages
            consumer.Consume();

            Console.WriteLine($"Total Successful: {consumer.SuccessCount}");
            Console.WriteLine($"Total Errors: {consumer.ErrorCount}");

            Console.ReadLine();
        }
    }
}
