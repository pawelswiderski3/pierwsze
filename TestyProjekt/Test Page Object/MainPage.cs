using System;

namespace Test_Page_Object
{
    internal class MainPage

    {
        private static string Url = "https://autotestdotnet.wordpress.com/";

        internal static void GoTo()
        {
            Browser.NavigateTo(Url);
        }
    }
}