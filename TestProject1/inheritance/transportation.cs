namespace trans
{
     public class transportation
    {
        public string name;
        public string color;
        public transportation()
        {
            name ="Honda";
            Console.WriteLine("transportation constructer");
        }
        public transportation(int a):this()
        {
            name = "Benz";
            Console.WriteLine("transportation constructer int");
        }
        public transportation(string n)
        {
            name = "Ford";
            Console.WriteLine("transportation constructer string");
        }
        public void display()
        {
            name = "Tayota";
            Console.WriteLine("transportation"+name);

        }
        public void display(string name)
        {
            //name = "Tayota";
            Console.WriteLine("welcome"+this.name);

        }
        virtual public void drive()
        {
            //name = "Tayota";
            Console.WriteLine(nameof(transportation)+nameof(drive));

        }
       // abstract public int GetNumOfTyres();
        

    

    }
}