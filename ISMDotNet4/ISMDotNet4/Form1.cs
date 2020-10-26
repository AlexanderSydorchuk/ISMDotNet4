using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISMDotNet4
{
    public partial class Form1 : Form
    {
        int num;
        bool clickable = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            if (clickable == true)
            {
                dtg_arr_enter.ColumnCount = num;
                dtg_arr_enter.RowCount = 1;

                Random rnd = new Random();

                for (int i = 0; i < num; i++)
                {
                    dtg_arr_enter.Columns[i].HeaderCell.Value = i.ToString();
                    dtg_arr_enter.Columns[i].Width = 30;
                }
            }
            else {}
        }

        private void tb_arr_length_TextChanged_1(object sender, EventArgs e)
        {
            if (!int.TryParse(tb_arr_length.Text, out num) || num <= 0)
            {
                lb_error.Visible = true;
                lb_error.Text = ("Число повинне бути цiлим i бiльшим за нуль!");
                clickable = false;
            }
            else
            {
                lb_error.Visible = false;
                clickable = true;
            }
        }

        private void b_DescendingOrder_Click(object sender, EventArgs e)
        {
            double[] array = new double[dtg_arr_enter.ColumnCount];

            for (int i = 0; i < array.Length; i++)
            {
                if (dtg_arr_enter.Rows[0].Cells[i].Value != null)
                {
                    array[i] = double.Parse(dtg_arr_enter.Rows[0].Cells[i].Value.ToString());
                }
            }

            double[] arrayDescendingOrder = ClassLibrary.Class1.DescendingOrder(array);

            dtg_arr_enter.ColumnCount = arrayDescendingOrder.Length;
            dtg_arr_enter.RowCount = 1;

            for (int i = 0; i < arrayDescendingOrder.Length; i += 1)
            {
                dtg_arr_enter.Columns[i].HeaderCell.Value = i.ToString();
                dtg_arr_enter[i, 0].Value = arrayDescendingOrder[i];
            }

        }

        private void b_accept_Click(object sender, EventArgs e)
        {
            if (clickable == true)
            {

                double[] array = new double[dtg_arr_enter.ColumnCount];

                for (int i = 0; i < array.Length; i++)
                {
                    if (dtg_arr_enter.Rows[0].Cells[i].Value != null)
                    {
                        array[i] = double.Parse(dtg_arr_enter.Rows[0].Cells[i].Value.ToString());
                    }

                }

                double result_SumOfNegativeNumbers = ClassLibrary.Class1.SumOfNegativeNumbers(array);
                lb_SumOfNegative.Text = ("Сума від'ємних чисел: " + result_SumOfNegativeNumbers.ToString());

                double result_Max = ClassLibrary.Class1.Max(array);
                lb_Max.Text = ("Максимальне число: " + result_Max.ToString());

                double result_IndexOfMax = ClassLibrary.Class1.IndexOfMax(array);
                lb_IndexOfMax.Text = ("Індекс максимального числа: " + result_IndexOfMax.ToString());

                double result_AbsMax = ClassLibrary.Class1.AbsMax(array);
                lb_AbsMax.Text = ("Максимальне число по модулю: " + result_AbsMax.ToString());

                double result_SumPositiveNumIndexes = ClassLibrary.Class1.SumPositiveNumIndexes(array);
                lb_SumPositiveNumIndexes.Text = ("Сума індексів додатних чисел: " + result_SumPositiveNumIndexes.ToString());

                double result_AmountOfPositiveNumbers = ClassLibrary.Class1.AmountOfPositiveNumbers(array);
                lb_AmountOfPositiveNumbers.Text = ("Кількість додатних чисел: " + result_AmountOfPositiveNumbers.ToString());

                double result_AmountOfIntegers = ClassLibrary.Class1.AmountOfIntegers(array);
                lb_AmountOfIntegers.Text = ("Кількість цілих чисел: " + result_AmountOfIntegers.ToString());
            }
        }

        private void b_DeleteNegativeNumbers_Click(object sender, EventArgs e)
        {

            double[] array = new double[dtg_arr_enter.ColumnCount];

            for (int i = 0; i < array.Length; i++)
            {
                if (dtg_arr_enter.Rows[0].Cells[i].Value != null)
                {
                    array[i] = double.Parse(dtg_arr_enter.Rows[0].Cells[i].Value.ToString());
                }
            }

            double[] arrayDescendingOrder = ClassLibrary.Class1.DescendingOrder(array);

            dtg_arr_enter.ColumnCount = arrayDescendingOrder.Length;
            dtg_arr_enter.RowCount = 1;

            for (int i = 0; i < arrayDescendingOrder.Length; i += 1)
            {
                dtg_arr_enter.Columns[i].HeaderCell.Value = i.ToString();
                dtg_arr_enter[i, 0].Value = arrayDescendingOrder[i];
            }

            double[] arrayDeleteNegativeNumbers = ClassLibrary.Class1.DeleteNegativeNumbers(arrayDescendingOrder);

            dtg_arr_enter.ColumnCount = arrayDeleteNegativeNumbers.Length;
            dtg_arr_enter.RowCount = 1;

            for (int i = 0; i < arrayDeleteNegativeNumbers.Length; i += 1)
            {
                dtg_arr_enter.Columns[i].HeaderCell.Value = i.ToString();
                dtg_arr_enter[i, 0].Value = arrayDeleteNegativeNumbers[i];
            }

        }
    }
}
