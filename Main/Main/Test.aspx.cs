using System;
using System.Web.UI;

namespace Main
{
    public partial class Test : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void test()
        {
            string a = "str9";
            string b = "str9";

            string s1 = "abc";
            s1 = "123" + s1 + "456";
        }
    }
}