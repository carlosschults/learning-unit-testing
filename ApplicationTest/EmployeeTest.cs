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

        [Test]
        public void GiveTenPercentRaiseShouldRaiseTheSalaryFrom100To110()
        {
            // arrange
            var raise = 10;
            var sut = new Employee("Bob", "Tester", 100);
            var expected = 110;

            // act
            sut.GiveRaise(raise);
            var newSalary = sut.Salary;

            // assert
            Assert.AreEqual(expected, newSalary);
        }
    }
}