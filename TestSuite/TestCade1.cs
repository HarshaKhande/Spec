using AppiumSpecFlowProject1.Hooks;
using AppiumSpecFlowProject1.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumSpecFlowProject1.TestSuite
{

    [TestFixture]
    public class TestCase1 : TestInitializeUnit
    {


        static ClickPage cp = new ClickPage(AndroidContext);

        [Test]
        public void TestClick()
        {

            cp.CLickViews();




        }
    }
}
