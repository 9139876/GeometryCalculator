using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ConvexFlatFigureCalculator
{
    public partial class TransparentWindow : Form
    {
        HotKey hotKey = new HotKey();

        public TransparentWindow()
        {
            InitializeComponent();

            //Делаем окно невидимым
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.BackColor = Color.Red;
            this.TransparencyKey = this.BackColor;

            //Сворачиваем
            this.Visible = false;

            // Делаем невидимой иконку в трее
            NotifyIcon.Visible = false;

            // Прячем окно из панели
            this.ShowInTaskbar = false;

            // Делаем иконку в трее активной
            NotifyIcon.Visible = true;

        }

        private void HotKey_HotKeyPressed(object sender, KeyEventArgs e)
        {
            this.Visible = !this.Visible;
        }

        private void TransparentWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            hotKey?.Dispose();
        }

        readonly List<Point> points = new List<Point>();

        private void TransparentWindow_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                hotKey?.Dispose();
                hotKey = new HotKey
                {
                    KeyModifier = HotKey.KeyModifiers.None,
                    Key = Keys.Escape
                };

                hotKey.HotKeyPressed += HotKey_HotKeyPressed;
            }
            else
            {
                hotKey?.Dispose();
                hotKey = new HotKey
                {
                    KeyModifier = HotKey.KeyModifiers.Control,
                    Key = Keys.Q
                };

                hotKey.HotKeyPressed += HotKey_HotKeyPressed;

                Graphics g = this.CreateGraphics();

                g.Clear(this.BackColor);
                points.Clear();
            };
        }

        private void TransparentWindow_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();

            if (e.Button == MouseButtons.Right)
            {
                g.Clear(this.BackColor);

                if (points.Count >= 3)
                {
                    Calculator.Instance.SetPoints(points);
                    new ResultWindow().ShowDialog();
                    this.Visible = false;
                }

                points.Clear();
            }
            if (e.Button == MouseButtons.Left)
            {
                points.Add(new Point(e.X, e.Y));

                Pen drwaPen = new Pen(Color.Orange, 1);
                g.FillEllipse(new SolidBrush(Color.Orange), new Rectangle(e.X - 2, e.Y - 2, 5, 5));

                if (points.Count > 1)
                    g.DrawLine(drwaPen, points[points.Count - 2], points.Last());
            }
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

