using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class ClassLib
    {
        public static double SumOfNegativeNumbers(double[] a)
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i += 1)
            {
                if (a[i] < 0)
                {
                    sum += a[i];
                }
            }
            return sum;
        }


        public static double Max(double[] a)
        {
            double max = a[0];

            for (int i = 0; i < a.Length; i += 1)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            return max;
        }


        public static int IndexOfMax(double[] a)
        {
            double max = a[0];
            int max_ind = 0;
            for (int i = 0; i < a.Length; i += 1)
            {
                if (max < a[i])
                {
                    max = a[i];
                    max_ind = i;
                }
            }
            return max_ind;
        }


        public static double AbsMax(double[] a)
        {
            double max = Math.Abs(a[0]);

            for (int i = 0; i < a.Length; i += 1)
            {
                if (max < Math.Abs(a[i]))
                {
                    max = Math.Abs(a[i]);
                }
            }
            return max;
        }


        public static double SumPositiveNumIndexes(double[] a)
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i += 1)
            {
                if (a[i] > 0)
                {
                    sum += i;
                }
            }
            return sum;
        }


        public static int AmountOfPositiveNumbers(double[] a)
        {
            int num = 0;
            for (int i = 0; i < a.Length; i += 1)
            {
                if (a[i] >= 0)
                    num++;
            }
            return num;
        }


        public static int AmountOfIntegers(double[] a)
        {
            int num = 0;
            for (int i = 0; i < a.Length; i += 1)
            {
                if (Math.Truncate(a[i]) == a[i])
                {
                    num += 1;
                }
            }
            return num;
        }


        public static void DescendingOrder(double[] a)
        {
            double saver;

            for (int i = 0; i < a.Length - 1; i += 1)
            {
                for (int j = i + 1; j < a.Length; j += 1)
                {
                    if (a[i] < a[j])
                    {
                        saver = a[i];
                        a[i] = a[j];
                        a[j] = saver;
                    }
                    else { }
                }
            }
        }


        public static double[] DeleteNegativeNumbers(double[] a)
        {
            double[] newArray = new double[AmountOfPositiveNumbers(a)];
            int j = 0;

            for (int i = 0; i < a.Length; i += 1)
            {
                if (a[j] >= 0)
                {
                    newArray[j] = a[i];
                    j++;
                }
            }
            return newArray;
        }
    }
}
