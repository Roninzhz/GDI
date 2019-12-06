using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GDI
{
    public partial class _6_3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(600, 800);
            Graphics gr = Graphics.FromImage(image);
            gr.FillRectangle(Brushes.WhiteSmoke, 1, 1, 600, 800);
            Font font = new Font("宋体", 12, FontStyle.Regular);
            gr.DrawString("显示现有图片", font, Brushes.Black, 600, 800);
            string filepath = Server.MapPath("image/5.png");
            System.Drawing.Image img = System.Drawing.Image.FromFile(filepath);
            gr.DrawImage(img, 10,10, 600, 800);
            image.Save(Response.OutputStream, ImageFormat.Gif);
            gr.Dispose();
            image.Dispose();
        }
    }
}