using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace VBS.Custome_Controls
{
    class Custome_button : Button
    {
        private int borderSize = 0;
        private int borderRadius = 20;

        private Color borderBtnColor = Color.Violet;

        public Color BorderBtnColor
        {
            get { return borderBtnColor; }
            set
            {
                borderBtnColor = value;
                this.Invalidate();
            }
        }

        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        public int BorderRaius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        public Custome_button()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(130, 30);
            this.BackColor = Color.White;
            this.ForeColor = Color.Violet;
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
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 0.3F))
                using (Pen penSurafce = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderBtnColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurafce, pathSurface);

                    if (borderSize >= 1)
                    {
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }

            else
            {
                this.Region = new Region(rectSurface);
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderBtnColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
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
