using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DotValTree;
using DotEvalTreeTest.Helper;

namespace DotEvalTreeTest
{
    [TestFixture]
    public class ValidatorTest
    {
        private Validator _validator;

        private ComplexTestObject _testObj;

        [SetUp]
        public void SetUp()
        {
            _validator = new Validator();
            _testObj = new ComplexTestObject { ValueA = 1, ValueB = "This is a test" };
        }

        [TearDown]
        public void TearDown()
        {

        }

        [Test]
        public void ValidateSuccessful()
        {
            var valueList = new List<Value>();
            var value = new Value() { ValidationValue = 5, Evaluation = "a.ValueA < b" };
            valueList.Add(value);
            var value1 = new Value() { ValidationValue = 5, Evaluation = "a.ValueA > b" };
            valueList.Add(value1);
            var leaf = new Leaf() { Values = valueList };

            var valueList2 = new List<Value>();
            var value2 = new Value() { ValidationValue = "This is a test", Evaluation = "a.ValueB == b" };
            valueList2.Add(value);
            var leaf2 = new Leaf() { Values = valueList2 };

            var leafList = new List<Leaf>();
            leafList.Add(leaf);
            leafList.Add(leaf2);

            var trunk = new Trunk() {Leafs = leafList };
            _validator.AddTrunk(trunk);
            var returnValue = _validator.Validate(_testObj);

            Assert.IsTrue(returnValue);
        }
    }
}
