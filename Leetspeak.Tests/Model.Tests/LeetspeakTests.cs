using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetspeak;

namespace Leetspeak.Tests
{
  [TestClass]
  public class LeetspeakTest
  {
    [TestMethod]
    public void DoesInputHasLetterLowerE_True()
    {
      Leetspeak testLeetspeak = new Leetspeak();
      Assert.AreEqual("3", testLeetspeak.ConvertToLeetSpeak("e"));
    }

    [TestMethod]
    public void DoesInputHasLetterLowerE_False()
    {
      Leetspeak testLeetspeak = new Leetspeak();
      Assert.AreEqual("r", testLeetspeak.ConvertToLeetSpeak("r"));
    }

    [TestMethod]
    public void DoesInputHasLetterLowerO_True()
    {
      Leetspeak testLeetspeak = new Leetspeak();
      Assert.AreEqual("0", testLeetspeak.ConvertToLeetSpeak("o"));
    }

    [TestMethod]
    public void DoesInputHasLetterLowerO_False()
    {
      Leetspeak testLeetspeak = new Leetspeak();
      Assert.AreEqual("r", testLeetspeak.ConvertToLeetSpeak("r"));
    }

    [TestMethod]
    public void DoesInputHasLetterCapitalI_True()
    {
      Leetspeak testLeetspeak = new Leetspeak();
      Assert.AreEqual("1", testLeetspeak.ConvertToLeetSpeak("I"));
    }

    [TestMethod]
    public void DoesInputHasLetterCapitalI_False()
    {
      Leetspeak testLeetspeak = new Leetspeak();
      Assert.AreEqual("i", testLeetspeak.ConvertToLeetSpeak("i"));
    }

    [TestMethod]
    public void DoesInputHasLetterLowerT_True()
    {
      Leetspeak testLeetspeak = new Leetspeak();
      Assert.AreEqual("7", testLeetspeak.ConvertToLeetSpeak("t"));
    }

    [TestMethod]
    public void DoesInputHasLetterLowerT_False()
    {
      Leetspeak testLeetspeak = new Leetspeak();
      Assert.AreEqual("T", testLeetspeak.ConvertToLeetSpeak("T"));
    }

    // [TestMethod]
    // public void DoesInputHasLetterLowerS_True()
    // {
    //   Leetspeak testLeetspeak = new Leetspeak();
    //   Assert.AreEqual("z", testLeetspeak.ConvertToLeetSpeak("s"));
    // }
    //
    // [TestMethod]
    // public void DoesInputHasLetterLowerS_False()
    // {
    //   Leetspeak testLeetspeak = new Leetspeak();
    //   Assert.AreEqual("r", testLeetspeak.ConvertToLeetSpeak("r"));
    // }

    [TestMethod]
    public void IsInputFirstLetterAndS_True()
    {
      Leetspeak testLeetspeak = new Leetspeak();
      Assert.AreEqual("pl3az3 say h0rz3", testLeetspeak.ConvertToLeetSpeak("please say horse"));
    }

  }
}
