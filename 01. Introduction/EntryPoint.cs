using System;

    class EntryPoint
    {
        static void Main()
        {
		try
		{
			int number1 = Convert.ToInt32(Console.ReadLine());
			int number2 = Convert.ToInt32(Console.ReadLine());
			int divided = number1 / number2;
		}
		catch (DivideByZeroException)
		{
			Console.WriteLine("You cannot divide by 0! Enter a non-zero number!");
			
		}
        }
    }

