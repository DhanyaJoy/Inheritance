namespace TestProject1
{
    public class Calculator
    {
        public string name;
        Interfacelogger mylogger;
        public Calculator(Interfacelogger logger)
        {
           this.mylogger = logger;
        }
       
        public int Add(int a,int b)
        {
            int c = a + b;
            // interfacelogger interfacelog = new consolelogger();
            // Console.WriteLine($"sum of {a} and {b} is {c}");
            
            mylogger.log($"sum of {a} and {b} is {c}");
          
            return (c);   
        }
    }
}