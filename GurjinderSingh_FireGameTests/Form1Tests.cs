using Microsoft.VisualStudio.TestTools.UnitTesting;
using GurjinderSingh_FireGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GurjinderSingh_FireGame.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Form1 obj = new Form1();
        }

        [TestMethod()]
        public void MainTest()
        {
            mainClass obj = new mainClass();
        }


    }
}