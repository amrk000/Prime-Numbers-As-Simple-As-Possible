using System;

namespace cs
{
	class Prime
	{
	public bool isPrime(long number)
		{
			
			if (number <= 1) return false; // if number equals 0 or 1 or negative it's not prime

			for (long i = 2; i <= Math.Sqrt(number); i++) if (number % i == 0) return false;
			//in bound: number square root user instead of number can reduce loop runtime by 50%

			return true;
		}

		public string printUntil(long bound)
		{
			string outPut = "";

			for (long i = 2; i < bound; ++i) if (isPrime(i)) outPut += i + "\n"; //if number is prime add to output string

			return outPut;
		}

	}

	class Program
    {
        static void Main(string[] args)
        {
			//make program loop for multiple operations
			while (true)
			{
				Prime myPrimeClass = new Prime();
				int choice;
				long number;

				Console.WriteLine("Prime Numbers Program:");
				Console.WriteLine( "Enter 1 to check number");
				Console.WriteLine( "Enter 2 to print numbers");

				choice = int.Parse(Console.ReadLine());

				switch (choice)
				{
					case 1:

						Console.WriteLine( "Enter Number: ");
						number = long.Parse(Console.ReadLine());
						Console.WriteLine( (myPrimeClass.isPrime(number) ? "it's prime" : "not prime")); //check number and print output using inline if
						break;

					case 2:
						Console.WriteLine( "Enter bound (execluded): ");
						number = long.Parse(Console.ReadLine());
						Console.WriteLine( myPrimeClass.printUntil(number)); //print numbers
						break;

					default:
						Console.WriteLine( "unExpected choice !");
						break;
				}
			}
		}
    }


}
