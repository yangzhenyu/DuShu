using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wap.Books
{
    public partial class Book : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public static void Main(String[] args)
        {

            Console.WriteLine(GetNumber(9));  //传入N  
            Console.Read();
        }
        private static int GetNumber(int index)
        {
            if (index <= 0)         //控制负数和0  
            {
                return 0;
            }
            int a1 = 1;
            int a2 = 1;
            int count = 3;          //递归(循环)条件  
            RecursionGetNumber(index, a1, ref a2, count);
            return a2;
        }

        //递归子方法  
        private static void RecursionGetNumber(int index, int a1, ref int a2, int count)
        {

            if (index >= count)
            {
                a2 = a1 + a2;
                a1 = a2 - a1;
                count++;
                RecursionGetNumber(index, a1, ref a2, count);
            }
        }



    }

}