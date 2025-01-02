using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.ComponentModel.Design;
using System.ComponentModel;

namespace VBS.Custome_Controls
{
    class Custome_Panel : Panel
    {
        private int borderRadius = 0;
        private int borderSize = 1;
        private Color borderColor = Color.Indigo;

        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }

            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }


        public void Custom_Panel()
        {

            this.Size = new Size(130, 30);
            this.BackColor = Color.White;
            this.ForeColor = Color.Violet;
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            this.Size = new Size(this.Width, this.Height);
        }

        private GraphicsPath GetFigurePath(RectangleF rectBtn, float radius)
        {
            GraphicsPath fullPath = new GraphicsPath();
            fullPath.StartFigure();
            fullPath.AddArc(rectBtn.X, rectBtn.Y, radius, radius, 180, 90);
            fullPath.AddArc(rectBtn.Width - radius, rectBtn.Y, radius, radius, 270, 90);
            fullPath.AddArc(rectBtn.Width - radius, rectBtn.Height - radius, radius, radius, 0, 90);
            fullPath.AddArc(rectBtn.X, rectBtn.Height - radius, radius, radius, 90, 90);
            fullPath.CloseFigure();

            return fullPath;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            if (borderRadius > 2)
            {

                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 0.2F))
                using (Pen penSurafce = new Pen(this.Parent.BackColor, 3))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurafce, pathSurface);
                }

            }

            else
            {
                this.Region = new Region(rectSurface);
            }

        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                this.Invalidate();
            }
        }
    }
}
