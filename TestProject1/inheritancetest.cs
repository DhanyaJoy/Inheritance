namespace TestProject1
{
    [TestClass]
    public class inheritancetest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //transportation transportationobj = new transportation(7);
            car carobj=new car();
           // Assert.AreEqual("Honda",tranaportationobj.name);
          // transportationobj.display("hi");
            carobj.display();
        }
    }
}