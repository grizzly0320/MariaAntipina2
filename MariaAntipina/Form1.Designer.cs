namespace MariaAntipina
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            a11 = new TextBox();
            panel1 = new Panel();
            a33 = new TextBox();
            a32 = new TextBox();
            a31 = new TextBox();
            a23 = new TextBox();
            a22 = new TextBox();
            a21 = new TextBox();
            a13 = new TextBox();
            a12 = new TextBox();
            multiplicationAButton = new Button();
            transpositionAButton = new Button();
            rankAButton = new Button();
            inverseAButton = new Button();
            exponentiationAButton = new Button();
            determinantAButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            numA = new TextBox();
            degreeA = new TextBox();
            matricesProductButton = new Button();
            matricesSumButton = new Button();
            matricesDifferenceButton = new Button();
            swapButton = new Button();
            label2 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            determinantBButton = new Button();
            inverseBButton = new Button();
            transpositionBButton = new Button();
            rankBButton = new Button();
            multiplicationBButton = new Button();
            numB = new TextBox();
            exponentiationBButton = new Button();
            degreeB = new TextBox();
            panel2 = new Panel();
            b33 = new TextBox();
            b32 = new TextBox();
            b31 = new TextBox();
            b23 = new TextBox();
            b22 = new TextBox();
            b21 = new TextBox();
            b13 = new TextBox();
            b12 = new TextBox();
            b11 = new TextBox();
            solveEquationButton = new Button();
            textBox5 = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(171, 29);
            label1.Margin = new Padding(100, 20, 100, 20);
            label1.Name = "label1";
            label1.Size = new Size(110, 24);
            label1.TabIndex = 0;
            label1.Text = "Матрица A:";
            // 
            // a11
            // 
            a11.BackColor = Color.FromArgb(45, 55, 61);
            a11.BorderStyle = BorderStyle.FixedSingle;
            a11.ForeColor = Color.White;
            a11.Location = new Point(3, 3);
            a11.MaximumSize = new Size(63, 27);
            a11.MinimumSize = new Size(63, 27);
            a11.Name = "a11";
            a11.Size = new Size(63, 27);
            a11.TabIndex = 1;
            a11.Text = "0";
            a11.TextAlign = HorizontalAlignment.Center;
            a11.Enter += textBox_Enter;
            a11.KeyPress += textBox_KeyPress;
            a11.Leave += textBox_Leave;
            // 
            // panel1
            // 
            panel1.Controls.Add(a33);
            panel1.Controls.Add(a32);
            panel1.Controls.Add(a31);
            panel1.Controls.Add(a23);
            panel1.Controls.Add(a22);
            panel1.Controls.Add(a21);
            panel1.Controls.Add(a13);
            panel1.Controls.Add(a12);
            panel1.Controls.Add(a11);
            panel1.Location = new Point(117, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 98);
            panel1.TabIndex = 3;
            // 
            // a33
            // 
            a33.BackColor = Color.FromArgb(45, 55, 61);
            a33.BorderStyle = BorderStyle.FixedSingle;
            a33.ForeColor = Color.White;
            a33.Location = new Point(141, 69);
            a33.MaximumSize = new Size(63, 27);
            a33.MinimumSize = new Size(63, 27);
            a33.Name = "a33";
            a33.Size = new Size(63, 27);
            a33.TabIndex = 9;
            a33.Text = "0";
            a33.TextAlign = HorizontalAlignment.Center;
            a33.Enter += textBox_Enter;
            a33.KeyPress += textBox_KeyPress;
            a33.Leave += textBox_Leave;
            // 
            // a32
            // 
            a32.BackColor = Color.FromArgb(45, 55, 61);
            a32.BorderStyle = BorderStyle.FixedSingle;
            a32.ForeColor = Color.White;
            a32.Location = new Point(72, 69);
            a32.MaximumSize = new Size(63, 27);
            a32.MinimumSize = new Size(63, 27);
            a32.Name = "a32";
            a32.Size = new Size(63, 27);
            a32.TabIndex = 8;
            a32.Text = "0";
            a32.TextAlign = HorizontalAlignment.Center;
            a32.Enter += textBox_Enter;
            a32.KeyPress += textBox_KeyPress;
            a32.Leave += textBox_Leave;
            // 
            // a31
            // 
            a31.BackColor = Color.FromArgb(45, 55, 61);
            a31.BorderStyle = BorderStyle.FixedSingle;
            a31.ForeColor = Color.White;
            a31.Location = new Point(3, 69);
            a31.MaximumSize = new Size(63, 27);
            a31.MinimumSize = new Size(63, 27);
            a31.Name = "a31";
            a31.Size = new Size(63, 27);
            a31.TabIndex = 7;
            a31.Text = "0";
            a31.TextAlign = HorizontalAlignment.Center;
            a31.Enter += textBox_Enter;
            a31.KeyPress += textBox_KeyPress;
            a31.Leave += textBox_Leave;
            // 
            // a23
            // 
            a23.BackColor = Color.FromArgb(45, 55, 61);
            a23.BorderStyle = BorderStyle.FixedSingle;
            a23.ForeColor = Color.White;
            a23.Location = new Point(141, 36);
            a23.MaximumSize = new Size(63, 27);
            a23.MinimumSize = new Size(63, 27);
            a23.Name = "a23";
            a23.Size = new Size(63, 27);
            a23.TabIndex = 6;
            a23.Text = "0";
            a23.TextAlign = HorizontalAlignment.Center;
            a23.Enter += textBox_Enter;
            a23.KeyPress += textBox_KeyPress;
            a23.Leave += textBox_Leave;
            // 
            // a22
            // 
            a22.BackColor = Color.FromArgb(45, 55, 61);
            a22.BorderStyle = BorderStyle.FixedSingle;
            a22.ForeColor = Color.White;
            a22.Location = new Point(72, 36);
            a22.MaximumSize = new Size(63, 27);
            a22.MinimumSize = new Size(63, 27);
            a22.Name = "a22";
            a22.Size = new Size(63, 27);
            a22.TabIndex = 5;
            a22.Text = "0";
            a22.TextAlign = HorizontalAlignment.Center;
            a22.Enter += textBox_Enter;
            a22.KeyPress += textBox_KeyPress;
            a22.Leave += textBox_Leave;
            // 
            // a21
            // 
            a21.BackColor = Color.FromArgb(45, 55, 61);
            a21.BorderStyle = BorderStyle.FixedSingle;
            a21.ForeColor = Color.White;
            a21.Location = new Point(3, 36);
            a21.MaximumSize = new Size(63, 27);
            a21.MinimumSize = new Size(63, 27);
            a21.Name = "a21";
            a21.Size = new Size(63, 27);
            a21.TabIndex = 4;
            a21.Text = "0";
            a21.TextAlign = HorizontalAlignment.Center;
            a21.Enter += textBox_Enter;
            a21.KeyPress += textBox_KeyPress;
            a21.Leave += textBox_Leave;
            // 
            // a13
            // 
            a13.BackColor = Color.FromArgb(45, 55, 61);
            a13.BorderStyle = BorderStyle.FixedSingle;
            a13.ForeColor = Color.White;
            a13.Location = new Point(141, 3);
            a13.MaximumSize = new Size(63, 27);
            a13.MinimumSize = new Size(63, 27);
            a13.Name = "a13";
            a13.Size = new Size(63, 27);
            a13.TabIndex = 3;
            a13.Text = "0";
            a13.TextAlign = HorizontalAlignment.Center;
            a13.Enter += textBox_Enter;
            a13.KeyPress += textBox_KeyPress;
            a13.Leave += textBox_Leave;
            // 
            // a12
            // 
            a12.BackColor = Color.FromArgb(45, 55, 61);
            a12.BorderStyle = BorderStyle.FixedSingle;
            a12.ForeColor = Color.White;
            a12.Location = new Point(72, 3);
            a12.MaximumSize = new Size(63, 27);
            a12.MinimumSize = new Size(63, 27);
            a12.Name = "a12";
            a12.Size = new Size(63, 27);
            a12.TabIndex = 2;
            a12.Text = "0";
            a12.TextAlign = HorizontalAlignment.Center;
            a12.Enter += textBox_Enter;
            a12.KeyPress += textBox_KeyPress;
            a12.Leave += textBox_Leave;
            // 
            // multiplicationAButton
            // 
            multiplicationAButton.BackColor = Color.FromArgb(45, 55, 61);
            multiplicationAButton.FlatStyle = FlatStyle.Flat;
            multiplicationAButton.ForeColor = Color.White;
            multiplicationAButton.Location = new Point(3, 79);
            multiplicationAButton.Margin = new Padding(3, 3, 1, 3);
            multiplicationAButton.Name = "multiplicationAButton";
            multiplicationAButton.Size = new Size(144, 32);
            multiplicationAButton.TabIndex = 7;
            multiplicationAButton.Text = "Умножить на";
            multiplicationAButton.UseVisualStyleBackColor = false;
            multiplicationAButton.Click += FindProduct;
            // 
            // transpositionAButton
            // 
            transpositionAButton.BackColor = Color.FromArgb(45, 55, 61);
            transpositionAButton.FlatStyle = FlatStyle.Flat;
            transpositionAButton.ForeColor = Color.White;
            transpositionAButton.Location = new Point(3, 41);
            transpositionAButton.Name = "transpositionAButton";
            transpositionAButton.Size = new Size(185, 32);
            transpositionAButton.TabIndex = 5;
            transpositionAButton.Text = "Транспонировать";
            transpositionAButton.UseVisualStyleBackColor = false;
            transpositionAButton.Click += FindTranspose;
            // 
            // rankAButton
            // 
            rankAButton.BackColor = Color.FromArgb(45, 55, 61);
            rankAButton.FlatStyle = FlatStyle.Flat;
            rankAButton.ForeColor = Color.White;
            rankAButton.Location = new Point(194, 41);
            rankAButton.Name = "rankAButton";
            rankAButton.Size = new Size(185, 32);
            rankAButton.TabIndex = 6;
            rankAButton.Text = "Ранг";
            rankAButton.UseVisualStyleBackColor = false;
            rankAButton.Click += FindRank;
            // 
            // inverseAButton
            // 
            inverseAButton.BackColor = Color.FromArgb(45, 55, 61);
            inverseAButton.FlatStyle = FlatStyle.Flat;
            inverseAButton.ForeColor = Color.White;
            inverseAButton.Location = new Point(194, 3);
            inverseAButton.Name = "inverseAButton";
            inverseAButton.Size = new Size(185, 32);
            inverseAButton.TabIndex = 4;
            inverseAButton.Text = "Обратная";
            inverseAButton.UseVisualStyleBackColor = false;
            inverseAButton.Click += FindInverse;
            // 
            // exponentiationAButton
            // 
            exponentiationAButton.BackColor = Color.FromArgb(45, 55, 61);
            exponentiationAButton.FlatStyle = FlatStyle.Flat;
            exponentiationAButton.ForeColor = Color.White;
            exponentiationAButton.Location = new Point(194, 79);
            exponentiationAButton.Margin = new Padding(3, 3, 1, 3);
            exponentiationAButton.Name = "exponentiationAButton";
            exponentiationAButton.Size = new Size(144, 32);
            exponentiationAButton.TabIndex = 10;
            exponentiationAButton.Text = "Возведите в степень";
            exponentiationAButton.UseVisualStyleBackColor = false;
            exponentiationAButton.Click += FindPow;
            // 
            // determinantAButton
            // 
            determinantAButton.BackColor = Color.FromArgb(45, 55, 61);
            determinantAButton.FlatStyle = FlatStyle.Flat;
            determinantAButton.ForeColor = Color.White;
            determinantAButton.Location = new Point(3, 3);
            determinantAButton.Name = "determinantAButton";
            determinantAButton.Size = new Size(185, 32);
            determinantAButton.TabIndex = 2;
            determinantAButton.Text = "Определитель";
            determinantAButton.UseVisualStyleBackColor = false;
            determinantAButton.Click += FindDeterminant;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(determinantAButton);
            flowLayoutPanel1.Controls.Add(inverseAButton);
            flowLayoutPanel1.Controls.Add(transpositionAButton);
            flowLayoutPanel1.Controls.Add(rankAButton);
            flowLayoutPanel1.Controls.Add(multiplicationAButton);
            flowLayoutPanel1.Controls.Add(numA);
            flowLayoutPanel1.Controls.Add(exponentiationAButton);
            flowLayoutPanel1.Controls.Add(degreeA);
            flowLayoutPanel1.Location = new Point(29, 163);
            flowLayoutPanel1.Margin = new Padding(20, 3, 20, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(383, 115);
            flowLayoutPanel1.TabIndex = 13;
            // 
            // numA
            // 
            numA.BackColor = Color.FromArgb(45, 55, 61);
            numA.BorderStyle = BorderStyle.FixedSingle;
            numA.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            numA.ForeColor = Color.White;
            numA.Location = new Point(151, 79);
            numA.Margin = new Padding(3, 3, 4, 3);
            numA.Name = "numA";
            numA.Size = new Size(36, 32);
            numA.TabIndex = 19;
            numA.Text = "0";
            numA.TextAlign = HorizontalAlignment.Center;
            numA.Enter += textBox_Enter;
            numA.KeyPress += textBox_KeyPress;
            numA.Leave += textBox_Leave;
            // 
            // degreeA
            // 
            degreeA.BackColor = Color.FromArgb(45, 55, 61);
            degreeA.BorderStyle = BorderStyle.FixedSingle;
            degreeA.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            degreeA.ForeColor = Color.White;
            degreeA.Location = new Point(342, 79);
            degreeA.Name = "degreeA";
            degreeA.Size = new Size(36, 32);
            degreeA.TabIndex = 18;
            degreeA.Text = "0";
            degreeA.TextAlign = HorizontalAlignment.Center;
            degreeA.Enter += textBox_Enter;
            degreeA.KeyPress += textBox_KeyPress;
            degreeA.Leave += textBox_Leave;
            // 
            // matricesProductButton
            // 
            matricesProductButton.BackColor = Color.FromArgb(45, 55, 61);
            matricesProductButton.FlatStyle = FlatStyle.Flat;
            matricesProductButton.ForeColor = Color.White;
            matricesProductButton.Location = new Point(492, 125);
            matricesProductButton.Margin = new Padding(60, 3, 60, 3);
            matricesProductButton.Name = "matricesProductButton";
            matricesProductButton.Size = new Size(85, 32);
            matricesProductButton.TabIndex = 14;
            matricesProductButton.Text = "A × B";
            matricesProductButton.UseVisualStyleBackColor = false;
            matricesProductButton.Click += FindMatricesProduct;
            // 
            // matricesSumButton
            // 
            matricesSumButton.BackColor = Color.FromArgb(45, 55, 61);
            matricesSumButton.FlatStyle = FlatStyle.Flat;
            matricesSumButton.ForeColor = Color.White;
            matricesSumButton.Location = new Point(492, 163);
            matricesSumButton.Margin = new Padding(60, 3, 60, 3);
            matricesSumButton.Name = "matricesSumButton";
            matricesSumButton.Size = new Size(85, 32);
            matricesSumButton.TabIndex = 15;
            matricesSumButton.Text = "A + B";
            matricesSumButton.UseVisualStyleBackColor = false;
            matricesSumButton.Click += FindMatricesSum;
            // 
            // matricesDifferenceButton
            // 
            matricesDifferenceButton.BackColor = Color.FromArgb(45, 55, 61);
            matricesDifferenceButton.FlatStyle = FlatStyle.Flat;
            matricesDifferenceButton.ForeColor = Color.White;
            matricesDifferenceButton.Location = new Point(492, 201);
            matricesDifferenceButton.Margin = new Padding(60, 3, 60, 3);
            matricesDifferenceButton.Name = "matricesDifferenceButton";
            matricesDifferenceButton.Size = new Size(85, 32);
            matricesDifferenceButton.TabIndex = 16;
            matricesDifferenceButton.Text = "A - B";
            matricesDifferenceButton.UseVisualStyleBackColor = false;
            matricesDifferenceButton.Click += FindMatricesDifference;
            // 
            // swapButton
            // 
            swapButton.BackColor = Color.FromArgb(45, 55, 61);
            swapButton.FlatStyle = FlatStyle.Flat;
            swapButton.ForeColor = Color.White;
            swapButton.Location = new Point(514, 59);
            swapButton.Name = "swapButton";
            swapButton.Size = new Size(41, 60);
            swapButton.TabIndex = 17;
            swapButton.Text = "←→";
            swapButton.UseVisualStyleBackColor = false;
            swapButton.Click += Swap;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(792, 29);
            label2.Margin = new Padding(100, 20, 100, 20);
            label2.Name = "label2";
            label2.Size = new Size(109, 24);
            label2.TabIndex = 18;
            label2.Text = "Матрица B:";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(determinantBButton);
            flowLayoutPanel2.Controls.Add(inverseBButton);
            flowLayoutPanel2.Controls.Add(transpositionBButton);
            flowLayoutPanel2.Controls.Add(rankBButton);
            flowLayoutPanel2.Controls.Add(multiplicationBButton);
            flowLayoutPanel2.Controls.Add(numB);
            flowLayoutPanel2.Controls.Add(exponentiationBButton);
            flowLayoutPanel2.Controls.Add(degreeB);
            flowLayoutPanel2.Location = new Point(657, 163);
            flowLayoutPanel2.Margin = new Padding(20, 3, 20, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(383, 115);
            flowLayoutPanel2.TabIndex = 20;
            // 
            // determinantBButton
            // 
            determinantBButton.BackColor = Color.FromArgb(45, 55, 61);
            determinantBButton.FlatStyle = FlatStyle.Flat;
            determinantBButton.ForeColor = Color.White;
            determinantBButton.Location = new Point(3, 3);
            determinantBButton.Name = "determinantBButton";
            determinantBButton.Size = new Size(185, 32);
            determinantBButton.TabIndex = 2;
            determinantBButton.Text = "Определитель";
            determinantBButton.UseVisualStyleBackColor = false;
            determinantBButton.Click += FindDeterminant;
            // 
            // inverseBButton
            // 
            inverseBButton.BackColor = Color.FromArgb(45, 55, 61);
            inverseBButton.FlatStyle = FlatStyle.Flat;
            inverseBButton.ForeColor = Color.White;
            inverseBButton.Location = new Point(194, 3);
            inverseBButton.Name = "inverseBButton";
            inverseBButton.Size = new Size(185, 32);
            inverseBButton.TabIndex = 4;
            inverseBButton.Text = "Обратная";
            inverseBButton.UseVisualStyleBackColor = false;
            inverseBButton.Click += FindInverse;
            // 
            // transpositionBButton
            // 
            transpositionBButton.BackColor = Color.FromArgb(45, 55, 61);
            transpositionBButton.FlatStyle = FlatStyle.Flat;
            transpositionBButton.ForeColor = Color.White;
            transpositionBButton.Location = new Point(3, 41);
            transpositionBButton.Name = "transpositionBButton";
            transpositionBButton.Size = new Size(185, 32);
            transpositionBButton.TabIndex = 5;
            transpositionBButton.Text = "Транспонировать";
            transpositionBButton.UseVisualStyleBackColor = false;
            transpositionBButton.Click += FindTranspose;
            // 
            // rankBButton
            // 
            rankBButton.BackColor = Color.FromArgb(45, 55, 61);
            rankBButton.FlatStyle = FlatStyle.Flat;
            rankBButton.ForeColor = Color.White;
            rankBButton.Location = new Point(194, 41);
            rankBButton.Name = "rankBButton";
            rankBButton.Size = new Size(185, 32);
            rankBButton.TabIndex = 6;
            rankBButton.Text = "Ранг";
            rankBButton.UseVisualStyleBackColor = false;
            rankBButton.Click += FindRank;
            // 
            // multiplicationBButton
            // 
            multiplicationBButton.BackColor = Color.FromArgb(45, 55, 61);
            multiplicationBButton.FlatStyle = FlatStyle.Flat;
            multiplicationBButton.ForeColor = Color.White;
            multiplicationBButton.Location = new Point(3, 79);
            multiplicationBButton.Margin = new Padding(3, 3, 1, 3);
            multiplicationBButton.Name = "multiplicationBButton";
            multiplicationBButton.Size = new Size(144, 32);
            multiplicationBButton.TabIndex = 7;
            multiplicationBButton.Text = "Умножить на";
            multiplicationBButton.UseVisualStyleBackColor = false;
            multiplicationBButton.Click += FindProduct;
            // 
            // numB
            // 
            numB.BackColor = Color.FromArgb(45, 55, 61);
            numB.BorderStyle = BorderStyle.FixedSingle;
            numB.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            numB.ForeColor = Color.White;
            numB.Location = new Point(151, 79);
            numB.Margin = new Padding(3, 3, 4, 3);
            numB.Name = "numB";
            numB.Size = new Size(36, 32);
            numB.TabIndex = 19;
            numB.Text = "0";
            numB.TextAlign = HorizontalAlignment.Center;
            numB.Enter += textBox_Enter;
            numB.KeyPress += textBox_KeyPress;
            numB.Leave += textBox_Leave;
            // 
            // exponentiationBButton
            // 
            exponentiationBButton.BackColor = Color.FromArgb(45, 55, 61);
            exponentiationBButton.FlatStyle = FlatStyle.Flat;
            exponentiationBButton.ForeColor = Color.White;
            exponentiationBButton.Location = new Point(194, 79);
            exponentiationBButton.Margin = new Padding(3, 3, 1, 3);
            exponentiationBButton.Name = "exponentiationBButton";
            exponentiationBButton.Size = new Size(144, 32);
            exponentiationBButton.TabIndex = 10;
            exponentiationBButton.Text = "Возведите в степень";
            exponentiationBButton.UseVisualStyleBackColor = false;
            exponentiationBButton.Click += FindPow;
            // 
            // degreeB
            // 
            degreeB.BackColor = Color.FromArgb(45, 55, 61);
            degreeB.BorderStyle = BorderStyle.FixedSingle;
            degreeB.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            degreeB.ForeColor = Color.White;
            degreeB.Location = new Point(342, 79);
            degreeB.Name = "degreeB";
            degreeB.Size = new Size(36, 32);
            degreeB.TabIndex = 18;
            degreeB.Text = "0";
            degreeB.TextAlign = HorizontalAlignment.Center;
            degreeB.Enter += textBox_Enter;
            degreeB.KeyPress += textBox_KeyPress;
            degreeB.Leave += textBox_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(b33);
            panel2.Controls.Add(b32);
            panel2.Controls.Add(b31);
            panel2.Controls.Add(b23);
            panel2.Controls.Add(b22);
            panel2.Controls.Add(b21);
            panel2.Controls.Add(b13);
            panel2.Controls.Add(b12);
            panel2.Controls.Add(b11);
            panel2.Location = new Point(744, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(207, 98);
            panel2.TabIndex = 19;
            // 
            // b33
            // 
            b33.BackColor = Color.FromArgb(45, 55, 61);
            b33.BorderStyle = BorderStyle.FixedSingle;
            b33.ForeColor = Color.White;
            b33.Location = new Point(141, 69);
            b33.MaximumSize = new Size(63, 27);
            b33.MinimumSize = new Size(63, 27);
            b33.Name = "b33";
            b33.Size = new Size(63, 27);
            b33.TabIndex = 9;
            b33.Text = "0";
            b33.TextAlign = HorizontalAlignment.Center;
            b33.Enter += textBox_Enter;
            b33.KeyPress += textBox_KeyPress;
            b33.Leave += textBox_Leave;
            // 
            // b32
            // 
            b32.BackColor = Color.FromArgb(45, 55, 61);
            b32.BorderStyle = BorderStyle.FixedSingle;
            b32.ForeColor = Color.White;
            b32.Location = new Point(72, 69);
            b32.MaximumSize = new Size(63, 27);
            b32.MinimumSize = new Size(63, 27);
            b32.Name = "b32";
            b32.Size = new Size(63, 27);
            b32.TabIndex = 8;
            b32.Text = "0";
            b32.TextAlign = HorizontalAlignment.Center;
            b32.Enter += textBox_Enter;
            b32.KeyPress += textBox_KeyPress;
            b32.Leave += textBox_Leave;
            // 
            // b31
            // 
            b31.BackColor = Color.FromArgb(45, 55, 61);
            b31.BorderStyle = BorderStyle.FixedSingle;
            b31.ForeColor = Color.White;
            b31.Location = new Point(3, 69);
            b31.MaximumSize = new Size(63, 27);
            b31.MinimumSize = new Size(63, 27);
            b31.Name = "b31";
            b31.Size = new Size(63, 27);
            b31.TabIndex = 7;
            b31.Text = "0";
            b31.TextAlign = HorizontalAlignment.Center;
            b31.Enter += textBox_Enter;
            b31.KeyPress += textBox_KeyPress;
            b31.Leave += textBox_Leave;
            // 
            // b23
            // 
            b23.BackColor = Color.FromArgb(45, 55, 61);
            b23.BorderStyle = BorderStyle.FixedSingle;
            b23.ForeColor = Color.White;
            b23.Location = new Point(141, 36);
            b23.MaximumSize = new Size(63, 27);
            b23.MinimumSize = new Size(63, 27);
            b23.Name = "b23";
            b23.Size = new Size(63, 27);
            b23.TabIndex = 6;
            b23.Text = "0";
            b23.TextAlign = HorizontalAlignment.Center;
            b23.Enter += textBox_Enter;
            b23.KeyPress += textBox_KeyPress;
            b23.Leave += textBox_Leave;
            // 
            // b22
            // 
            b22.BackColor = Color.FromArgb(45, 55, 61);
            b22.BorderStyle = BorderStyle.FixedSingle;
            b22.ForeColor = Color.White;
            b22.Location = new Point(72, 36);
            b22.MaximumSize = new Size(63, 27);
            b22.MinimumSize = new Size(63, 27);
            b22.Name = "b22";
            b22.Size = new Size(63, 27);
            b22.TabIndex = 5;
            b22.Text = "0";
            b22.TextAlign = HorizontalAlignment.Center;
            b22.Enter += textBox_Enter;
            b22.KeyPress += textBox_KeyPress;
            b22.Leave += textBox_Leave;
            // 
            // b21
            // 
            b21.BackColor = Color.FromArgb(45, 55, 61);
            b21.BorderStyle = BorderStyle.FixedSingle;
            b21.ForeColor = Color.White;
            b21.Location = new Point(3, 36);
            b21.MaximumSize = new Size(63, 27);
            b21.MinimumSize = new Size(63, 27);
            b21.Name = "b21";
            b21.Size = new Size(63, 27);
            b21.TabIndex = 4;
            b21.Text = "0";
            b21.TextAlign = HorizontalAlignment.Center;
            b21.Enter += textBox_Enter;
            b21.KeyPress += textBox_KeyPress;
            b21.Leave += textBox_Leave;
            // 
            // b13
            // 
            b13.BackColor = Color.FromArgb(45, 55, 61);
            b13.BorderStyle = BorderStyle.FixedSingle;
            b13.ForeColor = Color.White;
            b13.Location = new Point(141, 3);
            b13.MaximumSize = new Size(63, 27);
            b13.MinimumSize = new Size(63, 27);
            b13.Name = "b13";
            b13.Size = new Size(63, 27);
            b13.TabIndex = 3;
            b13.Text = "0";
            b13.TextAlign = HorizontalAlignment.Center;
            b13.Enter += textBox_Enter;
            b13.KeyPress += textBox_KeyPress;
            b13.Leave += textBox_Leave;
            // 
            // b12
            // 
            b12.BackColor = Color.FromArgb(45, 55, 61);
            b12.BorderStyle = BorderStyle.FixedSingle;
            b12.ForeColor = Color.White;
            b12.Location = new Point(72, 3);
            b12.MaximumSize = new Size(63, 27);
            b12.MinimumSize = new Size(63, 27);
            b12.Name = "b12";
            b12.Size = new Size(63, 27);
            b12.TabIndex = 2;
            b12.Text = "0";
            b12.TextAlign = HorizontalAlignment.Center;
            b12.Enter += textBox_Enter;
            b12.KeyPress += textBox_KeyPress;
            b12.Leave += textBox_Leave;
            // 
            // b11
            // 
            b11.BackColor = Color.FromArgb(45, 55, 61);
            b11.BorderStyle = BorderStyle.FixedSingle;
            b11.ForeColor = Color.White;
            b11.Location = new Point(3, 3);
            b11.MaximumSize = new Size(63, 27);
            b11.MinimumSize = new Size(63, 27);
            b11.Name = "b11";
            b11.Size = new Size(63, 27);
            b11.TabIndex = 1;
            b11.Text = "0";
            b11.TextAlign = HorizontalAlignment.Center;
            b11.Enter += textBox_Enter;
            b11.KeyPress += textBox_KeyPress;
            b11.Leave += textBox_Leave;
            // 
            // solveEquationButton
            // 
            solveEquationButton.BackColor = Color.FromArgb(45, 55, 61);
            solveEquationButton.FlatStyle = FlatStyle.Flat;
            solveEquationButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            solveEquationButton.ForeColor = Color.White;
            solveEquationButton.Location = new Point(659, 292);
            solveEquationButton.Margin = new Padding(3, 3, 1, 3);
            solveEquationButton.Name = "solveEquationButton";
            solveEquationButton.Size = new Size(32, 32);
            solveEquationButton.TabIndex = 21;
            solveEquationButton.Text = "=";
            solveEquationButton.TextAlign = ContentAlignment.TopCenter;
            solveEquationButton.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(45, 55, 61);
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.ForeColor = Color.White;
            textBox5.Location = new Point(384, 292);
            textBox5.Margin = new Padding(3, 10, 3, 10);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(270, 32);
            textBox5.TabIndex = 22;
            textBox5.Text = "|AB|/|BC|*A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(932, 330);
            label3.Margin = new Padding(100, 20, 100, 20);
            label3.Name = "label3";
            label3.Size = new Size(136, 18);
            label3.TabIndex = 23;
            label3.Text = "©MariaAntipina2023";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 68, 76);
            ClientSize = new Size(1069, 353);
            Controls.Add(label3);
            Controls.Add(solveEquationButton);
            Controls.Add(textBox5);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel2);
            Controls.Add(swapButton);
            Controls.Add(matricesDifferenceButton);
            Controls.Add(matricesSumButton);
            Controls.Add(matricesProductButton);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Matrix calculator";
            Click += FindPow;
            Enter += textBox_Enter;
            KeyPress += textBox_KeyPress;
            Leave += textBox_Leave;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox a11;
        private Panel panel1;
        private TextBox a33;
        private TextBox a32;
        private TextBox a31;
        private TextBox a23;
        private TextBox a22;
        private TextBox a21;
        private TextBox a13;
        private TextBox a12;
        private Button multiplicationAButton;
        private Button transpositionAButton;
        private Button rankAButton;
        private Button inverseAButton;
        private Button exponentiationAButton;
        private Button determinantAButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button matricesProductButton;
        private Button matricesSumButton;
        private Button matricesDifferenceButton;
        private Button swapButton;
        private TextBox degreeA;
        private TextBox numA;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button determinantBButton;
        private Button inverseBButton;
        private Button transpositionBButton;
        private Button rankBButton;
        private Button multiplicationBButton;
        private TextBox numB;
        private Button exponentiationBButton;
        private TextBox degreeB;
        private Panel panel2;
        private TextBox b33;
        private TextBox b32;
        private TextBox b31;
        private TextBox b23;
        private TextBox b22;
        private TextBox b21;
        private TextBox b13;
        private TextBox b12;
        private TextBox b11;
        private Button solveEquationButton;
        private TextBox textBox5;
        private Label label3;
    }
}