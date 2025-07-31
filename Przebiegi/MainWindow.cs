using System;
using System.Windows.Forms;

namespace Przebiegi
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            // Aktualizacja wykresu na początku programu
            UpdateChart();
        }

        private void UpdateChart()
        {
            // Liczba próbek wykresu
            int noSamples = (int)numericUpDownNoSamples.Value;

            // Tabliza próbek
            chart.dataPoints = new DataPoint[noSamples];

            // Wartości graniczne osi X
            float xAxisMin = (float)numericUpDownXAxisMin.Value;
            float xAxisMax = (float)numericUpDownXAxisMax.Value;

            // Wartości parametrów funkcji
            float A = (float)numericUpDownParA.Value;
            float B = (float)numericUpDownParB.Value;
            float C = (float)numericUpDownParC.Value;
            float D = (float)numericUpDownParD.Value;

            // Dla każdej próbki
            for (int i = 0; i < noSamples; i++)
            {
                // Obliczanie wartości x z zakresu <xAxisMin, xAxisMax>
                float x = xAxisMin + ((float)i) / ((float)noSamples - 1) * (xAxisMax - xAxisMin);
                
                // Wyznaczanie wartości y w zależności od rodzaju funkcji i jej parametrów
                float y = 0;

                if (radioButtonFunkcjaWielomianowa.Checked)
                    y = A * x * x * x + B * x * x + C * x + D;

                if (radioButtonFunkcjaSinusoidalna.Checked)
                    y = A * (float)Math.Sin((double)(B * x + C)) + D;

                if (radioButtonFunkcjaWykladnicza.Checked)
                    y = A * (float)Math.Exp((double)(B * x + C)) + D;

                if (radioButtonFunkcjaPotegowa.Checked)
                    y = A * (float)Math.Pow((double)B, (double)x) + C;

                // Wpisanie punktu do tablicy
                chart.dataPoints[i] = new DataPoint(x, y);
            }

            // Ponowne rysowanie wykresu
            chart.Invalidate();
        }

        // Zmiana rozmiaru wykresu wymaga ponownego narysowania, ale nie wymaga przeliczania
        private void chart_ClientSizeChanged(object sender, EventArgs e)
        {
            chart.Invalidate();
        }

        // Zmiana wartości zakresów osi i rozmiaru siatki wymaga aktualizacji wykresu
        private void numericUpDownAxis_ValueChanged(object sender, EventArgs e)
        {
            // Obiekt wywołujący zdarzenie
            NumericUpDown numericUpDown = (NumericUpDown)sender;

            // Zmiana zakresów osi X i Y
            if (numericUpDown.Equals(numericUpDownXAxisMin))
            {
                chart.XAxisMin = (float)numericUpDown.Value;
                numericUpDownXAxisMax.Minimum = numericUpDown.Value + 1;
            }

            if (numericUpDown.Equals(numericUpDownXAxisMax))
            {
                chart.XAxisMax = (float)numericUpDown.Value;
                numericUpDownXAxisMin.Maximum = numericUpDown.Value - 1;
            }

            if (numericUpDown.Equals(numericUpDownYAxisMin))
            {
                chart.YAxisMin = (float)numericUpDown.Value;
                numericUpDownYAxisMax.Minimum = numericUpDown.Value + 1;
            }

            if (numericUpDown.Equals(numericUpDownYAxisMax))
            {
                chart.YAxisMax = (float)numericUpDown.Value;
                numericUpDownYAxisMin.Maximum = numericUpDown.Value - 1;
            }

            // Zmiana rozmiaru siatki osi X i Y
            if (numericUpDown.Equals(numericUpDownXAxisDelta))
                chart.XAxisDelta = (float)numericUpDown.Value;

            if (numericUpDown.Equals(numericUpDownYAxisDelta))
                chart.YAxisDelta = (float)numericUpDown.Value;

            // Aktualizacja wykresu po modyfikacji osi
            UpdateChart();
        }

        // Zmiana rodzaju funkcji wymaga aktualizacji wykresu
        private void radioButtonFunction_CheckedChanged(object sender, EventArgs e)
        {
            // Obiekt wywołujący zdarzenie
            RadioButton radioButton = (RadioButton)sender;

            // Aktualizacja wykresu - zabezpieczenie przed podwójnym wywołaniem UpdateChart (dwie kontrolki zmieniają stan i wywołują zdarzenie)
            if (radioButton.Checked)
            {
                // Zabezpieczenie przed ujemną wartością podstawy potęgi funkcji potęgowej
                if (radioButton.Equals(radioButtonFunkcjaPotegowa))
                    numericUpDownParB.Minimum = 0;
                else
                    numericUpDownParB.Minimum = -100;

                UpdateChart();
            }
                
        }

        // Zmiana parametrów funkcji wymaga aktualizacji wykresu
        private void numericUpDownPar_ValueChanged(object sender, EventArgs e)
        {
            UpdateChart();
        }
    }
}
