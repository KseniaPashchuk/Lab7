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
            string expectedStr = "Name = Vasya Pupkin, Faculty = MMF, Course = 2, Department = Extramural";
            Assert.AreEqual(expectedStr, student.ToString());
        }
    }
}