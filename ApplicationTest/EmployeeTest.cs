using Application;
using NUnit.Framework;


namespace ApplicationTest
{
    class EmployeeTest
    {
        [Test]
        public void MyFirstTestMethod()
        {
            Assert.Pass();
        }

        [Test]
        public void IntroduceMethodShouldWorkCorrectly()
        {
            // arrange
            var sut = new Employee("Alice", "Programmer", 100000);
            var expected = "Hi! My name is Alice and I work as a Programmer.";

            // act
            string result = sut.Introduce();
            
            // assert
            Assert.AreEqual(expected, result);
        }
    }
}