using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratornaya_10
{
    public partial class Laba10 : Form
    {
        private Color color = Color.Red;
        public Laba10()
        {
            InitializeComponent();
        }

        private void DrawCircle()
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics graphics = Graphics.FromImage(bmp);
            Pen pen = new Pen(color, (int)SizeLineUpDown.Value);
            Brush brush = new SolidBrush(color);
            graphics.DrawEllipse(pen, 180, 30, 300, 300);
            graphics.FillEllipse(brush, 180, 30, 300, 300);
            pictureBox.Image = bmp;
        }

        private void DrawRectangle()
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics graphics = Graphics.FromImage(bmp);
            Pen pen = new Pen(color, (int)SizeLineUpDown.Value);
            Brush brush = new SolidBrush(color);
            graphics.DrawRectangle(pen, 30, 30, 500, 300);
            graphics.FillRectangle(brush, 30, 30, 500, 300);
            pictureBox.Image = bmp;
        }

        private void DrawTriangle()
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics graphics = Graphics.FromImage(bmp);
            Pen pen = new Pen(color, (int)SizeLineUpDown.Value);
            graphics.DrawLine(pen, 30, 376, 280, 30);
            graphics.DrawLine(pen, 280, 30, 530, 376);
            graphics.DrawLine(pen, 30, 376, 530, 376);
            Brush brush = new SolidBrush(color);
            Point[] point = new Point[3];
            point[0] = new Point(30, 376);
            point[1] = new Point(280, 30);
            point[2] = new Point(530, 376);
            graphics.DrawPolygon(pen, point);
            graphics.FillPolygon(brush, point);
            pictureBox.Image = bmp;
        }

        private void DrawSnowman()
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics graphics = Graphics.FromImage(bmp);
            Pen pen = new Pen(color, (int)SizeLineUpDown.Value);
            Brush brush = new SolidBrush(color);
            graphics.DrawEllipse(pen, 560 / 3-5, 406 / 2 - 10, 200, 200);
            graphics.FillEllipse(brush, 560 / 3-5, 406 / 2 - 10, 200, 200);
            graphics.DrawEllipse(pen, 530 / 3 + 44, 406 / 4 + 10, 120, 120);
            graphics.FillEllipse(brush, 530 / 3 + 44, 406 / 4 + 10, 120, 120);
            graphics.DrawEllipse(pen, 530 / 2 - 25, 50, 80, 80);
            graphics.FillEllipse(brush, 530 / 2 - 25, 50, 80, 80);
            graphics.DrawRectangle(pen, 530 / 2 - 5, 10, 40, 45);
            graphics.FillRectangle(brush, 530 / 2 - 5, 10, 40, 45);
            pictureBox.Image = bmp;
        }

        private void DrawHouse()
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics graphics = Graphics.FromImage(bmp);
            Pen pen = new Pen(color, (int)SizeLineUpDown.Value);
            Brush brush = new SolidBrush(color);
            Point[] point = new Point[3];
            point[0] = new Point(30, 100);
            point[1] = new Point(280, 30);
            point[2] = new Point(530, 100);
            graphics.DrawPolygon(pen, point);
            graphics.FillPolygon(brush, point);
            graphics.DrawRectangle(pen, 30, 105, 500, 290);
            pictureBox.Image = bmp;

        }

        private void CheckFunction()
        {
            if (CircleRadioButton.Checked)
            {
                DrawCircle();
                return;
            }
            else if (SquareRadioButton.Checked)
            {
                DrawRectangle();
                return;
            }
            else if (TriangleRadioButton.Checked)
            {
                DrawTriangle();
                return;
            }
            else if (SnowmanRadioButton.Checked)
            {
                DrawSnowman();
                return;
            }
            else
            {
                DrawHouse();
                return;
            }
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            CheckFunction();
        }


        private void ColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog MyColorDialog = new ColorDialog();
            if (MyColorDialog.ShowDialog() == DialogResult.OK)
            {
                color = MyColorDialog.Color;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.Clear(Color.Transparent);
            pictureBox.Image = bmp;
        }
    }
}
