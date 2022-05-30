namespace TestProject1
{
    public class car : transportation
    {
       
       
        public car()
        {
            Console.WriteLine("green");
        }
        public void display()
        {
            Console.WriteLine("car"+"red");
        }
        public override void drive()
        {
            //name = "Tayota";
            Console.WriteLine(nameof(car) + nameof(drive));

        }

    }
}