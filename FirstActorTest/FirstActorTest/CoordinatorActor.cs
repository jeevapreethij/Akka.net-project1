using System;
using Akka.Actor;

namespace FirstActorTest
{
    class CoordinatorActor:ReceiveActor
    {
        public CoordinatorActor()
        {
            Console.WriteLine("Creating a Coordinator actor");
            getBookDetails();
        }

        private void getBookDetails()
        {
            try
            {                
                int bookId = int.Parse(Console.ReadLine());
                string bookName = Console.ReadLine();
                IActorRef WorkerActor = Context.ActorOf(Props.Create(() => new Worker()));
                WorkerActor.Tell(new BookDetailsMsg(bookId, bookName));
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }         
        }
    }
}
