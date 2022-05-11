using System;
using System.Numerics;
using System.Threading;

namespace lib1
{
    class MathOperations
    {
		Random rnd;

		public MathOperations()
		{ rnd = new Random(); }

		public bool IsPrime(int a)
		{
			//int count = 2;
			for (int i = 2; i < a; i++)
			{
				if (a % i == 0)
					return false;
			}


			return true;
		}

		public int GeneratePrime(int min = 3, int max = 100)
		{
			Thread.Sleep(200);

			int res = rnd.Next(min, max);

			while (!IsPrime(res))
			{
				res = rnd.Next(min, max);
			}

			return res;
		}

	}

	class Person
	{
		string name;

		int g, p;
		int public_number_neighbor;
		int private_number;
		int key;

		public Person(string name)
		{ 
			this.name = name;

			MathOperations obj = new MathOperations();

			g = obj.GeneratePrime();
			p = obj.GeneratePrime();
			private_number = obj.GeneratePrime();

		}

		public int SayG()
		{ return g; }

		public void ListenG(int g)
		{ this.g = g; }

		public int SayP()
		{ return p; }

		public void ListenP(int p)
		{ this.p = p; }

		public int SayPublicN()
		{
			return (int)BigInteger.ModPow(g, private_number, p);
		}

		public void Listen(int neighbor_number)
		{
			public_number_neighbor = neighbor_number;
		}

		public void GenerateKey()
		{
			key = (int)BigInteger.ModPow(public_number_neighbor, private_number, p);
		}

		public void show()
        {
			Console.WriteLine($"g: {g} p: {p}");
			Console.WriteLine($"PrivateN: {private_number} NeighborP: {public_number_neighbor}");
			Console.WriteLine($"Key: {key}");
		}
	
	}
}
