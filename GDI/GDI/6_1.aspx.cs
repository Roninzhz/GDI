using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GDI
{
    public partial class _6_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Bitmap myImage = new Bitmap(400, 200);
            Graphics gr = Graphics.FromImage(myImage);
            Pen pen = new Pen(Color.Red, 2);
            gr.Clear(Color.WhiteSmoke);
            gr.DrawLine(pen, 0, 50, 400, 50);
            myImage.Save(Response.OutputStream, System.Drawing.Imaging.ImageFormat.Gif);
            pen.Dispose();
            gr.Dispose();
            myImage.Dispose();
        }
    }
}