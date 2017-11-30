using System;

namespace Wordpress
{
    internal class Login
    {
       
        
        internal static void LogToURl(credentialss testData)

        {
            var email = Browser.FindElementById("usernameOrEmail");

            email.Click();

            email.SendKeys(testData.User);
        }

        internal static void LogToURl(credentialss testData)
        {
            var email = Browser.FindElementById("usernameOrEmail");

            email.Click();

            email.SendKeys(testData.User);
        }
    }
}