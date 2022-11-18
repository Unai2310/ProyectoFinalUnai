using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace ProyectoFinalUnai
{
    public class RJToggleButton : CheckBox
    {
        private Color onBackColor = Color.MediumSlateBlue;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;
        private Boolean solidState = true;

        public Color OnBackColor
        {
            get { return onBackColor; }
            set { onBackColor = value; this.Invalidate(); }
        }
        public Color OnToggleColor 
        {
            get { return onToggleColor; }
            set { onToggleColor = value; this.Invalidate(); }
        }
        public Color OffBackColor
        {
            get { return offBackColor; }
            set { offBackColor = value; this.Invalidate(); }
        }
        public Color OffToggleColor 
        {
            get { return offToggleColor; }
            set { offToggleColor = value; this.Invalidate(); }
        }
        public override String Text
        {
            get { return base.Text; }
            set { }
        }
        public Boolean SolidState
        {
            get { return solidState; }
            set { solidState = value; this.Invalidate(); }
        }
        public RJToggleButton()
        {
            this.MinimumSize = new Size(45, 22);
        }
        private GraphicsPath getFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rigthArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rigthArc, 270, 180);
            path.CloseFigure();
            return path;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if (this.Checked)
            {
                if (solidState)
                {
                    pevent.Graphics.FillPath(new SolidBrush(onBackColor), getFigurePath());
                }
                else
                {
                    pevent.Graphics.DrawPath(new Pen(OnBackColor, 2), getFigurePath());
                }
                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor), 
                    new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
            }
            else
            {
                if (solidState)
                {
                    pevent.Graphics.FillPath(new SolidBrush(offBackColor), getFigurePath());
                }
                else
                {
                    pevent.Graphics.DrawPath(new Pen(OffBackColor, 2), getFigurePath());
                }
                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor),
                    new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }
    }
}
