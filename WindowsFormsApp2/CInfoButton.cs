using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class CInfoButton:Button
    {
        private GraphicsPath gpath;
        Point[] mainPoints = new Point[4];
        Point[] borderPoints = new Point[8];
        Color borderColor = Color.Red;

        public CInfoButton() : base()
        {
            this.Size = new System.Drawing.Size(50, 50);

        }
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }
        private void SetBorderPoints()
        {

            Rectangle rect = this.DisplayRectangle;
            borderPoints[0] = new Point(rect.Right, rect.Bottom - 10);//1
            borderPoints[1] = new Point(rect.Right, rect.Bottom);//2
            borderPoints[2] = new Point(0, (int)Math.Round(0.8 * rect.Bottom));//3
            borderPoints[3] = new Point(0, (int)Math.Round(0.2 * rect.Bottom));//4
            borderPoints[4] = new Point(rect.Right, 0);//5
            borderPoints[5] = new Point(rect.Right, 10);//6
            borderPoints[6] = new Point(7, (int)Math.Round(0.2 * rect.Bottom) + 3);//7
            borderPoints[7] = new Point(7, (int)Math.Round(0.8 * rect.Bottom) - 3);//8
        }

        private void SetMainPoints()
        {
            Rectangle rect = this.DisplayRectangle;
            mainPoints[0] = new Point(rect.Right, 5);
            mainPoints[1] = new Point(rect.Right, rect.Bottom - 5);
            mainPoints[2] = new Point(3, (int)Math.Round(0.8 * rect.Bottom));
            mainPoints[3] = new Point(3, (int)Math.Round(0.2 * rect.Bottom));
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle buttonRect = this.ClientRectangle;
            SetBorderPoints();
            SetMainPoints();
            SolidBrush sBrush = new SolidBrush(this.BackColor);
            SolidBrush bBrush = new SolidBrush(BorderColor);
            g.FillPolygon(sBrush, mainPoints);
            SetClickableRegion();
            if (base.BackgroundImage != null)
                g.DrawImage(base.BackgroundImage, new Point(0, 0));
            WriteText(g, buttonRect);
            g.FillPolygon(bBrush, borderPoints);
        }
        protected virtual void SetClickableRegion()
        {
            SetMainPoints();
            SetBorderPoints();
            gpath = new GraphicsPath();
            gpath.AddPolygon(mainPoints);
            this.Region = new Region(gpath);
        }
        private void WriteText(Graphics g, Rectangle buttonRect)
        {
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            g.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), buttonRect, stringFormat);
        }
    }
}
