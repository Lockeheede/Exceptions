using System;

    class EntryPoint
    {
        static void Main()
        {
		
			int number1 = Convert.ToInt32(Console.ReadLine());
			int number2 = Convert.ToInt32(Console.ReadLine());

        if (number2 != 0)
        {
            int divided = number1 / number2;
            Console.WriteLine(divided); 
        }
        else if (number2 == 0)
        {
            Console.WriteLine("You cannot divide by 0! Use a non-zero number!");
        }
        }
    }

