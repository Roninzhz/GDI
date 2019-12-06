using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GDI
{
    public partial class _6_4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int maxvalue = 20;
            int minvalue = 1;
            int count = 20;
            Random rand = new Random();
            int length = maxvalue - minvalue + 1;
            byte[] keys = new byte[length];
            rand.NextBytes(keys);
            int[] items = new int[length];
            for (int i = 0; i < length; i++)
                items[i] = i + minvalue;
            Array.Sort(keys, items);
            int[] result = new int[count];
            Array.Copy(items, result, count);
            for (int i = 0; i < result.Length; i++)
                Label1.Text += " " + result[i].ToString();
        }
    }
}