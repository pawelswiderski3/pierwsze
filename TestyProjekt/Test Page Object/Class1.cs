using PageObjcectTests;

using System;
using Test_Page_Object;
using Xunit;



namespace PageObjectTests

{

    public class AddingBlogCommentsTests : IDisposable

    {

        [Fact]

        public void CanAddCommentToTheBlogNote()

        {

            MainPage.Open();



            var comment = new Comment

            {

                Text = "Nie poddawaj się",

                Mail = Guid.NewGuid() + "@test.com",

                User = Guid.NewGuid().ToString()

            };



            MainPage.OpenFirstNote();

            NotePage.AddComment(comment);



            Assert.Equal(1, NotePage.CommentsFound(comment));

            Assert.Single(NotePage.GetComments(comment));

            Assert.True(NotePage.CommentExists(comment));

        }


        public void Dispose()

        {

            Browser.Close();

        }

    }

}