using Microsoft.VisualStudio.TestTools.UnitTesting;
using Speak;

namespace Speak.Tests
{
  [TestClass]
  public class SpeakTest
  {
    [TestMethod]
   public void Translate_FromeTo3_TurneToe()
   {
       LeetspeakTranslator translate = new LeetspeakTranslator("Hell");
       Assert.AreEqual("H3ll", translate.Translate());
       
   }
    [TestMethod]

   public void Translate_FromoTo0_TurnoTo0()
   {
       LeetspeakTranslator traslate = new LeetspeakTranslator("corn");
       Assert.AreEqual("c0rn", traslate.Translate());
   }
   [TestMethod]
   public void Translate_FromITo1_TurnITo1()
   {
       LeetspeakTranslator translate = new LeetspeakTranslator("I'am");
       Assert.AreEqual("1'am", translate.Translate());
   }
      [TestMethod]
     public void Translate_FromtTo7_TurntTo7()
     {
        LeetspeakTranslator translate = new LeetspeakTranslator("thuz");
        Assert.AreEqual("7huz", translate.Translate());
     }
     [TestMethod]

         public void Translate_FromsToz_TurnsToz()
    {
        LeetspeakTranslator translate = new LeetspeakTranslator("spards");
        Assert.AreEqual("spardz", translate.Translate());
    }
  }
}