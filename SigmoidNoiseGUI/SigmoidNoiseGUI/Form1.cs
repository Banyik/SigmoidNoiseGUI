using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using NCalc;

namespace SigmoidNoiseGUI
{
    public partial class SN : Form
    {
        public SN()
        {
            InitializeComponent();
        }

        public int seed;
        public double offsetX;
        public double offsetY;
        public double[,] mat1;
        public double[,] mat2;
        public int sizeX;
        public int sizeY;

        public double startX = 1;
        public double startY = 1;

        public bool generateOnStart;


        public double waterTreshold;
        public double beachTreshold;
        public double grassTreshold;

        public bool shift;
        bool genReady = false;
        bool firstOffset = true;

        public int coordX = 0;
        public int coordY = 0;

        Random rnd = new Random();

        private void Generate()
        {
            if (randomSeedCheckBox.Checked || seedBox.Text == string.Empty)
            {
                seedBox.Text = rnd.Next(int.MinValue, int.MaxValue).ToString();
            }
            rnd = new Random(Convert.ToInt32(seedBox.Text));
            CalculateNoise((int)xySize.Value, (int)xySize.Value);
        }

        public void SetOffset(int maxX, int maxY)
        {
            offsetX = rnd.Next(-maxX, maxX);
            offsetY = rnd.Next(-maxY, maxY);
        }
        public void CalculateNoise(int x, int y)
        {
            SetOffset(x, y);
            mat1 = new double[x, y];
            mat2 = new double[x, y];
            double max = double.MinValue;
            if (showFirstFunction.Checked)
            {
                for (int i = coordX; i < coordX + x; i++)
                {
                    for (int j = coordY; j < coordY + y; j++)
                    {
                        double z = SetHeight(i, j, x, y, 1);
                        if (z > max)
                        {
                            max = z;
                        }
                        mat1[i - coordX, j - coordY] = z;
                    }
                }
                for (int k = 0; k < smoothness.Value; k++)
                {
                    for (int i = 0; i < x; i++)
                    {
                        for (int j = 0; j < y; j++)
                        {
                            Normalize(i, j, max, x, y, 1);
                        }
                    }
                }
            }
            if (showSecondFunction.Checked)
            {
                for (int i = coordX; i < coordX + x; i++)
                {
                    for (int j = coordY; j < coordY + y; j++)
                    {
                        double z = SetHeight(i, j, x, y, 2);
                        if (z > max)
                        {
                            max = z;
                        }
                        mat2[i - coordX, j - coordY] = z;
                    }
                }
                for (int k = 0; k < smoothness.Value; k++)
                {
                    for (int i = 0; i < x; i++)
                    {
                        for (int j = 0; j < y; j++)
                        {
                            Normalize(i, j, max, x, y, 2);
                        }
                    }
                }
            }
            canvas.Invalidate();
        }

        public void Normalize(int x, int y, double max, int rows, int cols, int matNum)
        {
            int count = 0;
            double avg = 0;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (i == 0 && j == 0) continue;
                    if (x + i > 0 && x + i < rows && y + j > 0 && y + j < cols)
                    {
                        if(matNum == 1)
                        {
                            avg += mat1[x + i, y + j];
                        }
                        else
                        {
                            avg += mat2[x + i, y + j];
                        }
                        count++;
                    }
                }
            }

