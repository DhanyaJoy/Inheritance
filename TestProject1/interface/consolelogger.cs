namespace TestProject1
{
    class consolelogger : Interfacelogger
    {
       public void log(string message)
        {
            Console.WriteLine(message);
        }

    }
}