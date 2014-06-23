using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DotValTree;
using DotEvalTreeTest.Helper;
using DotValTree.Nodes;

namespace DotEvalTreeTest
{
    [TestFixture]
    public class ValidatorTest
    {
        private AbstractLogicalNode _node;

        private ComplexTestObject _testObj;

        [SetUp]
        public void SetUp()
        {
            _node = new AndNode();
            _testObj = new ComplexTestObject { ValueA = 1, ValueB = "This is a test" };
        }

        [TearDown]
        public void TearDown()
        {

        }

        [Test]
        public void ValidateSuccessful()
        {
            var value1 = new ValueNode() { ValidationValue = 5, Evaluation = "a.ValueA < b" };
            var value2 = new ValueNode() { ValidationValue = 0, Evaluation = "a.ValueA > b" };

            var leftOr = new OrNode();
            leftOr.AddNode(value1);
            leftOr.AddNode(value2);

            var value3 = new ValueNode() { ValidationValue = "This is a test", Evaluation = "a.ValueB == b" };
            var value4 = new ValueNode() { ValidationValue = "Whoopsie", Evaluation = "a.ValueB == b" };

            var rightOr = new OrNode();
            rightOr.AddNode(value3);
            rightOr.AddNode(value4);

            _node.AddNode(leftOr);
            _node.AddNode(rightOr);

            var returnValue = _node.Validate(_testObj);
            Assert.IsTrue(returnValue);

            value1.ValidationValue = 1;
            value2.ValidationValue = 10;

            returnValue = _node.Validate(_testObj);
            Assert.IsFalse(returnValue);
        }

        [Test]
        public void ValidationPerformanceBelow30MicrosecondsSuccessful()
        {
            var value1 = new ValueNode() { ValidationValue = 5, Evaluation = "a.ValueA < b" };
            var value2 = new ValueNode() { ValidationValue = 0, Evaluation = "a.ValueA > b" };

            var leftOr = new OrNode();
            leftOr.AddNode(value1);
            leftOr.AddNode(value2);

            var value3 = new ValueNode() { ValidationValue = "This is a test", Evaluation = "a.ValueB == b" };
            var value4 = new ValueNode() { ValidationValue = "Whoopsie", Evaluation = "a.ValueB == b" };

            var rightOr = new OrNode();
            rightOr.AddNode(value3);
            rightOr.AddNode(value4);

            _node.AddNode(leftOr);
            _node.AddNode(rightOr);

            // first validation will create objects, not worth checking
            var returnValue = _node.Validate(_testObj);

            var watch = new System.Diagnostics.Stopwatch();
            watch.Reset();
            watch.Start();
            returnValue = _node.Validate(_testObj);
            watch.Stop();
            Assert.LessOrEqual(watch.Elapsed.TotalMilliseconds, 0.0030);
            System.Console.WriteLine(watch.Elapsed.TotalMilliseconds);

            Assert.IsTrue(returnValue);
        }
    }
}
