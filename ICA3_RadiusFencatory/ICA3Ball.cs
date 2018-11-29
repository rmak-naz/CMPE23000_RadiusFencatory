using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDIDrawer;
using System.Drawing;

namespace ICA3_RadiusFencatory
{
    class ICA3Ball
    {
        private static CDrawer _canvas = null;
        private const int ballRadius = 100;
        private Point _pos;
        private Color _color;

        public ICA3Ball(CDrawer canvas)
        {
            _canvas = canvas;
            _color = bColor;
        }

        public ICA3Ball(CDrawer canvas, Point pos)
            : this(canvas)
        {
            _pos = pos;
        }

        public Color bColor { get; private set; } = Color.Yellow;

        public Point bCenter
        {
            private set
            {
                Point _pos = value;
            }
            get
            {
                return _pos;
            }
        }

        public static double GetDisplacement(ICA3Ball ball1, ICA3Ball ball2)
        {
            double displacement;

            displacement = Math.Sqrt(Math.Pow((ball2._pos.X - ball1._pos.X), 2) + Math.Pow((ball2._pos.Y - ball1._pos.Y), 2));
            ++DisplacementCalls;

            return displacement;
        }

        public void MarkOverlap(ICA3Ball oBall)
        {
            double displacement = GetDisplacement(this, oBall);
            if (displacement <= ballRadius)
            {
                bColor = Color.Red;
                _color = bColor;

            }            
        }

        public static int DisplacementCalls { get; private set; } = 1;

        public void Render()
        {
            _canvas.AddCenteredEllipse(_pos.X, _pos.Y, ballRadius, ballRadius, bColor,2, Color.Black);
            _canvas.AddText(DisplacementCalls.ToString(), ballRadius / 4, _pos.X, _pos.Y, 0, 0, Color.Black);
        }
    }
}
