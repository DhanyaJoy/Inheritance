namespace TestProject1
{
    [TestClass]
    public class constructortest
    {
        [TestMethod]
        public void TestMethod1()
        {
            vehicle vehicleobj = new vehicle(7);
           // Assert.AreEqual("Honda",vehicleobj.name);
           vehicleobj.display("hi");
        }
    }
    public class vehicle
    {
        public string name;
        public vehicle()
        {
            name ="Honda";
            Console.WriteLine("vehicle constructer");
        }
        public vehicle(int a):this()
        {
            name = "Benz";
            Console.WriteLine("vehicle constructer int");
        }
        public vehicle(string n)
        {
            name = "Ford";
            Console.WriteLine("vehicle constructer string");
        }
        public void display()
        {
            name = "Tayota";
            Console.WriteLine("display");

        }
        public void display(string name)
        {
            //name = "Tayota";
            Console.WriteLine("welcome"+this.name);

        }

    }
}