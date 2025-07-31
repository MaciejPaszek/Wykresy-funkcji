namespace Przebiegi
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDownXAxisMin = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownXAxisDelta = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownYAxisMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYAxisMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownXAxisMax = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownParD = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownParC = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownParB = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButtonFunkcjaWykladnicza = new System.Windows.Forms.RadioButton();
            this.radioButtonFunkcjaSinusoidalna = new System.Windows.Forms.RadioButton();
            this.radioButtonFunkcjaWielomianowa = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownParA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNoSamples = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDownYAxisDelta = new System.Windows.Forms.NumericUpDown();
            this.radioButtonFunkcjaPotegowa = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chart = new Przebiegi.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXAxisMin)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXAxisDelta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYAxisMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYAxisMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXAxisMax)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoSamples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYAxisDelta)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDownXAxisMin
            // 
            this.numericUpDownXAxisMin.Location = new System.Drawing.Point(150, 28);
            this.numericUpDownXAxisMin.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownXAxisMin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownXAxisMin.Name = "numericUpDownXAxisMin";
            this.numericUpDownXAxisMin.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownXAxisMin.TabIndex = 3;
            this.numericUpDownXAxisMin.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownXAxisMin.ValueChanged += new System.EventHandler(this.numericUpDownAxis_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownYAxisDelta);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.numericUpDownXAxisDelta);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDownYAxisMax);
            this.groupBox1.Controls.Add(this.numericUpDownYAxisMin);
            this.groupBox1.Controls.Add(this.numericUpDownXAxisMax);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDownXAxisMin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 274);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osie";
            // 
            // numericUpDownXAxisDelta
            // 
            this.numericUpDownXAxisDelta.Location = new System.Drawing.Point(150, 80);
            this.numericUpDownXAxisDelta.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownXAxisDelta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownXAxisDelta.Name = "numericUpDownXAxisDelta";
            this.numericUpDownXAxisDelta.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownXAxisDelta.TabIndex = 11;
            this.numericUpDownXAxisDelta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownXAxisDelta.ValueChanged += new System.EventHandler(this.numericUpDownAxis_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Rozmiar siatki osi X";
            // 
            // numericUpDownYAxisMax
            // 
            this.numericUpDownYAxisMax.Location = new System.Drawing.Point(204, 54);
            this.numericUpDownYAxisMax.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            this.numericUpDownYAxisMax.Name = "numericUpDownYAxisMax";
            this.numericUpDownYAxisMax.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownYAxisMax.TabIndex = 9;
            this.numericUpDownYAxisMax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownYAxisMax.ValueChanged += new System.EventHandler(this.numericUpDownAxis_ValueChanged);
            // 
            // numericUpDownYAxisMin
            // 
            this.numericUpDownYAxisMin.Location = new System.Drawing.Point(150, 54);
            this.numericUpDownYAxisMin.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownYAxisMin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownYAxisMin.Name = "numericUpDownYAxisMin";
            this.numericUpDownYAxisMin.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownYAxisMin.TabIndex = 8;
            this.numericUpDownYAxisMin.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownYAxisMin.ValueChanged += new System.EventHandler(this.numericUpDownAxis_ValueChanged);
            // 
            // numericUpDownXAxisMax
            // 
            this.numericUpDownXAxisMax.Location = new System.Drawing.Point(204, 28);
            this.numericUpDownXAxisMax.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            this.numericUpDownXAxisMax.Name = "numericUpDownXAxisMax";
            this.numericUpDownXAxisMax.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownXAxisMax.TabIndex = 7;
            this.numericUpDownXAxisMax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownXAxisMax.ValueChanged += new System.EventHandler(this.numericUpDownAxis_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Zakres osi Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Zakres osi X";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.radioButtonFunkcjaPotegowa);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.numericUpDownParD);
            this.groupBox3.Controls.Add(this.numericUpDownParC);
            this.groupBox3.Controls.Add(this.numericUpDownParB);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.radioButtonFunkcjaWykladnicza);
            this.groupBox3.Controls.Add(this.radioButtonFunkcjaSinusoidalna);
            this.groupBox3.Controls.Add(this.radioButtonFunkcjaWielomianowa);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.numericUpDownParA);
            this.groupBox3.Controls.Add(this.numericUpDownNoSamples);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 283);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 275);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dane";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(150, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "y = A exp(Bx + C) + D";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(150, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "y = A sin(Bx + C) + D";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "y = Ax^3 + Bx^2  + Cx + D";
            // 
            // numericUpDownParD
            // 
            this.numericUpDownParD.DecimalPlaces = 2;
            this.numericUpDownParD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownParD.Location = new System.Drawing.Point(44, 198);
            this.numericUpDownParD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownParD.Name = "numericUpDownParD";
            this.numericUpDownParD.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownParD.TabIndex = 20;
            this.numericUpDownParD.Value = new decimal(new int[] {
            4,
            0,
            0,
            -2147483648});
            this.numericUpDownParD.ValueChanged += new System.EventHandler(this.numericUpDownPar_ValueChanged);
            // 
            // numericUpDownParC
            // 
            this.numericUpDownParC.DecimalPlaces = 2;
            this.numericUpDownParC.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownParC.Location = new System.Drawing.Point(44, 172);
            this.numericUpDownParC.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownParC.Name = "numericUpDownParC";
            this.numericUpDownParC.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownParC.TabIndex = 19;
            this.numericUpDownParC.Value = new decimal(new int[] {
            3,
            0,
            0,
            -2147483648});
            this.numericUpDownParC.ValueChanged += new System.EventHandler(this.numericUpDownPar_ValueChanged);
            // 
            // numericUpDownParB
            // 
            this.numericUpDownParB.DecimalPlaces = 2;
            this.numericUpDownParB.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownParB.Location = new System.Drawing.Point(44, 146);
            this.numericUpDownParB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownParB.Name = "numericUpDownParB";
            this.numericUpDownParB.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownParB.TabIndex = 18;
            this.numericUpDownParB.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownParB.ValueChanged += new System.EventHandler(this.numericUpDownPar_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "D =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "C =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "B =";
            // 
            // radioButtonFunkcjaWykladnicza
            // 
            this.radioButtonFunkcjaWykladnicza.AutoSize = true;
            this.radioButtonFunkcjaWykladnicza.Location = new System.Drawing.Point(6, 65);
            this.radioButtonFunkcjaWykladnicza.Name = "radioButtonFunkcjaWykladnicza";
            this.radioButtonFunkcjaWykladnicza.Size = new System.Drawing.Size(126, 17);
            this.radioButtonFunkcjaWykladnicza.TabIndex = 13;
            this.radioButtonFunkcjaWykladnicza.Text = "Funkcja wykładnicza";
            this.radioButtonFunkcjaWykladnicza.UseVisualStyleBackColor = true;
            this.radioButtonFunkcjaWykladnicza.CheckedChanged += new System.EventHandler(this.radioButtonFunction_CheckedChanged);
            // 
            // radioButtonFunkcjaSinusoidalna
            // 
            this.radioButtonFunkcjaSinusoidalna.AutoSize = true;
            this.radioButtonFunkcjaSinusoidalna.Location = new System.Drawing.Point(6, 88);
            this.radioButtonFunkcjaSinusoidalna.Name = "radioButtonFunkcjaSinusoidalna";
            this.radioButtonFunkcjaSinusoidalna.Size = new System.Drawing.Size(124, 17);
            this.radioButtonFunkcjaSinusoidalna.TabIndex = 12;
            this.radioButtonFunkcjaSinusoidalna.Text = "Funkcja sinusoidalna";
            this.radioButtonFunkcjaSinusoidalna.UseVisualStyleBackColor = true;
            this.radioButtonFunkcjaSinusoidalna.CheckedChanged += new System.EventHandler(this.radioButtonFunction_CheckedChanged);
            // 
            // radioButtonFunkcjaWielomianowa
            // 
            this.radioButtonFunkcjaWielomianowa.AutoSize = true;
            this.radioButtonFunkcjaWielomianowa.Checked = true;
            this.radioButtonFunkcjaWielomianowa.Location = new System.Drawing.Point(6, 19);
            this.radioButtonFunkcjaWielomianowa.Name = "radioButtonFunkcjaWielomianowa";
            this.radioButtonFunkcjaWielomianowa.Size = new System.Drawing.Size(74, 17);
            this.radioButtonFunkcjaWielomianowa.TabIndex = 11;
            this.radioButtonFunkcjaWielomianowa.TabStop = true;
            this.radioButtonFunkcjaWielomianowa.Text = "Wielomian";
            this.radioButtonFunkcjaWielomianowa.UseVisualStyleBackColor = true;
            this.radioButtonFunkcjaWielomianowa.CheckedChanged += new System.EventHandler(this.radioButtonFunction_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "A =";
            // 
            // numericUpDownParA
            // 
            this.numericUpDownParA.DecimalPlaces = 2;
            this.numericUpDownParA.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownParA.Location = new System.Drawing.Point(44, 120);
            this.numericUpDownParA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownParA.Name = "numericUpDownParA";
            this.numericUpDownParA.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownParA.TabIndex = 5;
            this.numericUpDownParA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownParA.ValueChanged += new System.EventHandler(this.numericUpDownPar_ValueChanged);
            // 
            // numericUpDownNoSamples
            // 
            this.numericUpDownNoSamples.Location = new System.Drawing.Point(153, 228);
            this.numericUpDownNoSamples.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownNoSamples.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownNoSamples.Name = "numericUpDownNoSamples";
            this.numericUpDownNoSamples.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNoSamples.TabIndex = 2;
            this.numericUpDownNoSamples.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownNoSamples.ValueChanged += new System.EventHandler(this.numericUpDownPar_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Liczba próbek";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Rozmiar siatki osi Y";
            // 
            // numericUpDownYAxisDelta
            // 
            this.numericUpDownYAxisDelta.Location = new System.Drawing.Point(150, 106);
            this.numericUpDownYAxisDelta.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownYAxisDelta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownYAxisDelta.Name = "numericUpDownYAxisDelta";
            this.numericUpDownYAxisDelta.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownYAxisDelta.TabIndex = 13;
            this.numericUpDownYAxisDelta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownYAxisDelta.ValueChanged += new System.EventHandler(this.numericUpDownAxis_ValueChanged);
            // 
            // radioButtonFunkcjaPotegowa
            // 
            this.radioButtonFunkcjaPotegowa.AutoSize = true;
            this.radioButtonFunkcjaPotegowa.Location = new System.Drawing.Point(6, 42);
            this.radioButtonFunkcjaPotegowa.Name = "radioButtonFunkcjaPotegowa";
            this.radioButtonFunkcjaPotegowa.Size = new System.Drawing.Size(113, 17);
            this.radioButtonFunkcjaPotegowa.TabIndex = 29;
            this.radioButtonFunkcjaPotegowa.Text = "Funkcja potęgowa";
            this.radioButtonFunkcjaPotegowa.UseVisualStyleBackColor = true;
            this.radioButtonFunkcjaPotegowa.CheckedChanged += new System.EventHandler(this.radioButtonFunction_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(150, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "y = A * x ^ B + C";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.chart, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 561);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(684, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(300, 561);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // chart
            // 
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Location = new System.Drawing.Point(3, 3);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(678, 555);
            this.chart.TabIndex = 1;
            this.chart.ClientSizeChanged += new System.EventHandler(this.chart_ClientSizeChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainWindow";
            this.Text = "Wykresy funkcji";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXAxisMin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXAxisDelta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYAxisMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYAxisMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXAxisMax)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoSamples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYAxisDelta)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Chart chart;
        private System.Windows.Forms.NumericUpDown numericUpDownXAxisMin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownYAxisMax;
        private System.Windows.Forms.NumericUpDown numericUpDownYAxisMin;
        private System.Windows.Forms.NumericUpDown numericUpDownXAxisMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownNoSamples;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownXAxisDelta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownParA;
        private System.Windows.Forms.RadioButton radioButtonFunkcjaWykladnicza;
        private System.Windows.Forms.RadioButton radioButtonFunkcjaSinusoidalna;
        private System.Windows.Forms.RadioButton radioButtonFunkcjaWielomianowa;
        private System.Windows.Forms.NumericUpDown numericUpDownParD;
        private System.Windows.Forms.NumericUpDown numericUpDownParC;
        private System.Windows.Forms.NumericUpDown numericUpDownParB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownYAxisDelta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton radioButtonFunkcjaPotegowa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

