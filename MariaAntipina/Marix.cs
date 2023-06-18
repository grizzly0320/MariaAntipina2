using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariaAntipina
{
    public class Matrix
    {
        private int row, col;
        private double[,] elems;
        public int Row => row;
        public int Col => col;
        public double[,] Elems => elems;
        public Matrix(int row, int col)
        {
            this.row = row;
            this.col = col;
            this.elems = new double[row, col];
        }
        public Matrix(double[,] elems)
        {
            this.row = elems.GetLength(1);
            this.col = elems.GetLength(0);
            this.elems = elems;
        }
        public Matrix(Matrix other)
        {
            this.row = other.Row;
            this.col = other.Col;
            this.elems = other.Elems;
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

        // Оператор сложения двух матриц
        public static Matrix operator +(Matrix first_matrix, Matrix second_matrix)
        {
            if ((first_matrix.Row == second_matrix.Row) && (first_matrix.Col == second_matrix.Col))
            {
                Matrix result = new Matrix(first_matrix.Row, first_matrix.Col);
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
        public static Matrix operator -(Matrix first_matrix, Matrix second_matrix)
        {
            if ((first_matrix.Row == second_matrix.Row) && (first_matrix.Col == second_matrix.Col))
            {
                Matrix result = new Matrix(first_matrix.Row, first_matrix.Col);
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

        public static Matrix operator *(Matrix matrix, double n)
        {
            Matrix result = new Matrix(matrix.Row, matrix.Col);
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

        public static Matrix operator *(Matrix first_matrix, Matrix second_matrix)
        {
            if (first_matrix.Col == second_matrix.Row)
            {
                Matrix result = new Matrix(first_matrix.Row, second_matrix.Col);
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
        // Функция транспонирования матрицы
        public virtual Matrix Transpose()
        {
            Matrix result = new Matrix(this.Col, this.Row);
            for (int i = 0; i < result.Row; i++)
            {
                for (int j = 0; j < result.Col; j++)
                {
                    result[i, j] = this[j, i];
                }
            }
            return result;
        }
 
        private int MinValue(int a, int b) {
            if (a >= b)
                return b;
            else
                return a;
        }

        // Перевод матpицы в строку
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Col; j++)
                {
                    s += $"{i + 1}:{j + 1} - " + this[i, j] + " \n";
                }
            }
            return s;
        }
    }
}
