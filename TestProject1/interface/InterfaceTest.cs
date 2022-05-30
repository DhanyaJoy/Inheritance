namespace TestProject1
{
    [TestClass]
    public class InterfaceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Interfacelogger interfacelog = new filelogger();
            Calculator calculatorobj = new Calculator(interfacelog);
            int c=calculatorobj.Add(5, 3);
            Assert.AreEqual(8,c);
        }
    }
}