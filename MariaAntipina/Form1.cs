using System;

namespace MariaAntipina
{
    public partial class Form1 : Form
    {
        List<TextBox> aMatrixTextBoxes, bMatrixTextBoxes, otherTextBoxes;
        SquareMatrix matrix;
        public Form1()
        {
            InitializeComponent();
            List<TextBox> textBoxes = new List<TextBox>();
            for (int i = 1; i < 4; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    string index = i.ToString() + j.ToString();
                    textBoxes.Add((TextBox)Controls.Find("a" + index, true)[0]);
                    textBoxes.Add((TextBox)Controls.Find("b" + index, true)[0]);
                }
            }
            textBoxes.Add((TextBox)Controls.Find("numA", true)[0]);
            textBoxes.Add((TextBox)Controls.Find("numB", true)[0]);
            textBoxes.Add((TextBox)Controls.Find("degreeA", true)[0]);
            textBoxes.Add((TextBox)Controls.Find("degreeB", true)[0]);
            foreach (TextBox textBox in textBoxes)
            {
                textBox_SetText(textBox);
            }
        }

        private void FindDeterminant(object sender, EventArgs e)
        {
            if ((sender as Button).Name == "determinantAButton")
            {
                this.matrix = new SquareMatrix(InitializeMatrixA());
            }
            else if ((sender as Button).Name == "determinantBButton")
            {
                this.matrix = new SquareMatrix(InitializeMatrixB());
            }
            else
            {
                throw new Exception("ERROR");
            }
            Result result = new Result(matrix.FindDeterminant());
            result.Show();
        }

        private void FindInverse(object sender, EventArgs e)
        {
            if ((sender as Button).Name == "inverseAButton")
            {
                this.matrix = new SquareMatrix(InitializeMatrixA());
            }
            else if ((sender as Button).Name == "inverseButton")
            {
                this.matrix = new SquareMatrix(InitializeMatrixB());
            }
            else
            {
                throw new Exception("ERROR");
            }
            Result result = new Result(matrix.FindInverse());
            result.Show();
        }

        private void FindTranspose(object sender, EventArgs e)
        {
            if ((sender as Button).Name == "transpositionAButton")
            {
                this.matrix = new SquareMatrix(InitializeMatrixA());
            }
            else if ((sender as Button).Name == "transpositionBButton")
            {
                this.matrix = new SquareMatrix(InitializeMatrixB());
            }
            else
            {
                throw new Exception("ERROR");
            }
            Result result = new Result(matrix.Transpose());
            result.Show();
        }

        private void FindRank(object sender, EventArgs e)
        {
            if ((sender as Button).Name == "rankAButton")
            {
                this.matrix = new SquareMatrix(InitializeMatrixA());
            }
            else if ((sender as Button).Name == "rankBButton")
            {
                this.matrix = new SquareMatrix(InitializeMatrixB());
            }
            else
            {
                throw new Exception("ERROR");
            }
            Result result = new Result(this.matrix.FindRank());
            result.Show();
        }

        private void FindProduct(object sender, EventArgs e)
        {
            double num = 0;
            if ((sender as Button).Name == "multiplicationAButton")
            {
                this.matrix = new SquareMatrix(InitializeMatrixA());
                num = Double.Parse(this.numA.Text);
            }
            else if ((sender as Button).Name == "multiplicationBButton")
            {
                this.matrix = new SquareMatrix(InitializeMatrixB());
                num = Double.Parse(this.numB.Text);
            }
            else
            {
                throw new Exception("ERROR");
            }
            Result result = new Result(matrix * num);
            result.Show();
        }

        // Не работает
        private void FindPow(object sender, EventArgs e)
        {
            double num = 0;
            if ((sender as Button).Name == "exponentiationAButton")
            {
                this.matrix = new SquareMatrix(InitializeMatrixA());
                num = Double.Parse(this.degreeA.Text);
            }
            else if ((sender as Button).Name == "exponentiationBButton")
            {
                this.matrix = new SquareMatrix(InitializeMatrixB());
                num = Double.Parse(this.degreeB.Text);
            }
            else
            {
                throw new Exception("ERROR");
            }
            Result result = new Result(this.matrix^num);
            result.Show();
        }

