using OpenQA.Selenium;

using PageObjectTests;

using System;

using System.Linq;

using System.Collections;

using System.Collections.ObjectModel;
using Test_Page_Object;

namespace PageObjcectTests

{

    internal class NotePage

    {

        internal static void AddComment(Comment testData)

        {

            var commentBox = Browser.FindElementById("comment");

            commentBox.Click();

            commentBox.SendKeys(testData.Text);



            var email = Browser.FindElementById("email");

            email.Click();

            email.SendKeys(testData.Mail);



            var nameLabel = Browser.FindByXpath("//label[@for='author']");

            nameLabel.First().Click();



            var name = Browser.FindElementById("author");

            name.Click();

            name.SendKeys(testData.User);



            var submit = Browser.FindElementById("comment-submit");

            submit.Click();

        }



        internal static bool CommentExists(Comment comment)

        {

            if (Browser.FindByXpath("//cite[text()='" + comment.User + "']").Count() == 1) { return true; } else { return false; }

        }



        internal static ReadOnlyCollection<IWebElement> GetComments(Comment comment)

        {

            return Browser.FindByXpath("//cite[text()='" + comment.User + "']");

        }



        internal static int CommentsFound(Comment comment)

        {

            return Browser.FindByXpath("//cite[text()='" + comment.User + "']").Count();

        }

    }

}