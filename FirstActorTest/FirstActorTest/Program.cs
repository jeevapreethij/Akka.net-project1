using Akka.Actor;
using System;

namespace FirstActorTest
{
    class Program
    {
        private static ActorSystem MainActorSystem;
        static void Main(string[] args)
        {
            MainActorSystem = ActorSystem.Create("MainActorSystem");
            MainActorSystem.ActorOf(Props.Create<CoordinatorActor>(), "CoordinatorActor");
            Console.ReadKey();

            MainActorSystem.Terminate();
            MainActorSystem.WhenTerminated.Wait();
            Console.WriteLine("Actor system shutdown");
            Console.ReadKey();
            Environment.Exit(1);
        }
    }
}
