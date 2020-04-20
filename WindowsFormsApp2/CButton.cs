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
    enum Side{ 
        LEFT,
        RIGHT
    }
    class CButton:Button
    {
        // private int side;
        private Side side = WindowsFormsApp2.Side.LEFT;
        private GraphicsPath gpath;
        Point[] points = new Point[4];
        public CButton()
        {
            this.Size = new System.Drawing.Size(50, 50);
        }

        public Side Side
        {
            get { return side; }
            set { if (value == Side.LEFT) { side = value; } else side = Side.RIGHT; }
        }

        private void SetPoints()
        {
            if (side == 0)
            {
                points[0] = new Point((int)Math.Round(this.Width - (0.7 * this.Width)), 0);
                points[1] = new Point(this.Width, 0);
                points[2] = new Point(this.Width, this.Height);
                points[3] = new Point(0, this.Height);
            }
            else
            {
                points[0] = new Point(0, 0);
                points[1] = new Point(this.Width, 0);
                points[2] = new Point((int)Math.Round(this.Width - (0.3 * this.Width)), this.Height);
                points[3] = new Point(0, this.Height);
            }

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            Rectangle buttonRect = this.ClientRectangle;
            SetPoints();
            SolidBrush sBrush = new SolidBrush(this.BackColor);
            g.FillPolygon(sBrush, points);
            SetClickableRegion();
            WriteText(g, buttonRect);
        }
        protected virtual void SetClickableRegion()
        {
            SetPoints();
            gpath = new GraphicsPath();
            gpath.AddPolygon(points);
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
