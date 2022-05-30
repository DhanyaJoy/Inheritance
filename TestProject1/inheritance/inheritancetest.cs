namespace TestProject1
{
    [TestClass]
    public class InheritanceTest
    {
        [TestMethod]
        public void inheritance1()
        {
            transportation transportationobj = new transportation();
           car carobj=new car();
           // Assert.AreEqual("Honda",tranaportationobj.name);
         // transportationobj.display("hi");
            carobj.display();
        }
       
        [TestMethod]
        public void inheritance2()
        {
        
             car carobj=new car();
            carobj.display();
        }
        [TestMethod]
        public void overridingNotHappen()
        {
            transportation transportationobj = new car();
            // car carobj=new car();
            // Assert.AreEqual("Honda",tranaportationobj.name);
            transportationobj.display();
        }
        [TestMethod]
        public void overriddingWorked()
        {

            transportation transportationobj = new car();
            transportationobj.drive();
        }
        [TestMethod]
        public void BaseFnCanBeCalledUsingBaseObjEvenIfAFnIsVirtual()
        {

            transportation transportationobj = new transportation();
            transportationobj.drive();
        }

    }

}