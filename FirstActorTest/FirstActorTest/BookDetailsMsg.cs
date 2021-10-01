using System;
using Akka.Actor;


namespace FirstActorTest
{
    public class BookDetailsMsg:ReceiveActor
    {
        public int BookId { get; private set; }

        public string BookName { get; private set; }
        public BookDetailsMsg(int bookid,string bookname)
        {
            BookId = bookid;
            BookName = bookname;
        }
    }
}
