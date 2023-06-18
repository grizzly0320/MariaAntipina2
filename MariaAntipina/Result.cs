using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MariaAntipina
{
    public partial class Result : Form
    {
        List<TextBox> textBoxes = new List<TextBox>();
        public  SquareMatrix matrix;
        public Result(SquareMatrix matrix)
        {
            InitializeComponent();
            this.matrix = matrix;
            for (int i = 1; i < 4; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    string index = i.ToString() + j.ToString();
                    textBoxes.Add((TextBox)Controls.Find("a" + index, true)[0]);
                }
            }
            int z = 0, k = 0;
            for (int i = 0; i < textBoxes.Count; i++)
            {
                textBoxes[i].Text = this.matrix.Elems[z, k].ToString();
                k++;
                if (k == 3)
                {
                    k = 0;
                    z++;
                }
            }
        }
        public Result(double num)
        {
            InitializeComponent();
            for (int i = 1; i < 4; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    string index = i.ToString() + j.ToString();
                    textBoxes.Add((TextBox)Controls.Find("a" + index, true)[0]);
                }
            }
            for (int i = 0; i < textBoxes.Count; i++)
            {
                textBoxes[i].Visible = false;
            }
            this.a22.Visible = true;
            this.a22.Text = num.ToString();
        }
    }
}
