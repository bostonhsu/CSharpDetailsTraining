using System;
using System.Web.UI;

namespace Main
{
    public partial class Test : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            test1();
        }

        private void test()
        {
            string a = "str9";
            string b = "str9";

            string s1 = "abc";
            s1 = "123" + s1 + "456";
        }

        private static void test1()
        {
            Ip ip = "192.168.1.1";
            Console.WriteLine(ip.ToString());
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            test1();
        }
    }
}