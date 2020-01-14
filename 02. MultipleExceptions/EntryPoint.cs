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
		//The code is SUPPOSED to be as simple as adding an extra catch block
		//Mine seems to be putting the throw format, not the one I created
		catch (FormatException)
		{
			Console.WriteLine("Your input was not a number! Please enter a number!");
		}
		catch (DivideByZeroException)
		{
			Console.WriteLine("You cannot divide by 0! Enter a non-zero number!");

		}
		catch (Exception)
		{
			Console.WriteLine("Unexpected error!");
		}
	}
    }

