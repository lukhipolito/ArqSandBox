using ArqSandBox.Common.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArqSandBox.Test
{
    [TestClass]
    public class ExtensionsTest
    {
        [TestMethod]
        public void TestStartsWithUpper()
        {
            //Expected: True
            string[] words = { "Alphabet", "Zebra", "ABC", "Αθήνα", "Москва" };
            foreach(var word in words)
            {
                bool result = word.StartsWithUpper();
                Assert.IsTrue(result, 
                    string.Format("Expected {0}: True. Returned: {1}", word, result));
            }
        }

        [TestMethod]
        public void TestDoesNotStartWithUpper()
        {
            //Expected: False
            string[] words = { "alphabet", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство",
                               "1234", ".", ";", " " };
            foreach(var word in words)
            {
                bool result = word.StartsWithUpper();
                Assert.IsFalse(result, 
                    string.Format("Expected {0}: False. Returned: {1}", word, result));
            }
        }

        [TestMethod]
        public void TestNullStrings()
        {
            //Expected: False
            string[] words = { string.Empty, null };

            foreach(var word in words)
            {
                bool result = word.StartsWithUpper();
                Assert.IsFalse(result, 
                    string.Format("Expected {0}: False. Returned: {1}", word, result));
            }
        }
    }
}
