
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Autotest_contr;


namespace UnitTest1;

public class TestOfTask1
{
    
    [Test]
    public void CheckingEquivalence()
    {
        int[] testMas1 = {1, 2, 3};
        int[] testMas2 = {16416, 1715710, 1050109103, 10, 150153, 0, 1000, 643, 25, 72014};
        int[] testMas3 = { 3 };
        int[] testMas4 = {-1, -2, -3};
        
        var result1 = Task1.ToFindMin(testMas1);
        var result2 = Task1.ToFindMin(testMas2);
        var result3 = Task1.ToFindMin(testMas3);
        var result4 = Task1.ToFindMin(testMas4);

        Assert.That(result1, Is.EqualTo(1));
        Assert.That(result2, Is.EqualTo(0));
        Assert.That(result3, Is.EqualTo(3));
        Assert.That(result4, Is.EqualTo(-3));
    }
    [Test]
    public void CheckingErrorOfNull()
    {
        int[] testMas = null;
        Assert.Throws<ArgumentNullException>(() => Task1.ToFindMin(testMas));
    }
    [Test]
    public void CheckingErrorOfEmptyString()
    {
        int[] emptyMas = new int[0];
        Assert.Throws<ArgumentException>(() => Task1.ToFindMin(emptyMas));
    }
}

public class TestOfTask2
{
     [Test]
    public void CheckingEquivalence()
    {
        string testStr1 = "InterNAtioNal";
        string testStr2 = "RAMa";
        string testStr3 = "L";
        
        var result1 = Task2.IsCountStr(testStr1);
        var result2 = Task2.IsCountStr(testStr2);
        var result3 = Task2.IsCountStr(testStr3);

        Assert.That(result1, Is.EqualTo(9));
        Assert.That(result2, Is.EqualTo( 1));
        Assert.That(result3, Is.EqualTo( 0));
    }
    [Test]
    public void CheckingErrorOfNull()
    {
        string nullStr = null;
        Assert.Throws<ArgumentNullException>(() => Task2.IsCountStr(nullStr));
    }
    [Test]
    public void CheckingErrorOfEmptyString()
    {
        string emptyStr = "";
        Assert.Throws<ArgumentException>(() => Task2.IsCountStr(emptyStr));
    }
}

public class TestOfTask3
{
    [Test]
    public void CheckingEquivalence()
    {
        string testStr1 = "ABCDEFG";
        string testStr2 = "Doggo012501325#1ne";
        
        var result1 = Task3.IsLast3Simb(testStr1);
        var result2 = Task3.IsLast3Simb(testStr2);

        Assert.That(result1, Is.EqualTo('E'));
        Assert.That(result2, Is.EqualTo( '1'));
    }
    [Test]
    public void CheckingErrorOfNull()
    {
        string nullStr = null;
        Assert.Throws<ArgumentNullException>(() => Task3.IsLast3Simb(nullStr));
    }
    [Test]
    public void CheckingErrorOfEmptyString()
    {
        string emptyStr = "";
        Assert.Throws<ArgumentException>(() => Task3.IsLast3Simb(emptyStr));
    }
    [Test]
    public void CheckingErrorOutOfRangeException()
    {
        string str = "OK";
        Assert.Throws<ArgumentOutOfRangeException>(() => Task3.IsLast3Simb(str));
    }
}

public class TestOfTask4
{
    [Test]
    public void CheckingIsAPalindrome()
    {
        int testAPalindrome = 1222222221;
        int singleDigit = 9;
        
        var result1 = Task4.IsPalindrome(testAPalindrome);
        var result2 = Task4.IsPalindrome(singleDigit);
        
        Assert.That(result1, Is.EqualTo(true));
        Assert.That(result2, Is.EqualTo(true));

    }
    [Test]
    public void CheckingIsNotAPalindrome()
    {
        int testNegative = -121; 
        int testNotAPalindrome = 1691689;
        
        var result1 = Task4.IsPalindrome(testNegative);
        var result2 = Task4.IsPalindrome(testNotAPalindrome);
        
        Assert.That(result1, Is.EqualTo(false));
        Assert.That(result2, Is.EqualTo(false));
    }
}

public class TestOfTask5
{
    [Test]
    public void CheckingEquivalence()
    {
        int[] nums1 = {1,2,3,4,5,6};
        int[] nums2 = {15616, 27, 321, 51624, 100, 1, 0 };
        int[] numsSingle = {9};
        int[] numsNegative = {-151, -4, -16, -1, -636};
        
        var result1 = Task5.RunningSum(nums1);
        var result2 = Task5.RunningSum(nums2);
        var result3 = Task5.RunningSum(numsSingle);
        var result4 = Task5.RunningSum(numsNegative);

        Assert.That(result1, Is.EqualTo(new int[] {0,1,3,6,10,15}));
        Assert.That(result2, Is.EqualTo(new int[] {0,15616,15643,15964,67588,67688,67689}));
        Assert.That(result3, Is.EqualTo(new int[] {0}));
        Assert.That(result4, Is.EqualTo(new int[] {0, -151, -155, -171, -172}));
    }
    [Test]
    public void CheckingErrorOfNull()
    {
        int[] testMasNull = null;
        Assert.Throws<ArgumentNullException>(() => Task5.RunningSum(testMasNull));
    }
    [Test]
    public void CheckingErrorOfEmptyString()
    {
        int[] emptyMas = new int[0];
        Assert.Throws<ArgumentException>(() => Task5.RunningSum(emptyMas));
    }
}

public class TestOfTask6
{
    [Test]
    public void CheckingIsNotANumber()
    {
        string testStrSymbols = "PYTHON";
        int number;

        var result1 = Task6.TryParse(testStrSymbols,out number);

        Assert.False(result1);
        
        Assert.That(number, Is.EqualTo( 0));
    }
    [Test]
    public void CheckingIsNotANumberWithSpace()
    {
        string testStrWithSpace = " 165785698260 ";
        int number;
        var result1 = Task6.TryParse(testStrWithSpace,out number);
        
        Assert.False(result1);
        Assert.That(number, Is.EqualTo( 0));   
    }
    [Test]
    public void CheckingIsANumber()
    {
        string testStr1 = "190079179";
        int number;
        var result1 = Task6.TryParse(testStr1,out number);

        Assert.True(result1);
        Assert.That(number, Is.EqualTo( 190079179));
    }

    [Test]
    public void CheckingIsANumberWithNegative()
    {
        string testStrNegative = "-678";
        int number;
        var result2 = Task6.TryParse(testStrNegative,out number);
        
        Assert.True(result2);
        Assert.That(number, Is.EqualTo( -678));   
    }
    [Test]
    public void CheckingErrorOfNull()
    {
        int number;
        string testStr = null;
        Assert.Throws<ArgumentNullException>(() => Task6.TryParse(testStr,out number));
    }
    [Test]
    public void CheckingErrorOfEmptyString()
    {
        int number;
        string testStr = "";
        Assert.Throws<ArgumentException>(() => Task6.TryParse(testStr,out number));
    }
}