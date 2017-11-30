using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using Xunit;



namespace Wordpress

{

    public class AddingBlogPostTests : IDisposable

    {

        [Fact]

        public void CanAddPost()

        {

            MainPage.Open();



            var credentials = new credentialss



            {



                Pasword = "P@ssw0rd1",



                User = "autotestdotnet@gmail.com"



            };

            Login.LogToURl(string User);
            
        }




        public void Dispose()

        {

            Browser.Close();

        }

    }

}
