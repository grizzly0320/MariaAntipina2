using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariaAntipina
{
    public class SquareMatrix
    {
        private int row, col;
        private double[,] elems;
        public int Row => row;
        public int Col => col;
        public double[,] Elems => elems;
        public SquareMatrix(int n)
        {
            this.row = n;
            this.col = n;
            this.elems = new double[row, col];
        }
        public SquareMatrix(double[,] elems)
        {
            try
            {
                IsSquare(elems);
                this.row = elems.GetLength(1);
                this.col = elems.GetLength(0);
                this.elems = elems;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public SquareMatrix(SquareMatrix other)
        {
            try
            {
                IsSquare(other.Elems);
                this.row = other.Row;
                this.col = other.Col;
                this.elems = other.Elems;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void IsSquare(double[,] massive)
        {
            if (massive.GetLength(1) != massive.GetLength(0)) throw new Exception("Матрица не является квадратной");
        }
        public double this[int i, int j]
        {
            get
            {
                return this.elems[i, j];
            }
            set
            {
                this.elems[i, j] = value;
            }
        }

        public double FindDeterminant()
        {

            if (this.Row == 1)
            {
                return this[0, 0];
            }
            else if (this.Row == 2)
            {
                return this[0, 0] * this[1, 1] - this[1, 0] * this[0, 1];
            }
            else
            {
                double n = 0;
                for (int j = 0; j < this.Row; j++)
                {
                    n += Math.Pow(-1, 1 + j) * this[1, j] * this.FindMinor(1, j);
                }
                return n;
            }
        }
        private double FindMinor(int n, int m)
        {
            SquareMatrix mat_minor = new SquareMatrix(this.Row - 1);
            double[,] mas = new double[this.Row, this.Col];
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Col; j++)
                {
                    mas[i, j] = this[i, j];
                }
            }
            DelCol(DelRow(mas, n), m);
            for (int i = 0; i < mat_minor.Row; i++)
            {
                for (int j = 0; j < mat_minor.Col; j++)
                {
                    mat_minor[i, j] = DelCol(DelRow(mas, n), m)[i, j];
                }
            }
            return mat_minor.FindDeterminant();

        }
        static double[,] DelRow(double[,] array, int row)
        {
            double[,] result = new double[array.GetLength(0) - 1, array.GetLength(1)];
            int x = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (i == row)
                {
                    row = -1;
                    continue;
                }

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    result[x, j] = array[i, j];
                }
                x++;
            }
            return result;
        }
        static double[,] DelCol(double[,] array, int col)
        {
            double[,] result = new double[array.GetLength(0), array.GetLength(1) - 1];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int x = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j == col) continue;
                    result[i, x] = array[i, j];
                    x++;
                }
            }
            return result;
        }

        // Матрица алгебраических дополнений
        private SquareMatrix FindAlgebraicComplement()
        {

            SquareMatrix mat_c = new SquareMatrix(this.Row);
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Col; j++)
                {
                    mat_c[i, j] = Math.Pow(-1, (i + j + 2)) * this.FindMinor(i, j);
                }
            }
            return mat_c;
        }

        // Обратная матрица
        public SquareMatrix FindInverse()
        {
            if (this.FindDeterminant() != 0)
                return (this.FindAlgebraicComplement().Transpose() * (1 / this.FindDeterminant()));
            else
            {
                throw new Exception("Невозможно найти обратную матрицу");
            }
        }
        // Функция транспонирования матрицы
        public SquareMatrix Transpose()
        {
            SquareMatrix result = new SquareMatrix(this.Row);
            for (int i = 0; i < result.Row; i++)
            {
                for (int j = 0; j < result.Col; j++)
                {
                    result[i, j] = this[j, i];
                }
            }
            return result;
        }

        public double FindRank()
        {
            int rang = 0;
            int q = 1;

            while (q <= Math.Min(this.elems.GetLength(0), this.elems.GetLength(1)))
            {
                SquareMatrix matbv = new SquareMatrix(q);
                for (int i = 0; i < (this.elems.GetLength(0) - (q - 1)); i++)
                {
                    for (int j = 0; j < (elems.GetLength(1) - (q - 1)); j++)
                    {
                        for (int k = 0; k < q; k++)
                        {
                            for (int c = 0; c < q; c++)
                            {
                                matbv[k, c] = elems[i + k, j + c];
                            }
                        }

                        if (matbv.FindDeterminant() != 0)
                        {

                            rang = q;
                        }
                    }
                }
                q++;
            }

            return rang;
        }

        public static SquareMatrix operator ^(SquareMatrix a, double n)
        {
            SquareMatrix result;
            if (n > 0)
            {
                result = a;
                for (int i = 1; i < n; i++)
                {
                    result *= a;
                }
            } else if (n == 0)
            {
                result = new SquareMatrix(new double[,]{ { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } });
            } else
            {
                result = a;
            }
            return result;
        }

        // Оператор сложения двух матриц
        public static SquareMatrix operator +(SquareMatrix first_matrix, SquareMatrix second_matrix)
        {
            if ((first_matrix.Row == second_matrix.Row) && (first_matrix.Col == second_matrix.Col))
            {
                SquareMatrix result = new SquareMatrix(first_matrix.Row);
                for (int i = 0; i < result.Row; i++)
                {
                    for (int j = 0; j < result.Col; j++)
                    {
                        result[i, j] = first_matrix[i, j] + second_matrix[i, j];
                    }
                }
                return result;
            }
            else
            {
                throw new Exception("Размеры матриц не совпадают");
            }
        }
        // Оператор вычитания двух матриц
        public static SquareMatrix operator -(SquareMatrix first_matrix, SquareMatrix second_matrix)
        {
            if ((first_matrix.Row == second_matrix.Row) && (first_matrix.Col == second_matrix.Col))
            {
                SquareMatrix result = new SquareMatrix(first_matrix.Row);
                for (int i = 0; i < result.Row; i++)
                {
                    for (int j = 0; j < result.Col; j++)
                    {
                        result[i, j] = first_matrix[i, j] - second_matrix[i, j];
                    }
                }
                return result;
            }
            else
            {
                throw new Exception("Размеры матриц не совпадают");
            }
        }
        // Оператор умножения матрицы на число

        public static SquareMatrix operator *(SquareMatrix matrix, double n)
        {
            SquareMatrix result = new SquareMatrix(matrix.Row);
            for (int i = 0; i < result.Row; i++)
            {
                for (int j = 0; j < result.Col; j++)
                {
                    result[i, j] = matrix[i, j] * n;
                }
            }
            return result;
        }
        // Оператор умножения матриц

        public static SquareMatrix operator *(SquareMatrix first_matrix, SquareMatrix second_matrix)
        {
            if (first_matrix.Col == second_matrix.Row)
            {
                SquareMatrix result = new SquareMatrix(first_matrix.Row);
                //b = Transpose(b);
                for (int i = 0; i < first_matrix.Row; i++)
                    for (int j = 0; j < second_matrix.Col; j++)
                        for (int k = 0; k < second_matrix.Row; k++)
                            result[i, j] += first_matrix[i, k] * second_matrix[k, j];
                return result;
            }
            else
            {
                throw new Exception("Размеры матриц не совпадают");
            }
        }
    }
}
