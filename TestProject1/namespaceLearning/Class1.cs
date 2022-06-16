using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.NamespaceLearning
{
    [TestClass]
     public class Class1
    {
       
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("TestMethod is called");
           // Flowers();

        }


    }
}
namespace TestProject2.NamespaceLearning
{
    [TestClass]
    public class Class1
    {

        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("TestMethod is called");
            // Flowers();

        }


    }
}
