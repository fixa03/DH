using System;
using lib1;

namespace DH
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person("Alice");
            Person p2 = new Person("Bob");

            p2.ListenG( p1.SayG() );
            p2.ListenP( p1.SayP() );
            p2.Listen( p1.SayPublicN() );
            p1.Listen( p2.SayPublicN() );

            p1.GenerateKey(); p2.GenerateKey();
            p1.show();  p2.show();
            Console.ReadKey();
        }

    }
}
