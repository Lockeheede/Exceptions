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
		//you can make the exceptions into variables (notice the "ex" variable in this catch block)
		catch (DivideByZeroException ex)
		{
			int startIndex = ex.StackTrace.IndexOf(':') - 1;
			int length = ex.StackTrace.Length - startIndex;
			string fileName = ex.StackTrace.Substring(startIndex, length);

			Console.WriteLine(fileName);//This uses the substring method to isolate the filename where the exception is happening
			Console.WriteLine(ex.Message);//This method creates the default message based on the type of exception


		}
		catch (Exception)
		{
			Console.WriteLine("Unexpected error!");
		}
	}
    }

