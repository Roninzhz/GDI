﻿using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GDI
{
    public partial class _6_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Bitmap myImage = new Bitmap(400, 200);
            Graphics gr = Graphics.FromImage(myImage);
            Pen pen = new Pen(Color.Red, 2);
            gr.Clear(Color.WhiteSmoke);
            Font font = new Font("黑体",20);
            Brush brush = new SolidBrush(Color.Blue);
            gr.DrawString("ASP.NET程序设计",font, brush, 100, 20);
            gr.FillRectangle(brush, 70, 70, 150, 100);
            brush = new SolidBrush(Color.YellowGreen);
            gr.FillEllipse(brush, 70, 70, 150, 100);
            brush = new SolidBrush(Color.Pink);
            Point[] pts = new Point[]
            {
                new Point(300,100),
                new Point(330,120),
                new Point(300,140),
                new Point(270,140),
                new Point(240,120),
                new Point(270,100)
            };
            gr.FillPolygon(brush, pts);
            myImage.Save(Response.OutputStream, System.Drawing.Imaging.ImageFormat.Gif);
            pen.Dispose();
            gr.Dispose();
            myImage.Dispose();
        }
    }
}