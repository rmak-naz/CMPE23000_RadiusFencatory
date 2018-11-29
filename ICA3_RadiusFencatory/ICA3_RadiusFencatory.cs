using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace ICA3_RadiusFencatory
{
    public partial class ICA3_RadiusFencatory : Form
    {
        static CDrawer canvas;
        List<ICA3Ball> ballList;

        public ICA3_RadiusFencatory()
        {
            InitializeComponent();
        }

        private void B_Play_Click(object sender, EventArgs e)
        {
            TimerClick.Enabled = true;
            canvas = new CDrawer(800, 600, false);
            ballList = new List<ICA3Ball>();
        }

        private void TimerClick_Tick(object sender, EventArgs e)
        {
            Point newClick = new Point(-1,-1);
            ICA3Ball newBall;

            
            if (canvas.GetLastMouseLeftClick(out newClick))
            {
                newBall = new ICA3Ball(canvas, newClick);
                canvas.Clear();
                for (int ballIndex = 0; ballIndex < ballList.Count(); ++ballIndex)
                {
                    ballList[ballIndex].MarkOverlap(newBall);
                }
                ballList.Add(newBall);

                foreach (ICA3Ball ball in ballList)
                {
                    ball.Render();
                }
                canvas.Render();
            }
            
        }
    }
}
