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
            var leaf = new Leaf() {Value = 5, Evaluation = "a.ValueA < b" };
            var leafList = new List<Leaf>();

            leafList.Add(leaf);

            var trunk = new Trunk() {Leafs = leafList };


            _validator.AddTrunk(trunk);

            var returnValue = _validator.Validate(_testObj);

            Assert.IsTrue(returnValue);
        }
    }
}
