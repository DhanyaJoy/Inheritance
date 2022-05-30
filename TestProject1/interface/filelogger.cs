namespace TestProject1
{
    class filelogger : Interfacelogger
    {
        public void log(string message)
        {
            File.AppendAllText("log.txt",message);
        }

    }
}