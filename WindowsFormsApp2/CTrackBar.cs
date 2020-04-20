using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class CTrackBar: Control
    {

        public int thumbOffset = 0;
        private Rectangle Thumb;
        private bool ThumbFocused;
        private bool mouseDown = false;
        private bool iscrtano = false;
        private int maximum;
        private Color boja;

        [Description("Event fires when the Value property changes")]
        [Category("Action")]
        public event EventHandler ValueChanged;
        public CTrackBar()
        {
            Inicijalizacija();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
        [Description("Set Slider padding (inside margins: left & right or bottom & top)")]
        [Category("ColorSlider")]
        [DefaultValue(100)]
        public int Maximum
        {
            get { return maximum; }
            set { maximum = value; }
        }

        public int Vrijednost
        {
            get { return thumbOffset; }
        }
        private int ThumbOffset
        {
            get { return thumbOffset; }
            set
            {
                if (value < 0)
                    thumbOffset = 0;
                else if (value > Maximum)
                    thumbOffset = Maximum;
                else
                    thumbOffset = value;

                if (ValueChanged != null) ValueChanged(this, new EventArgs());
            }
        }
        public Color Boja
        {
            get { return boja; }
            set { boja = value; }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Inicijalizacija();
            Graphics g = e.Graphics;
            Rectangle channelBounds = new Rectangle(0, this.Height / 2 - 4, this.Width + 200, 8);
            SolidBrush sBrush = new SolidBrush(Boja);
            SolidBrush brush = new SolidBrush(Color.Black);
            LinearGradientBrush lgb = new LinearGradientBrush(channelBounds, Color.Black, Boja, 0f);
            g.FillRectangle(lgb, channelBounds);
            g.FillRectangle(brush, this.Thumb);
            if (this.Focused && this.ShowFocusCues)
                ControlPaint.DrawFocusRectangle(e.Graphics, this.ClientRectangle);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.Invalidate();

        }
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.Invalidate();
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            MouseEventArgs arg = (MouseEventArgs)e;
            this.ThumbOffset = arg.Location.X - 6;
            iscrtano = true;
            this.Invalidate();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            mouseDown = true;
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            mouseDown = false;

        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (mouseDown)
            {
                MouseEventArgs arg = (MouseEventArgs)e;
                this.ThumbOffset = arg.Location.X - 6;
                this.Invalidate();
            }
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                this.ThumbOffset += 5;
            }
            else if (e.KeyCode == Keys.Left)
            {
                this.ThumbOffset -= 5;
            }
            this.Invalidate();
        }
        private void Inicijalizacija()
        {
            Thumb.Size = new Size(7, this.Height);
            Thumb.Location = Point.Round(new PointF(0 + ThumbOffset, 0));
        }
    }
}
