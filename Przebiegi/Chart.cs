using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przebiegi
{
    public struct DataPoint
    {
        public float X;
        public float Y;

        public DataPoint(float x, float y) : this() { X = x; Y = y; }
    };

    public partial class Chart : UserControl
    {
        private Rectangle canvasRect;
        private Rectangle marginRect;

        public DataPoint[] dataPoints;

        public float XAxisMin = -10;
        public float XAxisMax = 10;
        public float YAxisMin = -10;
        public float YAxisMax = 10;
        public float XAxisDelta = 1;
        public float YAxisDelta = 1;

        public Chart()
        {
            InitializeComponent();
        }

        // Przeliczanie punktu funkcji na pozycję na kanwie
        private float GetX(float x)
        {
            return marginRect.Left + (x - XAxisMin) / (XAxisMax - XAxisMin) * marginRect.Width;
        }

        private float GetY(float y)
        {
            return marginRect.Bottom - (y - YAxisMin) / (YAxisMax - YAxisMin) * marginRect.Height;
        }

        // Rysowanie lini pionowej z etykietą
        private void DrawVerticalLine(PaintEventArgs e, Pen pen, float value)
        {
            // Obiczanie pozycji X linii na kanwie
            float x = GetX(value);

            // Rysowanie linii poziomej
            e.Graphics.DrawLine(pen, x, marginRect.Top, x, marginRect.Bottom);

            // Pobieranie informacji o rozmiarze czcionki
            SizeF textSize = e.Graphics.MeasureString(value.ToString(), DefaultFont);

            // Definicja obszaru pola tekstowego
            Rectangle textRect = new Rectangle();
            textRect.X = (int) (x - textSize.Width / 2);
            textRect.Y = marginRect.Bottom;
            textRect.Width = (int) textSize.Width + 1;
            textRect.Height = marginRect.Top;

            // Definicja wyrównania tekstu
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            // Rysowanie tekstu w obszarze pola tekstowego
            e.Graphics.DrawString(value.ToString(), DefaultFont, Brushes.Black, textRect, stringFormat);
        }

        // Rysowanie lini poziomej z etykietą
        private void DrawHorizontalLine(PaintEventArgs e, Pen pen, float value)
        {
            // Obiczanie pozycji Y linii na kanwie
            float y = GetY(value);

            // Rysowanie linii pionowej
            e.Graphics.DrawLine(pen, marginRect.Left, y, marginRect.Right, y);

            // Pobieranie informacji o rozmiarze czcionki
            SizeF textSize = e.Graphics.MeasureString(value.ToString(), DefaultFont);

            // Definicja obszaru pola tekstowego
            Rectangle textRect = new Rectangle();
            textRect.X = canvasRect.Left;
            textRect.Y = (int)(y - textSize.Height / 2);
            textRect.Width = marginRect.Left;
            textRect.Height = (int) textSize.Height;

            // Definicja wyrównania tekstu
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            // Rysowanie tekstu w obszarze pola tekstowego
            e.Graphics.DrawString(value.ToString(), DefaultFont, Brushes.Black, textRect, stringFormat);
        }

        // Rysowanie osi i siatki
        private void DrawAxes(PaintEventArgs e)
        {
            // Definicje pisaków
            Pen penGray = new Pen(Color.Gray, 1);
            Pen penBlack = new Pen(Color.Black, 3);

            // Rysowanie linii siatki na prawo od osi X
            float x = XAxisDelta;

            while (x < XAxisMax)
            {
                DrawVerticalLine(e, penGray, x);
                x += XAxisDelta;
            }

            // Rysowanie linii siatki na lewo od osi X
            x = -XAxisDelta;

            while (x > XAxisMin)
            {
                DrawVerticalLine(e, penGray, x);
                x -= XAxisDelta;
            }

            // Rysowanie linii siatki w dół od osi Y
            float y = YAxisDelta;

            while (y < YAxisMax)
            {
                DrawHorizontalLine(e, penGray, y);
                y += YAxisDelta;
            }

            // Rysowanie linii siatki w górę od osi Y
            y = -XAxisDelta;

            while (y > YAxisMin)
            {
                DrawHorizontalLine(e, penGray, y);
                y -= YAxisDelta;
            }

            // Rysowanie linii siatki na brzegach
            DrawVerticalLine(e, penGray, XAxisMin);
            DrawVerticalLine(e, penGray, XAxisMax);

            DrawHorizontalLine(e, penGray, YAxisMin);
            DrawHorizontalLine(e, penGray, YAxisMax);

            // Rysowanie osi X i Y, jeśli są widoczne
            if ((XAxisMin <= 0) && (XAxisMax >= 0))
                DrawVerticalLine(e, penBlack, 0);

            if ((YAxisMin <= 0) && (YAxisMax >= 0))
                DrawHorizontalLine(e, penBlack, 0);
        }

        // Rysowanie wykresu funkcji
        private void DrawData(PaintEventArgs e, DataPoint[] dataPoints)
        {
            // Definicja pisaka
            Pen penRed = new Pen(Color.Red, 3);

            // Sprawdzenie, czy istnieją dane
            if (dataPoints == null)
             return;

            // Flaga do zapamiętania istnienia poprzedniego punktu znajdującego się w obszarze rysowania
            bool prevPointExists = false;

            // Pozycja poprzedniego punktu
            float prevX = 0;
            float prevY = 0;

            // Dla każdego punktu wykresu funkcji
            for (int i = 0; i < dataPoints.Length; i++)
            {
                // Sprawdzenie, czy punkt mieści się w obszarze rysowania
                if ((dataPoints[i].Y >= YAxisMin) && (dataPoints[i].Y <= YAxisMax))
                {
                    // Oblicz współrzędne punktu na kanwie
                    float x = GetX(dataPoints[i].X);
                    float y = GetY(dataPoints[i].Y);

                    // Jeśli poprzedni punkt istnieje rysowanie linii łączącej punkt poprzedni i obecny
                    if (prevPointExists)
                        e.Graphics.DrawLine(penRed, prevX, prevY, x, y);

                    // Zapamiętanie pozycji porzedniego punktu znajdującego się w obszarze rysowania
                    prevX = x;
                    prevY = y;

                    // Ustawienie flagi oznaczającej istnienie punktu znajdującego się w obszarze rysowania
                    prevPointExists = true;
                }
                else
                    // Punkt nie mieści się w obszarze rysowania - nie można go wykorzystać do rysowania następnej linii
                    prevPointExists = false;
            }
        }

        // Obszar rysowania wykresu
        private Rectangle MarginRect(Rectangle rect, int margin)
        {
            return new Rectangle(margin, margin, rect.Width - 2 * margin, rect.Height - 2 * margin);
        }

        // Funkcja wykonywana przy zmianie rozmiaru okna i przy wywołaniu charts.Invalidate()
        private void Chart_Paint(object sender, PaintEventArgs e)
        {
            canvasRect = e.ClipRectangle;
            marginRect = MarginRect(canvasRect, 30);

            Pen penBlack = new Pen(Color.Black, 3);

            DrawAxes(e);
            DrawData(e, dataPoints);
        }
    }
}
