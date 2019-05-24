using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackUnitTestExample;
using NUnit.Framework;


namespace StackUnitTestExample_Tests
{
    [TestFixture]
    public class StackUnitTestExample_Tests
    {

        [Test]
        public void Creation()
        {
            Stack<int> s = new Stack<int>(3);
            Assert.AreEqual(0, s.Size);
        }

        [Test]
        public void Push_Pop()
        {
            Stack<int> s = new Stack<int>(3);

            s.Push(1);
            s.Push(2);
            s.Push(3);
            int value = s.Pop();
        }

        [Test]
        public void Too_Much_Pop()
        {
            Stack<int> s = new Stack<int>(3);
            Assert.Throws<ExpenditureProhibitedException>(() => s.Pop());

        }

        [Test]
        public void Too_Much_Push()
        {
            Stack<int> s = new Stack<int>(3);
            s.Push(1);
            s.Push(2);
            s.Push(3);
            Assert.Throws<ExceededSizeException>(() => s.Push(4));

        }

        [Test]
        public void Peek_Exception()
        {
            Stack<int> s = new Stack<int>(3);
            Assert.Throws<ExpenditureProhibitedException>(() => s.Peek());
        }

        [Test]
        public void Peek_Element()
        {
            Stack<int> s = new Stack<int>(3);

            s.Push(1);
            s.Push(2);

            int value = s.Peek();

            Assert.AreEqual(2, value);
            Assert.AreEqual(2, s.Size);
            
        }
    }
}
