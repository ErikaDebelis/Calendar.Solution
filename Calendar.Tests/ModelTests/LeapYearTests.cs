using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calendar;

namespace Calendar.Tests
{
  [TestClass]
  public class LeapYearTests
  {
    [TestMethod]
    public void IsLeapYear_NumberDivisibleByFour_True()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(true, testLeapYear.IsLeapYear(2012));
    }
      [TestMethod]
    public void IsLeapYear_NumberNotDivisibleByFour_False()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(false, testLeapYear.IsLeapYear(1999));
    }
      [TestMethod]
    public void IsLeapYear_MultiplesOfOneHundred_False()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(false, testLeapYear.IsLeapYear(1900));
    }
    [TestMethod]
    public void IsLeapYear_MultiplesOfFourHundred_True()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(true, testLeapYear.IsLeapYear(2000));
    }
  }
}

// using Microsoft.VisualStudio.TestTools.UnitTesting imports the MSTest framework that we installed with the $ dotnet restore command.
// using Calendar; imports the Calendar namespace from the Calendar project for use in our tests.
// [TestClass] tells MSTest that the following class contains tests to be run.
// [TestMethod] tells the compiler that the following code block is an individual test that MSTest will run.
// We declare our test method with the line public void IsLeapYear_NumberDivisibleByFour_True(). MSTest tests are actually methods! Also, they always begin with public void. They are public, which allows the tools running our tests to access them. We add void because they don't explicitly return anything.
// The naming convention used above is public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue().
// We call our test method IsLeapYear_NumberDivisibleByFour_True because IsLeapYear() will be our method's name.
// NumberDivisibleByFour is the behavior this first test will test.
// True is the expected return value.