            if (count > 0)
            {
                if (matNum == 1)
                {
                    mat1[x, y] = avg / count;
                }
                else 
                {
                    mat2[x, y] = avg / count;
                }
            }
        }
        public double SetHeight(double currX, double currY, double maxX, double maxY, int function)
        {
            double x = (double)xStart.Value;
            double y = (double)yStart.Value;
            currX += offsetX;
            currY += offsetY;
            for (int i = 0; i < repetition.Value; i++)
            {
                currX += offsetX / maxX;
                currY -= offsetY / maxY;
                
                double ran = (currX + currY) * Math.PI;
                if (ran == 0)
                {
                    ran = 0.1f;
                }
                if (currX == 0)
                {
                    currX = 1;
                }
                if (currY == 0)
                {
                    currY = 1;
                }
                x += Sigmoid(Math.Sin((currX * offsetX * ran) / (double)repetition.Value * ran),function);
                y += Sigmoid(Math.Cos((currY * offsetY * ran) * (double)repetition.Value * ran),function);
            }
            double value = Math.Cos(x + y) + Sigmoid(offsetX / maxX * (double)repetition.Value, function);

            double z = Sigmoid(value, function);
            return z;
        }

        public double Sigmoid(double x, int function)
        {
            double y = 0;
            switch (function)
            {
                case 1:
                    y = 1 / (1 + Math.Pow(Math.Exp(1), -x));
                    break;
                case 2:
                    y = 0.5f + ((x / 2f) / (1f + Math.Abs(x)));
                    break;
                case 3:
                    y = 0.5f + ((x / 2) / (Math.Sqrt(0.05 + Math.Pow(x, 2))));
                    break;
                default:
                    y = 0;
                    break;
            }
            return y;

        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            Generate();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            if (showFirstFunction.Checked && showSecondFunction.Checked)
            {
                for (int i = 0; i < mat1.GetLength(0); i++)
                {
                    for (int j = 0; j < mat1.GetLength(1); j++)
                    {
                        var brush = new SolidBrush(Color.FromArgb(255, (int)(255 * Math.Abs(mat1[i, j] - mat2[i, j])), (int)(255 * Math.Abs(mat1[i, j] - mat2[i, j])), (int)(255 * Math.Abs(mat1[i, j] - mat2[i, j]))));
                        e.Graphics.FillRectangle(brush, i, j, 1, 1);
                    }
                }
            }
            else if (showFirstFunction.Checked)
            {
                for (int i = 0; i < mat1.GetLength(0); i++)
                {
                    for (int j = 0; j < mat1.GetLength(1); j++)
                    {
                        var brush = new SolidBrush(Color.FromArgb(255, (int)(255 * mat1[i,j]), (int)(255 * mat1[i, j]), (int)(255 * mat1[i, j])));
                        e.Graphics.FillRectangle(brush, i, j, 1, 1);
                    }
                }
            }
            else if (showSecondFunction.Checked)
            {
                for (int i = 0; i < mat1.GetLength(0); i++)
                {
                    for (int j = 0; j < mat1.GetLength(1); j++)
                    {
                        var brush = new SolidBrush(Color.FromArgb(255, (int)(255 * mat2[i, j]), (int)(255 * mat2[i, j]), (int)(255 * mat2[i, j])));
                        e.Graphics.FillRectangle(brush, i, j, 1, 1);
                    }
                }
            }
        }

        private void graphCanvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Black, new Point(0, graphCanvas.Height / 2), new Point(graphCanvas.Width, graphCanvas.Height / 2));
            e.Graphics.DrawLine(Pens.Black, new Point(graphCanvas.Width / 2, 0), new Point(graphCanvas.Width / 2, graphCanvas.Height));
            if(showFirstFunction.Checked)
                DrawSigmoid((int)firstFunctionNumeric.Value, Brushes.Blue, e);
            if(showSecondFunction.Checked)
                DrawSigmoid((int)secondFunctionNumeric.Value, Brushes.Red, e);
        }

        void DrawSigmoid(int type, Brush color, PaintEventArgs e)
        {
            float scaleX = 0.025f;

            for (float i = -graphCanvas.Width / (2f * scaleX); i < graphCanvas.Width / (2f * scaleX); i += 0.1f)
            {
                float x = i * scaleX;
                float y = (float)Sigmoid(x, type);
                
                float adjustedY = (graphCanvas.Height - 1) - (graphCanvas.Height - 1) * y;
                e.Graphics.FillRectangle(color, i + graphCanvas.Width / 2f, adjustedY, 1, 1);
            }
        }

        private void showFirstFunction_CheckedChanged(object sender, EventArgs e)
        {
            graphCanvas.Invalidate();
        }

        private void showSecondFunction_CheckedChanged(object sender, EventArgs e)
        {
            graphCanvas.Invalidate();

        }

        private void firstFunctionNumeric_ValueChanged(object sender, EventArgs e)
        {
            graphCanvas.Invalidate();
        }

        private void secondFunctionNumeric_ValueChanged(object sender, EventArgs e)
        {
            graphCanvas.Invalidate();
        }
    }
}
