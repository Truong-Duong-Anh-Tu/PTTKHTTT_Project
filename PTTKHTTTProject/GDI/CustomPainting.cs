using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace PTTKHTTTProject.GDI
{
    public class FancyPanel : Panel
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int BorderRadius { get; set; } = 15;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color StartColor { get; set; } = Color.LightBlue;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color EndColor { get; set; } = Color.LightBlue;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color ShadowColor { get; set; } = Color.FromArgb(60, Color.Black);
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ShadowDepth { get; set; } = 10;

        private System.Windows.Forms.Timer glowTimer;
        private int glowAlpha = 0;
        private bool glowIncreasing = true;

        public FancyPanel()
        {
            DoubleBuffered = true;
            glowTimer = new System.Windows.Forms.Timer { Interval = 50 };
            glowTimer.Tick += (s, e) =>
            {
                if (glowIncreasing) glowAlpha += 5;
                else glowAlpha -= 5;
                if (glowAlpha >= 150) glowIncreasing = false;
                else if (glowAlpha <= 0) glowIncreasing = true;
                Invalidate();
            };
            glowTimer.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var rect = Rectangle.Inflate(ClientRectangle, -ShadowDepth, -ShadowDepth);
            using var path = GetRoundedPath(rect, BorderRadius);

            // Shadow bằng PathGradientBrush
            using (var shadowBrush = new PathGradientBrush(path))
            {
                shadowBrush.CenterColor = ShadowColor;
                shadowBrush.SurroundColors = new[] { Color.Transparent };
                shadowBrush.FocusScales = new PointF(0.5f, 0.5f);
                e.Graphics.FillPath(shadowBrush, path);
            }

            // Gradient fill
            using (var brush = new LinearGradientBrush(rect, StartColor, EndColor, LinearGradientMode.Vertical))
                e.Graphics.FillPath(brush, path);

            // Border glow animation
            using (var pen = new Pen(Color.FromArgb(glowAlpha, Color.Yellow), 3))
                e.Graphics.DrawPath(pen, path);
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            int d = radius * 2;
            var path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

    }
}
