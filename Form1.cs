using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindMaxSum
{
    public partial class Form1 : Form
    {
        public int[][] jaggedArr;
        public List<int> values = new List<int>();
        List<int> totalList = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                jaggedArr = GetFileData(filePath);
                string[] lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                    listBoxFileContent.Items.Add(line);

                for (int i = 0; i < jaggedArr.GetLength(0); i++)
                {
                    for (int j = 0; j < jaggedArr[i].GetLength(0); j++)
                    {
                        List<int> list = new List<int>();
                        calcFonk(i, j, list);
                    }
                }
            }
        }

        private void calcFonk(int row, int col, List<int> list)
        {

            list.Add(jaggedArr[row][col]);

            int lastCol = jaggedArr[row].GetLength(0);
            int lastRow = jaggedArr.GetLength(0);

            for (int lp = 0; lp < lastCol; lp++)
            {
                if (lastCol >= col + lp && lastRow > row + 1)
                {
                    if (!isPrime(jaggedArr[row + 1][col + lp]))
                    {
                        List<int> newList = new List<int>();
                        newList.AddRange(list);
                        calcFonk(row + 1, col + lp, newList);
                        totalList.Add(Total(newList));
                    }
                }
                else
                    values.AddRange(list);
            }

            if (totalList.Count > 0)
                txtMaxSum.Text = totalList.Max().ToString();

        }

        private bool isPrime(int number)
        {
            bool isPrime = false;
            int count = 0;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                    break;
                }
            }
            if (count == 0)
                isPrime = true;
            return isPrime;
        }

        private int Total(List<int> list)
        {
            int total = 0;
            for (int i = 0; i < list.Count; ++i)
                total += list[i];
            return total;
        }

        public static int[][] GetFileData(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            int[][] result = new int[lines.Length][];

            int ln = 0;
            foreach (string line in lines)
            {
                string[] lineItems = line.Split(' ');
                result[ln] = new int[lineItems.Length];


                for (int lp = 0; lp < lineItems.Length; lp++)
                    result[ln][lp] = Convert.ToInt32(lineItems[lp]);
                ln++;
            }

            return result;
        }
    }
}

