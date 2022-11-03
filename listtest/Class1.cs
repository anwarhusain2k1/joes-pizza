using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using joe;
using NUnit.Framework;

namespace listtest
{
    [TestFixture]
    public class test
    {
        op Op = null;
        public test()
        {
            Op = new op();
        }
        [TestCase(ExpectedResult = 5)]
        [TestCase(ExpectedResult = 4)]        
        public int menucheck()
        {
            Op.add();
            return (Op.menu.Count);
        }
    }
}
