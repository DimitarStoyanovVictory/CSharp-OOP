using System;
using System.Reflection;

namespace FirstTest
{
    class SimpleParserTests
    {
        public static void TestReturnsZeroWhenEmptyString(string numbers)
        {
            string testName = MethodBase.GetCurrentMethod().Name;
            try
            {
                SimpleParser p = new SimpleParser();
                int result = p.ParseAndSum(numbers);
                if (result != 0)
                {
                    //Calling the helper method
                    TestUtil.ShowProblem(testName,
                    "Parse and sum should have returned 0 on an empty string");
                }
            }
            catch (Exception e)
            {
                TestUtil.ShowProblem(testName, e.ToString());
            }
        }
    }
}
