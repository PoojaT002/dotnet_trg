using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNov24
{
    //exercise 1
    internal class CalculatorTests
    {
        [Test]
        public void Square_ShouldReturnCorrectSum()
        {
            Calculator c = new Calculator();

            int result = c.Square(2);

            Assert.That(result, Is.EqualTo(4));
        }

        //exercise 2
        
        public class StringHelperTests
        {
            [Test]
            public void CheckString()
            {
                StringHelper s = new StringHelper();

                string result = s.ToUpper("hello");

                Assert.That(result.Length, Is.EqualTo(5));     //lenght
                Assert.That(result[0], Is.EqualTo('H'));       // first letter
                Assert.That(result, Is.EqualTo("HELLO"));      // full string
            }

            //exercise 3
            [Test]
            [TestCase(2, 3, 6)]
            [TestCase(-1, 5, -5)]
            [TestCase(0, 19, 0)]
            public void MultiplyTest(int a, int b, int c)
            {
                Calculator calc = new Calculator();

                int result = calc.Multiply(a, b);

                Assert.That(result, Is.EqualTo(c));
            }

            //exercise 4
            
            public class StudentServiceTests
            {
                [Test]
                public void ValidateAge_ShouldThrowError_WhenAgeIsNegative()
                {
                    StudentService s = new StudentService();

                    Assert.That(() => s.ValidateAge(-1), Throws.ArgumentException);
                }
            }

            //exercise 5 Setup and Teardown 


            
            public class SetupTests
            {
                [SetUp]
                public void BeforeTest()
                {
                    Console.WriteLine("Hi, I run BEFORE each test!");
                }

                [TearDown]
                public void AfterTest()
                {
                    Console.WriteLine("Bye, I run AFTER each test!");
                }

                [Test]
                public void DummyTest()
                {
                    Assert.Pass();
                }


                //exercise 6: Collection Assertions
               
                public class CollectionTests
                {
                    [Test]
                    public void EvenNumbers_ShouldBeCorrect()
                    {
                        var nums = new List<int> { 2, 4, 6, 8 };

                        Assert.That(nums.Count,Is.EqualTo(4));
                        Assert.That(nums, Is.Ordered);
                        Assert.That(nums, Has.All.Matches<int>(n => n % 2 == 0));
                    }
                }

                //exercise 7: String Constraints
                
                public class StringConstraintTests
                {
                    [Test]
                    public void TestStringConstraints()
                    {
                        string word = "NUnitFramework";

                        Assert.That(word, Does.StartWith("N"));
                        Assert.That(word, Does.EndWith("work"));
                        Assert.That(word, Does.Contain("Unit"));
                        Assert.That(word, Has.Length.EqualTo(14));
                    }
                }

                //exercise 8: Testing Asynchronous Method
                [Test]
                public async Task GetMarksAsync_ShouldReturn90()
                {
                    Asyn asyn = new Asyn();
                    var result = await asyn.GetMarksAsync();

                    Assert.That(result,Is.EqualTo(90));
                }

                //exercise 9: Test Case Source
                
                public class MarksTests
                {
                    [Test]
                    [TestCaseSource(nameof(Marks))]
                    public void Marks_ShouldBeGreaterThan40(int mark)
                    {
                        Assert.That(mark, Is.GreaterThan(40));
                    }
                    public static int[] Marks = { 70, 50, 90, 100 };
                }


            }
        }
    }
}
    


