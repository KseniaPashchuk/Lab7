using Lab7;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        ExtramuralStudent student;

        [SetUp]
        public void Setup()
        {
            student = new ExtramuralStudent("Vasya Pupkin", "MMF", 2);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}