using System.Windows.Forms;
using System;


namespace MatrixSumApp
{
    public partial class Form1 : Form
    {
        private int matrixSize;


        public Form1()
        {
            InitializeComponent();
            InitializeMatrixSizeComboBox();
        }
        void InitializeMatrixSizeComboBox()
        {
            comboBoxMatrixSize.Items.Add("3x3");
            comboBoxMatrixSize.Items.Add("6x6");
            comboBoxMatrixSize.Items.Add("9x9");

            comboBoxMatrixSize.SelectedIndex = 0;

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            string selectSize = comboBoxMatrixSize.SelectedItem.ToString();
            matrixSize = int.Parse(selectSize.Substring(0, 1));

            // »нициализируем матрицы.
            int[,] matrixA = new int[matrixSize, matrixSize];
            int[,] matrixB = new int[matrixSize, matrixSize];
            int[,] resultMatrix = new int[matrixSize, matrixSize];

            FillMatrixFromDataGridView(dataGridViewMatrixA, matrixA);
            FillMatrixFromDataGridView(dataGridViewMatrixB, matrixB);

            SumMatrices(matrixA, matrixB, resultMatrix);

            DisplayMatrixInDataGridView(dataGridViewResult, resultMatrix);

        }

        private void FillMatrixFromDataGridView(DataGridView dataGridView, int[,] matrix)
        {
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    // ѕроверка наличи€ строки и €чейки в DataGridView.
                    if (dataGridView.Rows.Count > i)
                    {
                        DataGridViewRow row = dataGridView.Rows[i];

                        // ѕроверка наличи€ €чейки в строке.
                        if (row.Cells.Count > j)
                        {
                            DataGridViewCell cell = row.Cells[j];

                            // ѕроверка наличи€ значени€ в €чейке.
                            if (cell.Value != null)
                            {
                                matrix[i, j] = int.Parse(cell.Value.ToString());
                            }
                            else
                            {
                                matrix[i, j] = 0; // «начение по умолчанию, если €чейка пуста.
                            }
                        }
                        else
                        {
                            matrix[i, j] = 0; // «начение по умолчанию, если €чейка отсутствует.
                        }
                    }
                    else
                    {
                        matrix[i, j] = 0; // «начение по умолчанию, если строка отсутствует.
                    }
                }
            }
        }


        private void DisplayMatrixInDataGridView(DataGridView dataGridView, int[,] matrix)
        {
            dataGridView.Rows.Clear();

            for (int i = 0; i < matrixSize; i++)
            {
                dataGridView.Rows.Add();
                for (int j = 0; j < matrixSize; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }
        private void SumMatrices(int[,] matrixA, int[,] matrixB, int[,] resultMatrix)
        {
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    resultMatrix[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }
        }

    }
}