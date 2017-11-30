﻿using System;
using System.Linq;

namespace Test_Page_Object
{
    internal class NotePage
    {
        internal static void AddComment(Comment testData)
        {
            var commentBox = Browser.FindElementById("comment");

            commentBox.Click();

            commentBox.SendKeys(testData.Text);

            var emailLabel = Browser.FindByXpath("//label[@for='email']");

            emailLabel.First().Click();

            var email = Browser.FindElementById("email");

            email.SendKeys(testData.Mail);

            var nameLabel = Browser.FindByXpath("//label[@for='author']");

            nameLabel.First().Click();



            var name = Browser.FindElementById("author");

            name.SendKeys(testData.User);

            var submit = Browser.FindElementById("comment-submit");

            submit.Click();

        }
    }
}