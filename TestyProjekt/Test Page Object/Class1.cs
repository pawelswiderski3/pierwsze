using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Test_Page_Object
{
    public class AddingCommentsTest
    {
        [Fact]
        public void CanAddCommentToTheBlogNote()
        {
            MainPage.GoTo();

            //wejdź na strone bloga
            //otwórz pierwszą notkę
            //dodaj komentarz
            //sprawdź czy komentarz się dodał

        }
    }
}
