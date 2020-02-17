using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConvexFlatFigureCalculator
{
    public partial class ResultWindow : Form
    {
        const int Clearance = 20;
        readonly Font font = new Font(FontFamily.GenericMonospace, 15, FontStyle.Bold);

        public ResultWindow()
        {
            InitializeComponent();

            DrawShape();
        }

        void DrawShape()
        {
            var points = Calculator.Instance.Points;

            //Подгон под размер окна
            int xSizeBox = ShapeBox.Width - 2 * Clearance;
            int ySizeBox = ShapeBox.Height - 2 * Clearance;

            int xSizeShape = points.Max(p => p.P.X) - points.Min(p => p.P.X);
            int ySizeShape = points.Max(p => p.P.Y) - points.Min(p => p.P.Y);

            float k = Math.Min((float)xSizeBox / xSizeShape, (float)ySizeBox / ySizeShape);

            Bitmap bmp = new Bitmap(ShapeBox.Width, ShapeBox.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                Pen pen = new Pen(Color.Orange, 2);

                //За 2 прохода, чтобы буквы не перекрывались
                foreach (var pair in Calculator.Instance.Pairs)
                    g.DrawLine(pen, Clearance + (pair.P1.P.X) * k, Clearance + (pair.P1.P.Y) * k, Clearance + (pair.P2.P.X) * k, Clearance + (pair.P2.P.Y) * k);

                foreach (var pair in Calculator.Instance.Pairs)
                    g.DrawString(pair.P1.Ch.ToString(), font, new SolidBrush(Color.Black), new Point((int)(pair.P1.P.X * k + Clearance), (int)(pair.P1.P.Y * k + Clearance)));
            }

            ShapeBox.Image = bmp;
        }

        private void Btn_Calc_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(SquareBox.Text, out double squareSet))
            {
                MessageBox.Show("Введено некорректное значение площади.");
                return;
            }

            if (RBtn_sot.Checked)
                squareSet *= 100;

            double squareCalced = Calculator.Instance.ShapeSquareCalc();

            //Площади относятся как квадраты длин сторон!
            double k = Math.Pow(squareSet / squareCalced, 0.5);


            StringBuilder sb = RBtn_sot.Checked ?
                new StringBuilder($"Расчетная площадь {squareCalced * k * k / 100} соток\r\n") :
                new StringBuilder($"Расчетная площадь {squareCalced * k * k } м2\r\n");

            foreach (var p in Calculator.Instance.Pairs)
            {
                sb.AppendLine($"{p.String} = {p.Vector * k} м");
            }

            ResultBox.Text = sb.ToString();
        }

        private void RBtn_M2_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtn_M2.Checked)
                RBtn_sot.Checked = false;
        }

        private void RBtn_sot_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtn_sot.Checked)
                RBtn_M2.Checked = false;
        }
    }
}
