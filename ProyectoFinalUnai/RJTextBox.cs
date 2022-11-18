using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProyectoFinalUnai
{
    public partial class RJTextBox : UserControl
    {
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedstyle = false;
        private int borderRadius = 0;
        public RJTextBox()
        {
            InitializeComponent();
        }
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; 
                this.Invalidate(); }
        }
        public int BoderSize
        {
            get { return borderSize; }
            set { borderSize = value; 
                this.Invalidate(); }
        }
        public bool Underlinedstyle
        {
            get { return underlinedstyle; }
            set { underlinedstyle = value; 
                this.Invalidate(); }
        }
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();
                }
            }
        }
        [Category("RJ Avanzado")]
        public bool passwordChar
        {
            get { return TxtRJ.UseSystemPasswordChar; }
            set { TxtRJ.UseSystemPasswordChar = value; }
        }
        [Category("RJ Avanzado")]
        public String Texts
        {
            get { return TxtRJ.Text; }
            set { TxtRJ.Text = value; }
        }
        [Category("RJ Avanzado")]
        public Boolean AcceptReturn
        {
            get { return TxtRJ.AcceptsReturn; }
            set { TxtRJ.AcceptsReturn = value; }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;

            if (borderRadius > 1)
            {
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smooth = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = GetFiguraPath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFiguraPath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smooth))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(pathBorderSmooth);
                    if (borderRadius > 15)
                    {
                        SetTextBoxRoundedRegion();
                    }
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    if (Underlinedstyle)
                    {
                        graphics.DrawPath(penBorderSmooth, pathBorderSmooth);
                        graphics.SmoothingMode = SmoothingMode.None;
                        graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else
                    {
                        graphics.DrawPath(penBorderSmooth, pathBorderSmooth);
                        graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else
            {
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    if (Underlinedstyle)
                    {
                        graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else
                    {
                        graphics.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }
                }
            }
        }
        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            pathTxt = GetFiguraPath(TxtRJ.ClientRectangle, borderSize * 2);
            TxtRJ.Region = new Region(pathTxt);
        }
        private GraphicsPath GetFiguraPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
            {
                UpdateAltura();
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateAltura();
        }
        private void UpdateAltura()
        {
            if (TxtRJ.Multiline == false)
            {
                int txtAltura = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                TxtRJ.Multiline = true;
                TxtRJ.MinimumSize = new Size(0, txtAltura);
                TxtRJ.Multiline = false;

                this.Height = TxtRJ.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }
    }
}