using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Test_Page_Object
{
    public class AddingCommentsTest : IDisposable
    {
        [Fact]
        public void CanAddCommentToTheBlogNote()
        {
            MainPage.GoTo();

            MainPage.OpenFirstNote();
            NotePage.AddComment(new Comment
            {
                Text = "lorem ipsum dolor sit",
                Mail = "test@test",
                User = "białko"

            });
            
            //dodaj komentarz
            //sprawdź czy komentarz się dodał

           

        }

        public void Dispose()
        {
            Browser.Close();
        }
    }
}
