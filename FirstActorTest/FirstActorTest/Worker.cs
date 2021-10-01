using System;
using Akka.Actor;

namespace FirstActorTest
{
    class Worker:ReceiveActor
    {
        public Worker()
        {
            Console.WriteLine("Creating a Worker actor");
            Receive<BookDetailsMsg>(message => ReceivedBooks(message));
        }

        private void ReceivedBooks(BookDetailsMsg message)
        {
            Console.WriteLine("Received Book ID {0} and name: {1}", message.BookId, message.BookName);
        }
    }
}
