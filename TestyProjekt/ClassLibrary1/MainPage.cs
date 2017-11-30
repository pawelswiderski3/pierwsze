using System;

namespace Wordpress
{
    internal class MainPage
    {
        private static string Url = "https://autotestdotnet.wordpress.com/wp-admin/";
        internal static void Open()
        {
            Browser.NavigateTo(Url);
        }
    }
}