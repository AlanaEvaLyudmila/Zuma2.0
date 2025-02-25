using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zuma2._0
{
    public partial class MainForm : Form
    {
        List <Color> ballColor = new List <Color> ();
        Color CurrentBall;
        int sizeBall = 40;
        int trackBall = 10;
        Random random = new Random ();
        public MainForm()
        {
            InitializeComponent();
            for (int i = 0; i < trackBall; i++)
            {
                ballColor.Add(GetRandomColor());
            }
            NewBall();
        }

        void RemoveBalls()
        {
            for (int i = 0; i < ballColor.Count - 2 ; i++)
            {
                if(ballColor[i]==ballColor[i+1]&&ballColor[i]==ballColor[i+2])
                {
                    ballColor.RemoveRange(i, 3);
                    i = Math.Max(i - 3, -1);
                }
            }
        }
        void NewBall()
        {
            CurrentBall = GetRandomColor();
            labelColorBall.BackColor = CurrentBall;

        }

        Color GetRandomColor()
        {
            Color [] Palette = {Color.Red, Color.Green, Color.Blue, Color.Yellow};
            return Palette[random.Next(Palette.Length)];   
        }
        private void panelBalls_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < ballColor.Count; i++)
            {
                var brush = new SolidBrush(ballColor[i]);
                e.Graphics.FillEllipse(brush, i * sizeBall, 0, sizeBall, sizeBall);
            }
        }

        private void panelBalls_MouseClick(object sender, MouseEventArgs e)
        {
            int InsertIndex = e.X/ sizeBall;
            if(InsertIndex >= 0 && InsertIndex<=ballColor.Count )
            {
                ballColor.Insert(InsertIndex,CurrentBall);
                panelBalls.Invalidate();
                RemoveBalls();
                NewBall();
            }
        }

    }
}
