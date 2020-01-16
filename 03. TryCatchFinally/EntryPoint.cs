using System;
using System.IO;

    class EntryPoint
    {
        static void Main()
        {
        StreamWriter sw = null;
        //Use conditional statements when you are in control of what might happen
        //Use try/catch blocks in extreme situations, otherwise use conditonals
        //try/catch blocks are in cases where you do not know the outcome of what might happen.
        try
        {
            sw = File.AppendText(Directory.GetCurrentDirectory() + @"\test.txt");

            int number = Convert.ToInt32(Console.ReadLine());
            int divided = 5 / number;

            sw.Write(divided);
            sw.Close();
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            //Whatever is here will be executed even if we get the exception
            sw.Close();
        }
        try
        {
            StreamReader sr = File.OpenText(Directory.GetCurrentDirectory() + @"\test.txt");
            Console.WriteLine(sr.ReadToEnd());
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        }
    }

