using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication_Demo.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        { 
        
        }
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void IsBoughtBy_UserIsCustomer_ReturnTrue()
        {
            var bought = new Bought();
            var result = bought.IsBoughtBy(new User { customer = true });
            Assert.IsTrue(result);
        }
    }
}
