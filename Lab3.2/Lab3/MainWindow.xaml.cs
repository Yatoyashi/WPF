using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnTasks_Click(object sender, RoutedEventArgs e)
        {
            textBox1.IsEnabled = false;
            textBox2.IsEnabled = false;
            textBox3.IsEnabled = false;
            int N = Convert.ToInt32(textBox1.Text);
            int count = 0;
            int summa = 0;
            int sr = 0;
            int t = 1;
            int percent = Convert.ToInt32(textBox2.Text);
            int Z = Convert.ToInt32(textBox3.Text);
            double sr2 = 0;
            double sr3 = 0;
            double sr4 = 0;
            string star = "";
            int[] array = new int[N];
            int[] arr1 = new int[N];
            int[] arr2 = new int[N];
            int[] arr3 = new int[N];
            int[] arr4 = new int[N];
            int[] arr5 = new int[N];
            int[] arr6 = new int[N];
            int[] arr7 = new int[N];
            int[] arr8 = new int[N];
            int[] arr9 = new int[N];
            int[] arr10 = new int[N];
            Random random = new Random();
            listBox1.SelectionMode = System.Windows.Controls.SelectionMode.Multiple;
            listBox1.SelectedIndex = -1;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox1.Items.Add(" ");
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                array[indexArray] = 5 + random.Next(30);
                listBox1.Items.Add(array[indexArray]);
            }
            for (int indexArray = 1; indexArray < N - 1; indexArray++)
            {
                if (array[indexArray] > array[indexArray - 1] && array[indexArray] > array[indexArray + 1])
                {
                    count++;
                }
            }
            listBox2.Items.Add("Задание " + t++);//1
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                for (int j = 0; j < array[indexArray]; j++)
                {
                    star = star + "■";
                }
                listBox2.Items.Add(star);
                star = "";
            }
            listBox2.Items.Add("[--------------------------------------------------------------------------------------------]");
            Array.Copy(array, arr1, N);
            listBox2.Items.Add("Задание " + t++);//2
            count = 0;
            for (int indexArray = 1; indexArray < N - 1; indexArray++)
            {
                if (arr1[indexArray] < arr1[indexArray - 1] && arr1[indexArray] < arr1[indexArray + 1])
                {
                    count++;
                }
            }
            if (arr1[0] < arr1[N - 1] && arr1[0] < arr1[1]) { count++; }
            if (arr1[N - 1] < arr1[0] && arr1[N - 1] < arr1[N - 2]) { count++; }
            if (count > 0)
            {
                listBox2.Items.Add("Кол-во элементов меньших своих соседей: " + count);
            }
            else
            {
                listBox2.Items.Add("Нет элементов, удовлетворяющих условию");
            }
            listBox2.Items.Add("[--------------------------------------------------------------------------------------------]");
            Array.Copy(array, arr2, N);
            listBox2.Items.Add("Задание " + t++);//3
            sr = 0;
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                summa = arr2[indexArray] + summa;
            }
            summa = summa / 2;
            listBox2.Items.Add(summa + " сумма");
            sr = summa / N;
            listBox2.Items.Add(sr + " среднее значение");
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                Array.Sort(arr2);
                if (arr2[indexArray] > sr)
                {
                    listBox2.Items.Add(arr2[indexArray] + " минимальное больше среднего");
                    break;
                }
            }
            listBox2.Items.Add("[--------------------------------------------------------------------------------------------]");
            Array.Copy(array, arr3, N);
            count = 0;
            listBox2.Items.Add("Задание " + t++);//4
            count = 0;
            for (int indexArray = 1; indexArray < N - 1; indexArray++)
            {
                if (arr3[indexArray] > arr3[indexArray - 1] && arr3[indexArray] < arr3[indexArray + 1])
                {
                    count++;
                }
            }
            if (arr3[0] > arr3[N - 1] && arr3[0] < arr3[1]) { count++; }
            if (arr3[N - 1] < arr3[0] && arr3[N - 1] > arr3[N - 2]) { count++; }
            if (count > 0)
            {
                listBox2.Items.Add("Кол-во элементов: " + count);
            }
            else
            {
                listBox2.Items.Add("Нет элементов, удовлетворяющих условию");
            }
            listBox2.Items.Add("[--------------------------------------------------------------------------------------------]");
            Array.Copy(array, arr4, N);
            listBox2.Items.Add("Задание " + t++);//5
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                if (indexArray == N)
                {
                    indexArray = 0;
                }
                listBox2.Items.Add(arr4[indexArray]);
            }
            listBox2.Items.Add("[--------------------------------------------------------------------------------------------]");
            Array.Copy(array, arr5, N);
            listBox2.Items.Add("Задание " + t++);//6
            for (int indexArray = 0; indexArray < N; indexArray++)
            {

                listBox2.Items.Add(arr5[indexArray]);
            }

            listBox2.Items.Add("-----");
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                arr5[indexArray] = arr5[indexArray] - sr;

                listBox2.Items.Add(arr5[indexArray]);
            }
            listBox2.Items.Add("[--------------------------------------------------------------------------------------------]");
            Array.Copy(array, arr6, N);
            listBox2.Items.Add("Задание " + t++);//7
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                summa = arr6[indexArray] + summa;
            }
            sr = summa / N;
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                sr2 = sr2 + (Math.Abs(arr6[indexArray] - sr));
            }
            sr3 = sr2 / N;
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                if (Math.Abs(arr6[indexArray] - sr) > sr3 / 2)
                {
                    arr6[indexArray] = sr;
                }
                listBox2.Items.Add(arr6[indexArray]);
            }
            listBox2.Items.Add("[--------------------------------------------------------------------------------------------]");
            Array.Copy(array, arr7, N);
            listBox2.Items.Add("Задание " + t++);//8
            sr2 = 0;
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                summa = arr7[indexArray] + summa;
            }
            sr = summa / N;
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                sr2 = sr2 + (Math.Abs(arr7[indexArray] - sr));
            }
            sr3 = sr2 / N;
            listBox2.Items.Add(sr3);
            sr4 = (((double)sr3 / 100) * percent);
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                if (Math.Abs(arr7[indexArray] - sr) > sr4)
                {
                    arr7[indexArray] = sr;
                }
                listBox2.Items.Add(arr7[indexArray]);
            }
            listBox2.Items.Add("[--------------------------------------------------------------------------------------------]");
            Array.Copy(array, arr8, N);
            listBox2.Items.Add("Задание " + t++);//9
            sr2 = 0;
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                summa = arr8[indexArray] + summa;
            }
            sr = summa / N;
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                sr2 = sr2 + (Math.Abs(arr8[indexArray] - sr));
            }
            sr3 = sr2 / N;
            listBox2.Items.Add(sr3);
            sr4 = (((double)sr3 / 100) * percent);
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                if (Math.Abs(arr8[indexArray] - sr) > sr4)
                {
                    arr8[indexArray] = Z;
                }
                listBox2.Items.Add(arr8[indexArray]);
            }
            listBox2.Items.Add("[--------------------------------------------------------------------------------------------]");
            Array.Copy(array, arr9, N);
            t = 16;
            listBox2.Items.Add("Задание " + t++);//16
            Random rand = new Random();
            int hit = 0;
            for (int indexArray = 0; indexArray < N-1; indexArray++)
            {
                listBox2.Items.Add("Исходное число: " + arr9[indexArray]);
                hit = 5 + rand.Next(10);
                listBox2.Items.Add("Ущерб: " + hit);
                arr9[indexArray] = arr9[indexArray] - hit;
                listBox2.Items.Add("Ответ: " + arr9[indexArray]);
                listBox2.Items.Add("-----");
            }
            listBox2.Items.Add("[--------------------------------------------------------------------------------------------]");

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            textBox1.IsEnabled = true;
            textBox2.IsEnabled = true;
            textBox3.IsEnabled = true;
        }
    }
}
