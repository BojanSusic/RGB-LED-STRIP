using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using Rectangle = System.Drawing.Rectangle;
using System.ComponentModel;
namespace WindowsFormsApp2
{
    class CTab: TabControl
    {
        private int angle = 90;
        private Color pathColor = Color.Red;
        public Color PathColor { get { return pathColor; } set { pathColor = value; } }
        public CTab()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.Padding = new System.Drawing.Point(28, 10);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            this.PaintTransparentBackground(pe.Graphics, this.ClientRectangle);
            this.draw(pe);
        }

        protected void draw(PaintEventArgs e)
        {
            int index;
            for (index = 0; index < this.TabCount; index++)
            {
                Rectangle rc = GetTabRect(index);
                Color c1 = this.PathColor;
                LinearGradientBrush br = new LinearGradientBrush(rc, c1, c1, angle);
                GraphicsPath path = this.GetPath(index);
                e.Graphics.FillPath(br, GetPath(index));
                PaintTabText(e.Graphics, index);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            for (int i = 0; i < this.TabPages.Count; i++)
            {
                GraphicsPath path = GetPath(i);
                if (path.IsVisible(e.Location))
                {
                    this.SelectTab(i);
                }

            }
        }

        private GraphicsPath GetPath(int index)
        {
            GraphicsPath path = new GraphicsPath();
            path.Reset();
            Rectangle rect = this.GetTabRect(index);
            int x = 15;
            if (index % 2 == 0)
            {
                path.AddLine(rect.Left + 2, rect.Bottom, rect.Left + 2, rect.Top);
                path.AddLine(rect.Left + 2, rect.Top, rect.Right + x, rect.Top);
                path.AddLine(rect.Right + x, rect.Top, rect.Right - x, rect.Bottom);
                path.AddLine(rect.Right - x, rect.Bottom, rect.Left, rect.Bottom);
            }
            else
            {
                path.AddLine(rect.Left - x + 2, rect.Bottom, rect.Left + x + 2, rect.Top);
                path.AddLine(rect.Left + 2 + x, rect.Top, rect.Right, rect.Top);
                path.AddLine(rect.Right, rect.Top, rect.Right, rect.Bottom);
                path.AddLine(rect.Right, rect.Bottom, rect.Left + 2 - x, rect.Bottom);
            }
            return path;
        }

        protected void PaintTransparentBackground(Graphics g, Rectangle clipRect)
        {
            if ((this.Parent != null))
            {
                clipRect.Offset(this.Location);
                PaintEventArgs e = new PaintEventArgs(g, clipRect);
                GraphicsState state = g.Save();
                try
                {
                    g.TranslateTransform((float)-this.Location.X, (float)-this.Location.Y);
                    this.InvokePaintBackground(this.Parent, e);
                    this.InvokePaint(this.Parent, e);
                }

                finally
                {
                    g.Restore(state);
                    clipRect.Offset(-this.Location.X, -this.Location.Y);
                }
            }
            else
            {
                LinearGradientBrush backBrush = new LinearGradientBrush(this.Bounds, SystemColors.ControlLightLight, SystemColors.ControlLight, LinearGradientMode.Vertical);
                g.FillRectangle(backBrush, this.Bounds);
                backBrush.Dispose();
            }
        }

        protected override void OnSelecting(TabControlCancelEventArgs e)
        {
            GraphicsPath p = GetPath(0);
        }

        private void PaintTabText(System.Drawing.Graphics graph, int index)
        {
            Rectangle rect = this.GetTabRect(index);
            TabPage tab = TabPages[index];
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            format.Trimming = StringTrimming.EllipsisCharacter;
            SolidBrush forebrush = new SolidBrush(TabPages[index].ForeColor);
            graph.DrawString(tab.Text, tab.Font, new SolidBrush(tab.ForeColor), rect, format);

        }
    }
}