        private void FindMatricesProduct(object sender, EventArgs e)
        {
            SquareMatrix other = new SquareMatrix(InitializeMatrixB());
            this.matrix = new SquareMatrix(InitializeMatrixA());
            Result result = new Result(matrix * other);
            result.Show();
        }
        private void FindMatricesSum(object sender, EventArgs e)
        {
            SquareMatrix other = new SquareMatrix(InitializeMatrixB());
            this.matrix = new SquareMatrix(InitializeMatrixA());
            Result result = new Result(matrix + other);
            result.Show();
        }

        private void FindMatricesDifference(object sender, EventArgs e)
        {
            SquareMatrix other = new SquareMatrix(InitializeMatrixB());
            this.matrix = new SquareMatrix(InitializeMatrixA());
            Result result = new Result(matrix * other);
            result.Show();
        }
        private void Swap(object sender, EventArgs e)
        {
            this.aMatrixTextBoxes = new List<TextBox>();
            for (int i = 1; i < 4; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    string index = i.ToString() + j.ToString();
                    this.aMatrixTextBoxes.Add((TextBox)Controls.Find("a" + index, true)[0]);
                }
            }
            this.bMatrixTextBoxes = new List<TextBox>();
            for (int i = 1; i < 4; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    string index = i.ToString() + j.ToString();
                    this.bMatrixTextBoxes.Add((TextBox)Controls.Find("a" + index, true)[0]);
                }
            }
            List<TextBox> scratchList = this.aMatrixTextBoxes;
            this.aMatrixTextBoxes = bMatrixTextBoxes;
            this.bMatrixTextBoxes = scratchList;
        }

        private SquareMatrix InitializeMatrixA()
        {
            this.aMatrixTextBoxes = new List<TextBox>();
            for (int i = 1; i < 4; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    string index = i.ToString() + j.ToString();
                    this.aMatrixTextBoxes.Add((TextBox)Controls.Find("a" + index, true)[0]);
                }
            }
            double[,] massive = new double[3, 3];
            int z = 0, k = 0;
            foreach (TextBox textBox in this.aMatrixTextBoxes)
            {
                massive[z, k] = Double.Parse(textBox.Text);
                k++;
                if (k == 3)
                {
                    k = 0;
                    z++;
                }
            }
            return new SquareMatrix(massive);
        }

        private SquareMatrix InitializeMatrixB()
        {
            this.bMatrixTextBoxes = new List<TextBox>();
            for (int i = 1; i < 4; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    string index = i.ToString() + j.ToString();
                    this.bMatrixTextBoxes.Add((TextBox)Controls.Find("a" + index, true)[0]);
                }
            }
            double[,] massive = new double[3, 3];
            int z = 0, k = 0;
            foreach (TextBox textBox in this.bMatrixTextBoxes)
            {
                massive[z, k] = Double.Parse(textBox.Text);
                k++;
                if (k == 3)
                {
                    k = 0;
                    z++;
                }
            }
            return new SquareMatrix(massive);
        }

        protected void textBox_SetText(TextBox textBox)
        {

            textBox.Text = "0";
            textBox.ForeColor = Color.Gray;
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = new TextBox();
            textBox = (TextBox)sender;
            if (textBox.ForeColor == Color.White)
                return;
            textBox.Text = "";
            textBox.ForeColor = Color.White;
        }
        private void textBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = new TextBox();
            textBox = (TextBox)sender;
            if (textBox.Text.Trim() == "")
                textBox_SetText(textBox);
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = new TextBox();
            textBox = (TextBox)sender;
            if (!double.TryParse(textBox.Text + e.KeyChar.ToString(), out double a) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}